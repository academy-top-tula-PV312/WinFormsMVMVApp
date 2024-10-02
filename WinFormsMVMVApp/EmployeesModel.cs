using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WinFormsMVMVApp
{
    public class EmployeesModel : INotifyPropertyChanged
    {
        public BindingList<Employee> Employees { get; }

        string name;
        int age;

        public string Name
        {
            get => name;
            set
            {
                if (value != name)
                {
                    name = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public int Age
        {
            get => age;
            set
            {
                if (value != age)
                {
                    age = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        

        public EmployeesModel()
        {
            Employees = new()
            {
                new Employee(){ Name = "Bobby", Age = 27 },
                new Employee(){ Name = "Sammy", Age = 32 },
                new Employee(){ Name = "Kenny", Age = 19 },
            };

            AddCommand = new EmployeeCommand(_ => {
                Employees.Add(new Employee() { Name = this.Name, Age = this.Age });
                Name = "";
                Age = 0;
            });

            DeleteCommand = new EmployeeCommand(obj =>
            {
                if(obj is int id)
                {
                    Employee? employee = Employees.FirstOrDefault(e => e.Id == id);
                    if (employee is not null)
                        Employees.Remove(employee);
                }
            },_ =>
            {
                return Employees.Count > 0;
            }

            );
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
    }
}
