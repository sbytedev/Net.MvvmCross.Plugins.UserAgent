using MvvmCross;
using MvvmCross.Plugin;

namespace SByte.MvvmCross.Plugins.UserAgent.Android
{
    [MvxPlugin]
    [Preserve(AllMembers = true)]
    public sealed class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.IoCProvider.RegisterSingleton<IMvxUserAgent>(new MvxUserAgent());
        }
    }
}