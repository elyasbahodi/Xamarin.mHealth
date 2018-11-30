using Android.App;
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
    [Activity(Label = "@string/app_name")]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //ClientService clientService = new ClientService();
            //Client client = new Client { Height = 133, Date = DateTime.Now,  Gender = GenderConverter.Convert((Gender.kvinde)), Weight = 200 };
            //clientService.Create(client);

            ClientService clientService = new ClientService();
            string url = "api/Client/{id}";
            object cli = clientService.Get(11, url);
            Toast.MakeText(this,"nna" , ToastLength.Long);
         

            
        } 
    }
}