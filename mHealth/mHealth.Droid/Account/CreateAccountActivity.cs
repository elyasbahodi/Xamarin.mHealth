using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using mHealth.core.Models;
using mHealth.core.Services;

namespace mHealth.droid
{
    [Activity(Label = "CreateAccountActivity", Theme = "@style/AppTheme", MainLauncher = true)]
    public class CreateAccountActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            AccountService accountService = new AccountService();
            Account account = new Account {CPR = "1234567890", Password = "123456789", Salt = "1234567870"};
            accountService.Create(account);
        }
    }
}