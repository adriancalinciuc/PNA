///////////////////////////////////////////////////////
//Author: Adrian Calinciuc (adrian.calinciuc@gmail.com)
////////////////////////////////////////////////////////

namespace PNAClient
{
    using System.Windows;
    using Microsoft.Kinect;
    using Microsoft.Kinect.Toolkit;

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
