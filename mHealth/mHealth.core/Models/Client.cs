using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mHealth.core.Models
{
    public class Client
    {
        [JsonProperty(PropertyName = "ID")]
        public long ID { get; set;  }
        [JsonProperty(PropertyName = "height")]
        public int height { get; set; }
        [JsonProperty(PropertyName = "date")]
        public DateTime birthdate { get; set; }
        [JsonProperty(PropertyName = "weight")]
        public int weight{ get; set; }
        [JsonProperty(PropertyName = "gender")]
        public int gender { get; set; }
        [JsonProperty(PropertyName = "Diary")]
        public Diary Diary { get; set; }
       
        [JsonProperty(PropertyName = "Exercise")]
        public List<Exercise> Exercises { get; set; }
        [JsonProperty(PropertyName = "Dizzinesses")]
        public List<Dizziness> Dizzinesses { get; set; }
        [JsonProperty(PropertyName = "Steps")]
        public List<Step> Steps { get; set; }

        public Client()
        {
            Exercises = new List<Exercise>();
            Dizzinesses = new List<Dizziness>();
            Steps = new List<Step>();

        }
       

    }
}
