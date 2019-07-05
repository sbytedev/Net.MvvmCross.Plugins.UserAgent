using System.Threading;
using System.Threading.Tasks;

namespace SByte.MvvmCross.Plugins.UserAgent
{
    public interface IMvxUserAgent
    {
        Task<string> GetUserAgentAsync(CancellationToken cancellationToken);
    }
}