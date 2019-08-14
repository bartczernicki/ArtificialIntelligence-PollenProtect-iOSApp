using System;

using UIKit;

namespace testBartPhone
{
    public partial class ViewController : UIViewController
    {
        partial void UIButton589_TouchUpInside(UIButton sender)
        {
            //throw new NotImplementedException();
        }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        partial void newSliderChanged(UISlider sender)
        {
            var predValue = Math.Round(this.predSlider.Value, 2);
            this.predictionValue.Text = predValue.ToString();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
