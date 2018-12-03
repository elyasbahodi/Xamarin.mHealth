using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using mHealth.core.Models;
using mHealth.core.Services;
using mHealth.core.ViewModels;
using MvvmCross.Core.Navigation;
using MvvmCross.Droid.Views;
using MvvmCross.Platform;

namespace mHealth.droid
{
    [Activity(Label = "CreateAccountActivity")]
    public class CreateAccountActivity : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LogIn);

        }

        public void CreateAccount()
        {

            AccountService accountService = Mvx.Resolve<AccountService>();
            Account account = new Account { CPR = "1234567890", Password = "123456789", Salt = "1234567870" };
            accountService.Create(account);

        }

        private async Task Navigate()
        {
            MvxNavigationService navigationService;
           // await navigationService.Navigate<LogInViewModel>();
        }

    }
}