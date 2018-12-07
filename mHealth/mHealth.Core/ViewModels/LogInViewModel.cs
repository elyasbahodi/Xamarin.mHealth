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
        private Account Account;
        private readonly IMvxNavigationService _navigationService;
        public IMvxCommand MvxCreateAccountCommand { get; set; }
        public ICommand NavigateToMainMenuCommand => new MvxAsyncCommand(Navigate);
        public AccountService AccountService { get; set; }


        private string _txtPassword;
        public string TxtPassword
        {
            get { return _txtPassword; }
            set { _txtPassword = value; RaisePropertyChanged(() => TxtPassword); }
        }
        private long _txtCpr;
        public long TxtCpr
        {
            get { return _txtCpr; }
            set { _txtCpr = value; RaisePropertyChanged(() => TxtCpr); }
        }


        public LogInViewModel(IMvxNavigationService navigationService)
        {
            AccountService = new AccountService();
            _navigationService = navigationService;
            MvxCreateAccountCommand = new MvxCommand(() => ShowViewModel<CreateAccountViewModel>());
        }
        
        private async Task Navigate()
        {
            Account = await AccountService.Get(TxtCpr, TxtPassword);
            if (!Account.Equals(null))
            {
                await _navigationService.Navigate<MainMenuViewModel, Account>(Account);
            }
            else
            {
               Mvx.Resolve<IUserDialogs>().Alert("Dine brugeroplyninger er ikke korrekte, prøv igen..");
            }
        }
        



    }
}
