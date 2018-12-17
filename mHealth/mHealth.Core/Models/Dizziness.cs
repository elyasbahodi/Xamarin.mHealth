using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Models
{
    public class Dizziness
    {
        [JsonIgnore]
        public int ID { get; set; }
        [JsonProperty(PropertyName = "userid")]
        public string UserId { get; set; }
        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }
        [JsonProperty(PropertyName = "level")]
        public int Level { get; set; }

        public Dizziness()
        {

        }
    }
}
