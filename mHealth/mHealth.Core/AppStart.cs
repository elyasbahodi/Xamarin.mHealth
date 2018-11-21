using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.Core
{
    class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {

            //Eventually check for login Credentials here. 
            //Show the first screen here...!
            throw new NotImplementedException();
        }
    }
}
