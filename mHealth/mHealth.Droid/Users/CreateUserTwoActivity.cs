using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mHealth.core.ViewModels;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;

namespace mHealth.droid.Users
{
    [Activity(Label = "CreateUserTwoActivity")]
    public class CreateUserTwoActivity : MvxActivity
    {
        TextView _dateDisplay;
        Button _dateSelectButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CreateUserTwo);

            _dateDisplay = FindViewById<TextView>(Resource.Id.date_display);
            _dateSelectButton = FindViewById<Button>(Resource.Id.date_select_button);
            _dateSelectButton.Click += DateSelect_OnClick;
        }

        void DateSelect_OnClick(object sender, EventArgs eventArgs)
        {
            CreateUserDatePickerFragment frag = CreateUserDatePickerFragment.NewInstance(delegate (DateTime time)
            {
                _dateDisplay.Text = time.ToLongDateString();
            });
            frag.Show(FragmentManager, CreateUserDatePickerFragment.TAG);
        }


    }
}