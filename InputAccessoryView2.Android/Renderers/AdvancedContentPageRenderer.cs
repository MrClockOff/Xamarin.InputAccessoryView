using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using InputAccessoryView2.Controls;
using InputAccessoryView2.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(AdvancedContentPage), typeof(AdvancedContentPageRenderer))]
namespace InputAccessoryView2.Droid.Renderers
{
    public class AdvancedContentPageRenderer : PageRenderer
    {
        public AdvancedContentPageRenderer(Context context) : base(context)
        {
        }

        protected override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();

            var child = GetChildAt(0);

            System.Diagnostics.Debug.WriteLine(child.GetType().ToString());
        }       
    }
}
