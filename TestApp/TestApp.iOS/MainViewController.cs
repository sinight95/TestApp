using System;
using MvvmCross.Platforms.Ios.Views;
using TestApp.Core;
using UIKit;

namespace TestApp.iOS
{
    public class MainViewController : MvxViewController<MainViewModel>
    {
        public MainViewController() : base(nameof(MainViewController), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.Blue;
        }
    }
}
