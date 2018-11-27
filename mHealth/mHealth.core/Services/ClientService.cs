using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mHealth.core.Models;
using Newtonsoft.Json;

namespace mHealth.core.Services
{
    public class ClientService
    {
        APIConnection _APIConnection; 
        public ClientService()
        {
            
        }
        public Client GetClient(int id )
        {
            string url = "$api/Feedback/{"+id+"}";
            Task<string> json = _APIConnection.GetJsonFromApi(url);
            Client client = (Client)JsonConvert.DeserializeObject(json.Result); 
            return client; 
        }

        public bool Create()
        {
            Client client = new Client { Height = 122, Birthdate = DateTime.Now, Weight = 22, Gender = Gender.mand };
            string json = JsonConvert.SerializeObject(client);
            Task task = _APIConnection.PostJsonToApi("api/Feedback?height=122&date="+ DateTime.Now+ "&weight=22&gender=1", json);
            return task.IsCompleted; 
            
            
                
                
                

        }
    }
}
