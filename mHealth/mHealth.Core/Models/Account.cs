using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Models
{
    public class Account
    {
        public int ID { get; set; }
        public string CPR { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }

        public Account()
        {


        }

    }
}
