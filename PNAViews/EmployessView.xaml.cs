using System;
using System.Windows;
using System.Windows.Controls;
using PNAViewModel;

namespace PNAViews
{
    /// <summary>
    /// Interaction logic for EmployessView.xaml
    /// </summary>
    public partial class EmployessView : UserControl
    {
        public EmployeesViewModel model;
     

        public EmployessView()
        {
            InitializeComponent();
            this.Loaded += EmployessView_Loaded;
        }

        void EmployessView_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            model = new EmployeesViewModel();

            //to mockup
            ToMockup(model);
            model.CurrentEmployee = model.Employees[0];
            this.DataContext = model;
        }

        /// <summary>
        /// Overlay the full screen view of the image
        /// </summary>
        private void OnDisplayFullImage(object sender, RoutedEventArgs e)
        {
            employeeCard.ActivateCard(e);
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
                Id = "MP",
                CatchPhrase = "in concert",
                Name = "Marcel",
                CompanyPosition = "Cluster Manager",
                ImageUri = new Uri("pack://application:,,,/PNAClient;component/TestImages/Daniel_Taut_fin.jpg")
            });
        }
    }
}
