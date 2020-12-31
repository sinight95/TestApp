using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace TestApp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainViewModel>();
        }
    }
}
