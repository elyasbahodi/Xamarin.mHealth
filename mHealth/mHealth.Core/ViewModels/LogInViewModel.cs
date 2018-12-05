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
    public class LogInViewModel : MvxViewModel
    {
        public Account Account { get; set; }
        private readonly IMvxNavigationService _navigationService;
        public IMvxCommand MvxCreateAccountCommand { get; set; }
        public AccountService AccountService { get; set; }





        private string _txtPassword;
        public string TxtPassword
        {
            get { return _txtPassword; }
            set { _txtPassword = value; RaisePropertyChanged(() => Account.Password); }
        }
        private string _txtCpr;
        public string TxtCpr
        {
            get { return _txtCpr; }
            set { _txtCpr = value; RaisePropertyChanged(() => Account.CPR); }
        }


        public LogInViewModel(IMvxNavigationService navigationService)
        {
            AccountService = new AccountService();
            _navigationService = navigationService;
            MvxCreateAccountCommand = new MvxCommand(() => ShowViewModel<CreateAccountViewModel>());
        }
        
        



    }
}
