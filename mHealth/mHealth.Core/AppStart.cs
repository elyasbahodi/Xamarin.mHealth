using mHealth.core.ViewModels;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core
{
    class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<LogInViewModel>();
        }
    }
}
