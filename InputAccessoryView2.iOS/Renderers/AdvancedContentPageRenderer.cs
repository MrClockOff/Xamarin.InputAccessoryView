using InputAccessoryView2.Controls;
using InputAccessoryView2.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(AdvancedContentPage), typeof(AdvancedContentPageRenderer))]
namespace InputAccessoryView2.iOS.Renderers
{
    public class AdvancedContentPageRenderer : PageRenderer
    {
        private UIView _inputAccessoryView;

        public override UIView InputAccessoryView
        {
            get
            {
                if (_inputAccessoryView == null)
                {
                    _inputAccessoryView = ChatAccessoryView.Create("Comment on this...");
                }

                return _inputAccessoryView;
            }
        }

        public override bool CanBecomeFirstResponder => true;

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            BecomeFirstResponder();
        }
    }
}
