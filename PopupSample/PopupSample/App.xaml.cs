using Prism;
using Prism.Ioc;
using PopupSample.ViewModels;
using PopupSample.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.DryIoc;
using Prism.Plugin.Popups;
using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Services;
using DryIoc;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PopupSample
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

            //OK Android Not iOS
            //NavigationService.NavigateAsync("NavigationPage/MainPage"); 

            //OK Android Not iOS
            NavigationService.NavigateAsync("MainPage");

        }

        protected override void RegisterTypes(Prism.Ioc.IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();

            containerRegistry.RegisterForNavigation<ExamplePopupPage>();

            containerRegistry.RegisterPopupNavigationService();

        }
    }
}
