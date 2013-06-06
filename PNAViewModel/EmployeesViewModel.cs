using System.Collections.ObjectModel;

namespace PNAViewModel
{
   public  class EmployeesViewModel:ViewModelBase
    {
        private ObservableCollection<EmployeeViewModel> employees;
        private EmployeeViewModel currentEmployee;

        public EmployeesViewModel()
        {
            employees = new ObservableCollection<EmployeeViewModel>();
            currentEmployee =  new EmployeeViewModel();
        }

        public ObservableCollection<EmployeeViewModel> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        public EmployeeViewModel CurrentEmployee
        {
            get { return currentEmployee; }
            set { currentEmployee = value; OnPropertyChanged("CurrentEmployee"); }
        }
    }
}
