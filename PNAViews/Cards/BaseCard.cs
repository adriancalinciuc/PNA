using System.Windows;
using System.Windows.Controls;
using Microsoft.Kinect.Toolkit.Controls;

namespace PNAViews.Cards
{
    /// <summary>
    /// Interaction logic for BaseCard.xaml
    /// </summary>
    public  class BaseCard : ContentControl
    {
        /// <summary>
        /// Name of the non-transitioning visual state.
        /// </summary>
        internal const string NormalState = "Normal";

        /// <summary>
        /// Name of the fade in transition.
        /// </summary>
        internal const string FadeInTransitionState = "FadeIn";

        /// <summary>
        /// Name of the fade out transition.
        /// </summary>
        internal const string FadeOutTransitionState = "FadeOut";

        private Grid overlayGrid;
        private KinectCircleButton closeButton;


        static BaseCard()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BaseCard), new FrameworkPropertyMetadata(typeof(BaseCard)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            overlayGrid = GetTemplateChild("OverlayGrid") as Grid;
            closeButton = GetTemplateChild("CloseButton") as KinectCircleButton;
            if (closeButton != null)
                closeButton.Click += OnCloseFullImage;
        }
        /// <summary>
        /// Close the full screen view of the image
        /// </summary>
        private void OnCloseFullImage(object sender, RoutedEventArgs e)
        {
            if (overlayGrid == null) return;
            //// Always go to normal state before a transition
            VisualStateManager.GoToElementState(overlayGrid, NormalState, false);
            VisualStateManager.GoToElementState(overlayGrid, FadeOutTransitionState, true);
        }

        /// <summary>
        /// Overlay the full screen view of the image
        /// </summary>
        public virtual void ActivateCard(RoutedEventArgs e)
        {
            if (overlayGrid == null) return;
            VisualStateManager.GoToElementState(overlayGrid, NormalState, false);
            VisualStateManager.GoToElementState(overlayGrid, FadeInTransitionState, false);
        }
    }
}
