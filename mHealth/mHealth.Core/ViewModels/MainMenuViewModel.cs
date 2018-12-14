﻿using mHealth.core.Models;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mHealth.core.ViewModels
{
    public class MainMenuViewModel : MvxViewModel<User>
    {
        private User user;
        public ICommand DizzinessCommand => new MvxCommand(NavigateToDizziness);
        public MainMenuViewModel()
        {

        }

        public void NavigateToDizziness()
        {
            ShowViewModel<CreateDizzinessViewModel>(user);
        }



        public override void Prepare(User parameter)
        {
            user = parameter;
        }
    }
}
