using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using PNAViewModel;

namespace PNAViews.Cards
{
    /// <summary>
    /// Interaction logic for EmployeeCard.xaml
    /// </summary>
    public partial class EmployeeCard : BaseCard
    {
        private EmployeeViewModel Model 
        {
            get { return this.DataContext as EmployeeViewModel; }
        }

        public static readonly DependencyProperty SelectedImageProperty = DependencyProperty.Register(
         "SelectedImage", typeof(ImageSource), typeof(EmployeeCard), new PropertyMetadata(default(ImageSource)));


        /// <summary>
        /// CLR Property Wrappers for SelectedImageProperty
        /// </summary>
        public ImageSource SelectedImage
        {
            get
            {
                return (ImageSource)GetValue(SelectedImageProperty);
            }

            set
            {
                this.SetValue(SelectedImageProperty, value);
            }
        }

        public EmployeeCard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overlay the full screen view of the image
        /// </summary>
        public override  void ActivateCard(RoutedEventArgs e)
        {  
            // Always go to normal state before a transition
            var employee = ((ContentControl)e.OriginalSource).Content as EmployeeViewModel;
            if (employee != null)
            {
                SelectedImage = new BitmapImage(employee.ImageUri);
            }
            base.ActivateCard(e);
        }
    }
}
