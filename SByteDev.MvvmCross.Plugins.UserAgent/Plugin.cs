using MvvmCross;
using MvvmCross.Plugin;

namespace SByteDev.MvvmCross.Plugins.UserAgent
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
