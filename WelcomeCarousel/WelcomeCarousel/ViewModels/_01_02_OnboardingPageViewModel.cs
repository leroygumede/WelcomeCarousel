using System.Collections.ObjectModel;
using Prism.Navigation;
using WelcomeCarousel.Models;
using Prism.Commands;

namespace WelcomeCarousel.ViewModels
{
    public class _01_02_OnboardingPageViewModel : ViewModelBase
    {

        private ObservableCollection<Carousel> _carouselItemSource;
        public ObservableCollection<Carousel> CarouselItemSource
        {
            get { return _carouselItemSource; }
            set { SetProperty(ref _carouselItemSource, value); }
        }

        public DelegateCommand GetStartedCommand { get; set; }
        INavigationService _navigationService;

        public _01_02_OnboardingPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            GetStartedCommand = new DelegateCommand(onGetStartedClick);
            _navigationService = navigationService;

            GetCarouselList();
        }

        public void GetCarouselList()
        {
            CarouselItemSource = new ObservableCollection<Carousel>(Carousel.All);
        }

        public async void onGetStartedClick()
        {
            await _navigationService.NavigateAsync("_01_03_OnboardingPage");
        }
    }
}