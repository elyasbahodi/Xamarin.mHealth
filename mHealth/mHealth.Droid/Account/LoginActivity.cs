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
using MvvmCross.Droid.Views;

namespace mHealth.droid.Account
{
    [Activity(Label = "LoginActivity", Theme = "@style/AppTheme", MainLauncher = true)]
    public class LoginActivity : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LoginLayout);

            // Create your application here
        }

        public bool LogIn()
        {


            return true;
        }

    }
}