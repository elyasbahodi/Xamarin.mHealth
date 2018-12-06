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
using mHealth.droid.Clients;
using MvvmCross.Droid.Views;

namespace mHealth.droid.Client
{
    [Activity(Label = "CreateClientActivity")]
    public class CreateClientActivity : MvxActivity
    {
        TextView _dateDisplay;
        Button _dateSelectButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CreateClient);
            _dateDisplay = FindViewById<TextView>(Resource.Id.date_display);
            _dateSelectButton = FindViewById<Button>(Resource.Id.date_select_button);
            _dateSelectButton.Click += DateSelect_OnClick;

        }

        void DateSelect_OnClick(object sender, EventArgs eventArgs)
        {
            CreateClientDatePickerFragment frag = CreateClientDatePickerFragment.NewInstance(delegate (DateTime time)
            {
                _dateDisplay.Text = time.ToLongDateString();
            });
            frag.Show(FragmentManager, CreateClientDatePickerFragment.TAG);
        }
    }
}