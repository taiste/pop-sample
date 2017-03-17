// This file has been autogenerated from a class added in the UI designer.

using System;
using CoreAnimation;
using CoreGraphics;
using Facebook.Pop;
using Foundation;
using Popper.Utilities;
using UIKit;

namespace Popper
{
    public partial class BasicViewController : UIViewController
    {
        CGRect BoxFrame;

        public BasicViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            animationView.Layer.CornerRadius = Constants.DefaultBoxEdge / 4;
            InitBox();
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            InitButtons();
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
            button1.TouchUpInside -= Button1TouchUpInside;
        }

        void InitButtons()
        {
            button1.TouchUpInside += Button1TouchUpInside;
            button1.TouchDown += Button1TouchDown;
        }

        void Button1TouchUpInside(object sender, EventArgs e)
        {
            BoxSizeAnimation();
        }

        void Button1TouchDown(object sender, EventArgs e)
        {
            BoxTeaseAnimation();
        }

        void BoxTeaseAnimation()
        {
            var animationSize = POPBasicAnimation.AnimationWithPropertyNamed(POPAnimation.ViewSize);
            var size = new CGSize(BoxFrame.Width * 1.3, BoxFrame.Height * 1.3);
            animationSize.TimingFunction = CAMediaTimingFunction.FromName(CAMediaTimingFunction.EaseInEaseOut);
            animationSize.ToValue = NSValue.FromCGSize(size);
            animationSize.AutoReverse = true;
            animationView.Layer.AddAnimation(animationSize, "size");

            var animationCorner = POPBasicAnimation.AnimationWithPropertyNamed(POPAnimation.LayerCornerRadius);
            animationCorner.TimingFunction = CAMediaTimingFunction.FromName(CAMediaTimingFunction.EaseInEaseOut);
            animationCorner.ToValue = NSObject.FromObject(size.Width / 2);
            animationCorner.AutoReverse = true;
            animationView.Layer.AddAnimation(animationCorner, "cornerRadius");
        }

        void BoxSizeAnimation()
        {
            var animationSize = POPBasicAnimation.AnimationWithPropertyNamed(POPAnimation.ViewSize);
            var viewHeight = UIScreen.MainScreen.Bounds.Height;
            var size = animationView.Bounds.Size.Height > viewHeight ? new CGSize(BoxFrame.Width, BoxFrame.Height) : new CGSize(viewHeight * 4, viewHeight * 4);
            animationSize.TimingFunction = CAMediaTimingFunction.FromName(CAMediaTimingFunction.EaseInEaseOut);
            animationSize.ToValue = NSValue.FromCGSize(size);
            animationView.Layer.AddAnimation(animationSize, "size");

            var animationCorner = POPBasicAnimation.AnimationWithPropertyNamed(POPAnimation.LayerCornerRadius);
            animationCorner.TimingFunction = CAMediaTimingFunction.FromName(CAMediaTimingFunction.EaseInEaseOut);
            animationCorner.ToValue = NSObject.FromObject(size.Width / 2);
            animationView.Layer.AddAnimation(animationCorner, "cornerRadius");
        }

        void InitBox()
        {
            BoxFrame = animationView.Frame;
        }
    }
}