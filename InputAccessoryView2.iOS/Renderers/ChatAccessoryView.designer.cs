// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace InputAccessoryView2.iOS.Renderers
{
    [Register ("ChatAccessoryView")]
    partial class ChatAccessoryView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ActionButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Placeholder { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView TextView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ActionButton != null) {
                ActionButton.Dispose ();
                ActionButton = null;
            }

            if (Placeholder != null) {
                Placeholder.Dispose ();
                Placeholder = null;
            }

            if (TextView != null) {
                TextView.Dispose ();
                TextView = null;
            }
        }
    }
}