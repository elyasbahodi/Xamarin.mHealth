using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mHealth.core.Models
{
    public class User
    {
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        [JsonProperty(PropertyName = "salt")]
        public string Salt { get; set; }
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }
        [JsonProperty(PropertyName = "birthdate")]
        public DateTime Birthdate { get; set; }
        [JsonProperty(PropertyName = "weight")]
        public int Weight{ get; set; }
        [JsonProperty(PropertyName = "gender")]
        public int Gender { get; set; }

        [JsonProperty(PropertyName = "Steps")]
        public List<Step> Steps { get; set; }
        [JsonProperty(PropertyName = "Dizzinesses")]
        public List<Dizziness> Dizzinesses { get; set; }
        [JsonProperty(PropertyName = "Exercises")]
        public List<Exercise> Exercises { get; set; }
        [JsonProperty(PropertyName = "Diary")]
        public Diary Diary { get; set; }
        public User()
        {
            Steps = new List<Step>();
            Dizzinesses = new List<Dizziness>();
            Exercises = new List<Exercise>();
            Diary = new Diary();

        }
       



    }
}
