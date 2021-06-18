using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace SByteDev.MvvmCross.Plugins.UserAgent.Demo.iOS
{
    [MvxRootPresentation]
    public class MainViewController : MvxViewController<MainViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var button = UIButton.FromType(UIButtonType.System);
            button.TranslatesAutoresizingMaskIntoConstraints = false;
            button.SetTitle("Load UserAgent", UIControlState.Normal);

            var label = new UILabel
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                Lines = 0,
                LineBreakMode = UILineBreakMode.WordWrap
            };

            View.BackgroundColor = UIColor.White;
            View.AddSubviews(button, label);
            View.AddConstraints(new[]
            {
                button.LeadingAnchor.ConstraintEqualTo(View.SafeAreaLayoutGuide.LeadingAnchor),
                button.TrailingAnchor.ConstraintEqualTo(View.SafeAreaLayoutGuide.TrailingAnchor),
                button.TopAnchor.ConstraintEqualTo(View.SafeAreaLayoutGuide.TopAnchor),
                label.TopAnchor.ConstraintEqualTo(button.BottomAnchor),
                label.LeadingAnchor.ConstraintEqualTo(View.SafeAreaLayoutGuide.LeadingAnchor),
                label.TrailingAnchor.ConstraintEqualTo(View.SafeAreaLayoutGuide.TrailingAnchor),
                label.BottomAnchor.ConstraintEqualTo(View.SafeAreaLayoutGuide.BottomAnchor)
            });

            var set = this.CreateBindingSet<MainViewController, MainViewModel>();
            set.Bind(button).To(vm => vm.LoadUserAgentCommand);
            set.Bind(label).To(vm => vm.UserAgent);
            set.Apply();
        }
    }
}