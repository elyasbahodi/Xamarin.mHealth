using mHealth.core.Models;
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
        public string LblLogInWelcome { get; set; }
        public string LblCpr { get; set; }
        public string LblKodeord { get; set; }
        public string BtnLogin { get; set; }
        public string LblIngenProfil { get; set; }
        public string BtnOpretProfil { get; set; }

        public string TxtCpr { get; set; }
        public string TxtPassword { get; set; }

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
