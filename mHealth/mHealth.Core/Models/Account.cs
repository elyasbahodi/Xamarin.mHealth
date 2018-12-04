using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Models
{
    public class Account
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }
        [JsonProperty(PropertyName = "cpr")]
        public string CPR { get; set; }
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        [JsonProperty(PropertyName = "salt")]
        public string Salt { get; set; }

        [JsonProperty(PropertyName = "Client")]
        public Client Client{ get; set; }

    }
}
