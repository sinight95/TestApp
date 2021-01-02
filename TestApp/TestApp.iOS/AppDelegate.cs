using Foundation;
using MvvmCross.Platforms.Ios.Core;
using TestApp.Core;

namespace TestApp.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
    {
    }
}

