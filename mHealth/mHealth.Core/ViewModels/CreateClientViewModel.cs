using mHealth.core.Models;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.ViewModels
{
    public class CreateClientViewModel : MvxViewModel
    {
        public Account Account { get; set; }
        public IMvxNavigationService _navigationService { get; set; }
        public IMvxAsyncCommand MvxAsyncCommand { get; set; }


        public CreateClientViewModel(IMvxNavigationService navigationService, Account account)
        {
            Account = account;
            _navigationService = navigationService;
            MvxAsyncCommand = new MvxAsyncCommand(() => _navigationService.Navigate<LogInViewModel>());

        }
    }
}
