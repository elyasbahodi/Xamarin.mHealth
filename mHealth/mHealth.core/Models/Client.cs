using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mHealth.core.Models
{
    public class Client
    {
        public int ID { get; set;  }
        public int Height { get; set; }
        public DateTime Birthdate { get; set; }
        public int Weight{ get; set; }
        public int Gender { get; set; }
        public Diary Diary { get; set; }
        public Account Account { get; set; }
        public List<Exercise> Exercises { get; set; }
        public List<Dizziness> Dizziness { get; set; }
        public List<Step> Steps { get; set; }
        public Client()
        {
            Exercises = new List<Exercise>();
            Dizziness = new List<Dizziness>();
            Steps = new List<Step>();

        }
       

    }
}
