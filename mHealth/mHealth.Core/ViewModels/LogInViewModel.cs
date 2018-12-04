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
    public class LogInViewModel : MvxViewModel
    {
        public Account Account { get; set; }
        private readonly IMvxNavigationService _navigationService;
        public string LblLogInWelcome { get; set; }
        public string LblCpr { get; set; }
        public string LblKodeord { get; set; }
        public string BtnLogin { get; set; }
        public string LblIngenProfil { get; set; }
        public string BtnOpretProfil { get; set; }

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


        public LogInViewModel()
        {
            StringResources stringResources = new StringResources();
            LblLogInWelcome = stringResources.Login().FirstOrDefault(x => x.Key == "@lblTopText").Value;
            LblCpr = stringResources.Login().FirstOrDefault(x => x.Key == "@lblCpr").Value;
            LblKodeord = stringResources.Login().FirstOrDefault(x => x.Key == "@lblKodeord").Value;
            BtnLogin = stringResources.Login().FirstOrDefault(x => x.Key == "@txtLogin").Value;
            LblIngenProfil = stringResources.Login().FirstOrDefault(x => x.Key == "@lblProfil").Value;
            BtnOpretProfil = stringResources.Login().FirstOrDefault(x => x.Key == "@txtOpretProfil").Value;
        }


    }
}
