using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Models
{
    public class Dizziness
    {
        public int ID { get; set; }
        public int Level { get; set; }
        public DateTime Date { get; set; }

        public Dizziness()
        {

        }
    }
}
