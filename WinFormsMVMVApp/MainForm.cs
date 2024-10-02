namespace WinFormsMVMVApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.DataContext = new EmployeesModel();


            // LISTBOX -> EMPLOYEESMODEL
            // DataSource -> Employees
            listBoxEmployees.DataBindings.Add(new Binding("DataSource", 
                                                           DataContext, 
                                                           "Employees", 
                                                           false, 
                                                           DataSourceUpdateMode.OnPropertyChanged));
            listBoxEmployees.ValueMember = "Id";
            listBoxEmployees.DisplayMember = "Name";

            // SelectedValue -> SelectedEmployeeId
            //listBoxEmployees.DataBindings.Add(new Binding("SelectedValue",
            //                                               DataContext,
            //                                               "SelectedEmployeeId",
            //                                               false,
            //                                               DataSourceUpdateMode.OnPropertyChanged));

            textBoxName.DataBindings.Add(new Binding("Text",
                                                      DataContext,
                                                      "Name",
                                                      false,
                                                      DataSourceUpdateMode.OnPropertyChanged));
            numericUpDownAge.DataBindings.Add(new Binding("Value",
                                                           DataContext,
                                                           "Age",
                                                           false,
                                                           DataSourceUpdateMode.OnPropertyChanged));
            buttonSave.DataBindings.Add(new Binding("Command",
                                                     DataContext,
                                                     "AddCommand",
                                                     true,
                                                     DataSourceUpdateMode.OnPropertyChanged));
            buttonDelete.DataBindings.Add(new Binding("Command",
                                                       DataContext,
                                                       "DeleteCommand",
                                                       true,
                                                       DataSourceUpdateMode.OnPropertyChanged));
            buttonDelete.DataBindings.Add(new Binding("CommandParameter",
                                                       listBoxEmployees,
                                                       "SelectedValue",
                                                       false,
                                                       DataSourceUpdateMode.OnPropertyChanged));

        }
    }
}
