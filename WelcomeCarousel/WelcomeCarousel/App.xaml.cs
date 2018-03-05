using Prism;
using Prism.Ioc;
using WelcomeCarousel.ViewModels;
using WelcomeCarousel.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace WelcomeCarousel
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("_01_01_OnboardingPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<_01_01_OnboardingPage>();
            containerRegistry.RegisterForNavigation<_01_02_OnboardingPage>();
            containerRegistry.RegisterForNavigation<_01_03_OnboardingPage>();
            containerRegistry.RegisterForNavigation<_01_04_OnboardingPage>();
        }
    }
}
