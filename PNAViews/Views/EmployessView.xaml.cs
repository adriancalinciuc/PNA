using System;
using System.Windows;
using System.Windows.Controls;
using PNAViewModel;
using PNAShared;


namespace PNAViews
{
    /// <summary>
    /// Interaction logic for EmployessView.xaml
    /// </summary>
    public partial class EmployessView : BaseView
    {
        public EmployeesViewModel Model
        {
            get { return model as EmployeesViewModel; }
        }

        public EmployessView()
        {
            InitializeComponent();
            this.Loaded += EmployessView_Loaded;
        }

        void EmployessView_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            //to be replaced by container initialisation
       //     model = new EmployeesViewModel();

            //to mockup
            ToMockup(Model);
          
           
        }

        /// <summary>
        /// Overlay the full screen view of the image
        /// </summary>
        private void OnDisplayFullImage(object sender, RoutedEventArgs e)
        {
              
            //var employee = ((ContentControl)e.OriginalSource).Content as EmployeeViewModel;
            //Model.CurrentEmployee = employee;
            //employeeCard.ActivateCard(e);
            
        }
        
        private void ToMockup(EmployeesViewModel employeesViewModel)
        {
            employeesViewModel.Employees.Add(new EmployeeViewModel()
                    {
                        Id = "ADB",
                        CatchPhrase = "Toys and games",
                        Name = "Adrian",
                        CompanyPosition = "Project Manager",
                        ImageUri = new Uri("pack://application:,,,/PNAClient;component/TestImages/Adrian_Bondiuc_fin.jpg")
                    });
            employeesViewModel.Employees.Add(new EmployeeViewModel()
            {
                Id = "AIB",
                CatchPhrase = "Electronic geek",
                Name = "Adrian",
                CompanyPosition = "Team Lead",
                ImageUri = new Uri("pack://application:,,,/PNAClient;component/TestImages/Adrian_Breazu_fin.jpg")
            });
            employeesViewModel.Employees.Add(new EmployeeViewModel()
            {
                Id = "AIC",
                CatchPhrase = "Road tripper",
                Name = "Adrian",
                CompanyPosition = "Project Manager",
                ImageUri = new Uri("pack://application:,,,/PNAClient;component/TestImages/Adrian_Cighi_fin.jpg")
            });
            employeesViewModel.Employees.Add(new EmployeeViewModel()
            {
                Id = "AIS",
                CatchPhrase = "the one and only",
                Name = "Adrian",
                CompanyPosition = "Team Lead",
                ImageUri = new Uri("pack://application:,,,/PNAClient;component/TestImages/Adrian_Staicu_fin.jpg")
            });
            employeesViewModel.Employees.Add(new EmployeeViewModel()
            {
                Id = "CTB",
                CatchPhrase = "pingy ponghish",
                Name = "Catalina",
                CompanyPosition = "Project Manager",
                ImageUri = new Uri("pack://application:,,,/PNAClient;component/TestImages/Catalina_Barbat_fin.jpg")
            });
            employeesViewModel.Employees.Add(new EmployeeViewModel()
            {
                Id = "CLF",
                CatchPhrase = "car expert",
                Name = "Claudiu",
                CompanyPosition = "Cluster Manager",
                ImageUri = new Uri("pack://application:,,,/PNAClient;component/TestImages/Daniel_Lar_fin.jpg")
            });
            employeesViewModel.Employees.Add(new EmployeeViewModel()
            {
                Id = "CIP",
                CatchPhrase = "dancing princess",
                Name = "Cristina",
                CompanyPosition = "Team Lead",
                ImageUri = new Uri("pack://application:,,,/PNAClient;component/TestImages/Cristina_Prodan_fin.jpg")
            });
            employeesViewModel.Employees.Add(new EmployeeViewModel()
            {
                Id = "RZ",
                CatchPhrase = "in concert",
                Name = "Ramon",
                CompanyPosition = "Rock Star",
                ImageUri = new Uri("pack://application:,,,/PNAClient;component/TestImages/ramon-230x230.jpg")
            });
        }
    }
}
