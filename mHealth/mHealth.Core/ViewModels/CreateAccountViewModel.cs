using mHealth.core.Models;
using mHealth.core.Services;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.ViewModels
{
    class CreateAccountViewModel : MvxViewModel
    {
        Account account;
        private AccountService AccountService { get; set; }
        IMvxNavigationService _navigationService;
        public IMvxAsyncCommand MvxAsyncCommand { get; set; }
        private string _cpr;
        public string Cpr
        {
            get { return _cpr; }
            set { _cpr = value; RaisePropertyChanged(() => account.CPR); }
        }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; RaisePropertyChanged(() => account.Password); }
        }

        public CreateAccountViewModel(IMvxNavigationService navigationService)
        {
            AccountService = new AccountService();
            _navigationService = navigationService;
            MvxAsyncCommand = new MvxAsyncCommand(() => _navigationService.Navigate<CreateClientViewModel>());

        }

        //public MvxCommand CreateAccountCommand()
        //{
        //    AccountService.Create(account);

        //}
        public IMvxCommand CreateAccount()
        {
            bool isCreated = AccountService.Create(account);

            if (isCreated)
            {
                AccountService.Get();

            }

            return MvxAsyncCommand;
        }





    }
}
