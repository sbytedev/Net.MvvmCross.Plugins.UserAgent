using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Views;

namespace SByteDev.MvvmCross.Plugins.UserAgent.Demo.Android
{
    [Activity(Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : MvxActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var button = new Button(this) {Text = "Load UserAgent"};
            var textView = new TextView(this);
            var linearLayout = new LinearLayout(this)
            {
                Orientation = Orientation.Vertical
            };

            linearLayout.AddView(button);
            linearLayout.AddView(textView);

            SetContentView(linearLayout);

            var set = this.CreateBindingSet<MainActivity, MainViewModel>();
            set.Bind(button).To(vm => vm.LoadUserAgentCommand);
            set.Bind(textView).To(vm => vm.UserAgent);
            set.Apply();
        }
    }
}