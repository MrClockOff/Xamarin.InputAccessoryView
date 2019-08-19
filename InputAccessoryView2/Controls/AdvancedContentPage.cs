using Xamarin.Forms;

namespace InputAccessoryView2.Controls
{
    public class AdvancedContentPage : ContentPage
    {
        public static BindableProperty InputAccessoryViewProperty = BindableProperty.Create(nameof(InputAccessoryView), typeof(View), typeof(AdvancedContentPage));

        public View InputAccessoryView
        {
            get { return GetValue(InputAccessoryViewProperty) as View; }
            set { SetValue(InputAccessoryViewProperty, value); }
        }
    }
}
