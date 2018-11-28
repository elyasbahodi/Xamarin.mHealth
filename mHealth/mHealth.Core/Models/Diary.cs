using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Models
{
    public class Diary
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public List<Page> Pages { get; set; }

        public Diary()
        {
            Pages = new List<Page>();
        }
    }
}
