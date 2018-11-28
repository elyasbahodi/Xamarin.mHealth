using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Models
{
    public class Page
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public List<Exercise> Exercises { get; set; }
        public Page()
        {
            Exercises = new List<Exercise>();

        }
    }
}
