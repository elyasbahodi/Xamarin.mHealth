﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Microsoft.WindowsAzure.MobileServices;
using mHealth.core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using mHealth.core.Models;
using System;

namespace mHealth.droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            ClientService clientService = new ClientService();
            clientService.Create();
         

            
        } 
    }
}