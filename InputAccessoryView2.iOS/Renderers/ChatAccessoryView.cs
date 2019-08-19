using CoreGraphics;
using Foundation;
using System;
using UIKit;

namespace InputAccessoryView2.iOS.Renderers
{
    public partial class ChatAccessoryView : UIView
    {
        private float PaddingTop => 8.0f;
        private float PaddingBottom => 8.0f;
        private float MaxHeight => 125.0f;
        private float MinHeight => 49.0f;

        public ChatAccessoryView (IntPtr handle) : base (handle)
        {
        }

        public static ChatAccessoryView Create(string placeholder = null)
        {
            var topLevelObjects = NSBundle.MainBundle.LoadNib("ChatAccessoryView", null, null);
            var rootView = topLevelObjects.GetItem<ChatAccessoryView>(0);

            rootView.Placeholder.Text = placeholder;
            rootView.TextView.Ended += rootView.TextView_Ended;
            rootView.TextView.Changed += rootView.TextView_Changed;
            rootView.UpdatePlaceholderVisibility();
            
            return rootView;
        }        

        public override CGSize IntrinsicContentSize
        {
            get
            {
                TextView.ScrollEnabled = false;

                var size = TextView.SizeThatFits(new CGSize(TextView.Frame.Width, float.MaxValue));
                var totalHeight = size.Height + PaddingTop + PaddingBottom;
                if (totalHeight <= MaxHeight)
                {
                    return new CGSize(Bounds.Width, Math.Max(totalHeight, MinHeight));
                }

                TextView.ScrollEnabled = true;
                return new CGSize(Bounds.Width, MaxHeight);
            }
        }

        private void TextView_Ended(object sender, EventArgs e)
        {
            UpdatePlaceholderVisibility();
        }

        private void TextView_Changed(object sender, EventArgs e)
        {
            InvalidateIntrinsicContentSize();
            UpdateConstraints();
            UpdatePlaceholderVisibility();
        }

        private void UpdatePlaceholderVisibility()
        {
            Placeholder.Hidden = !string.IsNullOrEmpty(TextView.Text);
        }
    }
}
