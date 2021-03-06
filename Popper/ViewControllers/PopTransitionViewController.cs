// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using Popper.Utilities;
using UIKit;

namespace Popper
{
    public partial class PopTransitionViewController : UIViewController
    {
        float DynamicsMass;

        float DynamicsTension;

        float DynamicsFriction;

        public PopTransitionViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            GetUserDefaults();
            this.TransitioningDelegate = new PopTransitioningDelegate(DynamicsMass, DynamicsTension, DynamicsFriction);
            button1.TouchUpInside += Button1TouchUpInside;
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
            button1.TouchUpInside -= Button1TouchUpInside;
        }

        void GetUserDefaults()
        {
            DynamicsMass = NSUserDefaults.StandardUserDefaults.FloatForKey("slider1");
            DynamicsTension = NSUserDefaults.StandardUserDefaults.FloatForKey("slider2");
            DynamicsFriction = NSUserDefaults.StandardUserDefaults.FloatForKey("slider3");

            var minimumDynamicValue = 1f;
            DynamicsMass = DynamicsMass < minimumDynamicValue ? Constants.DefaultPopDynamicsMass : DynamicsMass;
            DynamicsTension = DynamicsTension < minimumDynamicValue ? Constants.DefaultPopDynamicsTension : DynamicsTension;
            DynamicsFriction = DynamicsFriction < minimumDynamicValue ? Constants.DefaultPopDynamicsFriction : DynamicsFriction;
        }

        void Button1TouchUpInside(object sender, EventArgs e)
        {
            DismissModalViewController(true);
        }
    }
}
