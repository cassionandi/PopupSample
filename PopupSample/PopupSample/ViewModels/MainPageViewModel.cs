using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PopupSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }

		public async override void OnNavigatingTo(NavigationParameters parameters)
		{

            await NavigationService.NavigateAsync("ExamplePopupPage");

		}
	}
}
