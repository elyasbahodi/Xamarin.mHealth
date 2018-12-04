using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mHealth.core.Models;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using mHealth.core.Services;
using MvvmCross.Droid.Views;

namespace mHealth.droid.Accounts
{
    [Activity(Label = "LogInActivity", MainLauncher = true)]
    public class LogInActivity : MvxActivity
    {

        Button LoginBtn;
        Button SignUpBtn;
        AccountService accountService = new AccountService();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LogIn);

            LoginBtn = FindViewById<Button>(Resource.Id.BtnLogIn);
            SignUpBtn = FindViewById<Button>(Resource.Id.BtnSignUp);

            // Create your application here
        }
        //private void FindAccount()
        //{

        //    string url = "api/Account/{id}";
        //    var acc = accountService.Get(1, url, account);

        //    Toast.MakeText(this, "x", ToastLength.Long);

        //}



    }
}