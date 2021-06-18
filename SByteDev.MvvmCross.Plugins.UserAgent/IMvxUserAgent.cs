using System.Threading;
using System.Threading.Tasks;

namespace SByteDev.MvvmCross.Plugins.UserAgent
{
    public interface IMvxUserAgent
    {
        Task<string> GetUserAgentAsync(CancellationToken cancellationToken);
    }
}
