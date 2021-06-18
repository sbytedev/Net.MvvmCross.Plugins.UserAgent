using MvvmCross;
using SByteDev.Xamarin.Plugins.UserAgent;
using System.Threading;
using System.Threading.Tasks;

namespace SByteDev.MvvmCross.Plugins.UserAgent
{
    [Preserve(AllMembers = true)]
    internal sealed class MvxUserAgent : IMvxUserAgent
    {
        Task<string> IMvxUserAgent.GetUserAgentAsync(CancellationToken cancellationToken)
        {
            return UserAgentPlugin.Instance.GetUserAgentAsync(cancellationToken);
        }
    }
}
