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



    }
}
