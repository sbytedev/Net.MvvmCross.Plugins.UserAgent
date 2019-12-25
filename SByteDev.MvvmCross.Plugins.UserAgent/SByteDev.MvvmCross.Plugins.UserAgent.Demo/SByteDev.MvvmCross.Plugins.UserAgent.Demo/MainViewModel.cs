using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace SByteDev.MvvmCross.Plugins.UserAgent.Demo
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxUserAgent _userAgent;

        public string UserAgent { get; private set; }

        public ICommand LoadUserAgentCommand { get; }

        public MainViewModel(IMvxUserAgent userAgent)
        {
            _userAgent = userAgent;

            LoadUserAgentCommand = new MvxAsyncCommand(LoadUserAgentAsync);
        }

        private async Task LoadUserAgentAsync(CancellationToken cancellationToken)
        {
            UserAgent = await _userAgent.GetUserAgentAsync(cancellationToken).ConfigureAwait(false);

            await RaisePropertyChanged(() => UserAgent).ConfigureAwait(false);
        }
    }
}