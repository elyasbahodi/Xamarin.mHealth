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


        public User()
        {


        }
       

    }
}
