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
        public Account Account { get; set; }
        private AccountService AccountService { get; set; }
        IMvxNavigationService _navigationService;
        public IMvxCommand MvxNavigateToCreateClientAsyncCommand { get; set; }
        private string _cpr;
        public string Cpr
        {
            get { return _cpr; }
            set { _cpr = value; RaisePropertyChanged(() => Account.CPR); }
        }

        public string isCreated { get; set; }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; RaisePropertyChanged(() => Account.Password); }
        }

        public CreateAccountViewModel(IMvxNavigationService navigationService)
        {
            AccountService = new AccountService();
            _navigationService = navigationService;
            MvxNavigateToCreateClientAsyncCommand = new MvxCommand(() => ShowViewModel<CreateClientViewModel>(Account));

        }

        //public MvxCommand CreateAccountCommand()
        //{
        //    AccountService.Create(account);

        //}
        public IMvxCommand CreateAccount()
        {
            isCreated = AccountService.Create(Account);


            return MvxNavigateToCreateClientAsyncCommand;
        }





    }
}
