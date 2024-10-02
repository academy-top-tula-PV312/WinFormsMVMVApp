using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WinFormsMVMVApp
{
    public class EmployeeCommand : ICommand
    {
        Action<object?> action;

        Predicate<object?> predicate;

        public EmployeeCommand(Action<object?> action, Predicate<object?> predicate = null)
        {
            this.action = action;
            this.predicate = predicate;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            if(predicate != null)
                return predicate(parameter);
            
            return true;
        }

        public void Execute(object? parameter)
        {
            action?.Invoke(parameter);
        }
    }
}
