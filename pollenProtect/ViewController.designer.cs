// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace testBartPhone
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel predictionValue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider predSlider { get; set; }

        [Action ("newSliderChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void newSliderChanged (UIKit.UISlider sender);

        [Action ("UIButton589_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton589_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (predictionValue != null) {
                predictionValue.Dispose ();
                predictionValue = null;
            }

            if (predSlider != null) {
                predSlider.Dispose ();
                predSlider = null;
            }
        }
    }
}