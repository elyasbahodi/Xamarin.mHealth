using mHealth.core.Models;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.ViewModels
{
    public class MainMenuViewModel : MvxViewModel<User>
    {
        private User user;



        public MainMenuViewModel()
        {

        }

        public override void Prepare(User parameter)
        {
            throw new NotImplementedException();
        }
    }
}
