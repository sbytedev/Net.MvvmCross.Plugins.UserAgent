using Foundation;
using MvvmCross.Platforms.Ios.Core;
using UIKit;

namespace SByteDev.MvvmCross.Plugins.UserAgent.Demo.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
    {
        private static void Main(string[] args)
        {
            UIApplication.Main(args, null, nameof(AppDelegate));
        }
    }
}