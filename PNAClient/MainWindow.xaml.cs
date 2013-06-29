///////////////////////////////////////////////////////
//Author: Adrian Calinciuc (adrian.calinciuc@gmail.com)
////////////////////////////////////////////////////////

using PNAViewModel;

namespace PNAClient
{
    using System.Windows;
    using Microsoft.Kinect;
    using Microsoft.Kinect.Toolkit;
    using PNAShared;
    using System.Windows.Media;
    using PNAViews.Cards;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static readonly DependencyProperty KinectSensorProperty =
            DependencyProperty.Register("KinectSensor", typeof (KinectSensorChooser), typeof (MainWindow),
                                        new PropertyMetadata(default(KinectSensor)));

        public KinectSensorChooser KinectSensor
        {
            get { return (KinectSensorChooser) GetValue(KinectSensorProperty); }
            set { SetValue(KinectSensorProperty, value); }
        }

        public MainWindow()
        {
            InitializeComponent();
            Unloaded += MainWindow_Unloaded;
            KinectSensor = new KinectSensorChooser();
            KinectSensor.Start();

            //this line should be done by the flowcontroller aka Navigation manager etc. 
            _EmployeesView.InitialiseModel(typeof(EmployeesViewModel));
            AppRoutedCommands.ShowDetail.ExecuteTargets += ShowBck_ExecuteTargets;
            AppRoutedCommands.ShowDetail.CanExecuteTargets += ShowDetail_CanExecuteTargets;
        }

        bool ShowDetail_CanExecuteTargets()
        {
            //find detail resource
            return true;
        }

        void ShowDetail_CanExecuteChanged(object sender, System.EventArgs e)
        {
            MessageBox.Show("ShowDetail_CanExecuteChanged");
        }

        void ShowBck_ExecuteTargets(FrameworkElement obj)
            
        {

            if (obj != null)
            {   //Get Current navigationContext
                //_nr : _EmployeesView;
                //obtain the first visualPanel refernce in order to add the visual child;
               DependencyObject d =  VisualTreeHelper.GetChild(_EmployeesView, 0); 

                while(!(d is Panel) && d!=null)
                {
                 d =  VisualTreeHelper.GetChild(d, 0); 
                }
                if (d != null)
                {   
                    //verify if there allready is an EmployeeCard added to the host and use that
                    //also recycle reference via container :D

                    EmployeeCard eCard = new EmployeeCard();
                    eCard.ApplyTemplate();
                    eCard.DataContext = obj.DataContext;
                
                    (d as Panel).Children.Add(eCard);
                    eCard.ActivateCard(null);
                }
            }
            
        }

        void MainWindow_Unloaded(object sender, RoutedEventArgs e)
        {
           if(KinectSensor!=null)
               KinectSensor.Stop();
        }

        private void KinectTileButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("pam pam");
        }


    }
}
