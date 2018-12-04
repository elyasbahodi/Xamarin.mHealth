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

namespace mHealth.droid.Accounts
{
    [Activity(Label = "CreateAccountActivity")]
    public class CreateAccountActivity : MvxActivity
    {
        Button BtnContinue;
        AccountService accountService = new AccountService();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CreateAccount);
            BtnContinue = FindViewById<Button>(Resource.Id.BtnContinue);   
            
        }
    }
}