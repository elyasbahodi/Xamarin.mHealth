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
using Acr.UserDialogs;
using MvvmCross.Platform.Droid.Platform;
using MvvmCross.Platform;

namespace mHealth.droid.Accounts
{
    [Activity(Label = "LogInActivity", MainLauncher = true)]
    public class LogInActivity : MvxActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LogIn);
            UserDialogs.Init(() => Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity);

            // Create your application here
        }


    }
}