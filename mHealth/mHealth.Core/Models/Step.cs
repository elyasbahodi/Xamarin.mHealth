using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Models
{
    public class Step
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }

        public Step()
        {

        }
    }
}
