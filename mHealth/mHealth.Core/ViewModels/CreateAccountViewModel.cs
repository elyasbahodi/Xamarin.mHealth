using mHealth.core.Models;
using mHealth.core.Services;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mHealth.core.ViewModels
{
    public class CreateAccountViewModel : MvxViewModel
    {
        public Account Account { get; set; }
        private AccountService AccountService { get; set; }
        private IMvxNavigationService _navigationService { get; set; }
        public ICommand NavigateToCreateClient => new MvxAsyncCommand(GoToNavigateToCreateClient);



        private async Task GoToNavigateToCreateClient()
        {
            Account.CPR = Cpr;
            Account.Password = Password;

            await AccountService.Create(Account);
            await _navigationService.Navigate<CreateClientViewModel, Account>(Account);
        }

        private long _cpr;
        public long Cpr
        {
            get { return _cpr; }
            set { _cpr = value; RaisePropertyChanged(() => Cpr); }
        }

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
            Account = new Account();

        }
    }
}
