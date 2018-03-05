using Prism.Navigation;
using Prism.Commands;

namespace WelcomeCarousel.ViewModels
{
    public class _01_01_OnboardingPageViewModel : ViewModelBase
    {
        public DelegateCommand GetStartedCommand { get; set; }
        INavigationService _navigationService;

        public _01_01_OnboardingPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            GetStartedCommand = new DelegateCommand(onGetStartedClick);
            _navigationService = navigationService;
        }

        public async void onGetStartedClick()
        {
            await _navigationService.NavigateAsync("_01_02_OnboardingPage");
        }
    }
}
