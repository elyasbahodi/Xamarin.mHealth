using Acr.UserDialogs;
using mHealth.core.Models;
using mHealth.core.Services;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mHealth.core.ViewModels
{
    public class LogInViewModel : MvxViewModel
    {
        private User user;
        private readonly IMvxNavigationService _navigationService;
        public IMvxCommand MvxCreateAccountCommand { get; set; }
        public ICommand NavigateToMainMenuCommand => new MvxAsyncCommand(Navigate);
        public UserService UserService { get; set; }


        private string _txtPassword;
        public string TxtPassword
        {
            get { return _txtPassword; }
            set { _txtPassword = value; RaisePropertyChanged(() => TxtPassword); }
        }
        private string _txtCpr;
        public string TxtCpr
        {
            get { return _txtCpr; }
            set { _txtCpr = value; RaisePropertyChanged(() => TxtCpr); }
        }


        public LogInViewModel(IMvxNavigationService navigationService)
        {
            UserService = new UserService();
            _navigationService = navigationService;
            MvxCreateAccountCommand = new MvxCommand(() => ShowViewModel<CreateUserOneViewModel>());
            user = new User();
        }
        
        private async Task Navigate()
        {
            user = await UserService.Get(TxtCpr, TxtPassword, user);
            if (!user.Equals(null))
            {
                await _navigationService.Navigate<MainMenuViewModel, User>(user);
            }
            else
            {
               Mvx.Resolve<IUserDialogs>().Alert("Dine brugeroplyninger er ikke korrekte, prøv igen..");
            }
        }
        



    }
}
