using System;
using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Webkit;

namespace SByte.MvvmCross.Plugins.UserAgent.Android
{
    [Preserve(AllMembers = true)]
    internal sealed class MvxUserAgent : IMvxUserAgent
    {
        private string _userAgent;

        public Task<string> GetUserAgentAsync(CancellationToken cancellationToken)
        {
            if (!string.IsNullOrWhiteSpace(_userAgent))
            {
                return Task.FromResult(_userAgent);
            }

            var taskCompletionSource = new TaskCompletionSource<string>();

            new Handler(Looper.MainLooper).Post(() =>
            {
                try
                {
                    using (var webView = new WebView(Application.Context))
                    {
                        _userAgent = webView.Settings.UserAgentString;

                        taskCompletionSource.TrySetResult(_userAgent);
                    }
                }
                catch (Exception exception)
                {
                    taskCompletionSource.TrySetException(exception);
                }
            });

            return taskCompletionSource.Task;
        }
    }
}