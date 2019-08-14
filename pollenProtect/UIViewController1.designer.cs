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

namespace testBartPhone
{
    [Register ("UIViewController1")]
    partial class UIViewController1
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView cameraPreview { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imageHappy { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imageSad { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch pollenSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel predPercentage { get; set; }

        [Action ("pollenTreeChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void pollenTreeChanged (UIKit.UISwitch sender);

        [Action ("UIButton5537_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton5537_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton623_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton623_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (cameraPreview != null) {
                cameraPreview.Dispose ();
                cameraPreview = null;
            }

            if (imageHappy != null) {
                imageHappy.Dispose ();
                imageHappy = null;
            }

            if (imageSad != null) {
                imageSad.Dispose ();
                imageSad = null;
            }

            if (pollenSwitch != null) {
                pollenSwitch.Dispose ();
                pollenSwitch = null;
            }

            if (predPercentage != null) {
                predPercentage.Dispose ();
                predPercentage = null;
            }
        }
    }
}