using mHealth.core.Models;
using mHealth.core.Services;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mHealth.core.ViewModels
{
    public class CreateAccountViewModel : MvxViewModel
    {
        public Account Account { get; set; }
        private AccountService AccountService { get; set; }
        IMvxNavigationService _navigationService;
        public MvxCommand MvxNavigateToCreateClientAsyncCommand { get; set; }
       

        public IMvxCommand CreateAccountCommand
        {
            get { return new MvxCommand(async()=> {
                await CreateAccount();
            }); }
           
        }




        private long _cpr;
        public long Cpr
        {
            get { return _cpr; }
            set { _cpr = value; RaisePropertyChanged(() => Cpr); }
        }

        public string isCreated { get; set; }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; RaisePropertyChanged(() => Password); }
        }

        public CreateAccountViewModel(IMvxNavigationService navigationService)
        {
            AccountService = new AccountService();
            _navigationService = navigationService;
            MvxNavigateToCreateClientAsyncCommand = new MvxCommand(() => ShowViewModel<CreateClientViewModel>(Account));
            Account = new Account();

        }

        public async Task<string> CreateAccount()
        {
            Account.Password = Password;
            Account.CPR = Cpr;

            MvxNavigateToCreateClientAsyncCommand.Execute();
            return await AccountService.Create(Account);
        }






    }
}
