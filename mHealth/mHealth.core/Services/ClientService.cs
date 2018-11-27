using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mHealth.core.Models;
using Newtonsoft.Json;

namespace mHealth.core.Services
{
    public class ClientService
    {
        public APIConnection APIConnection { get; set; }
        public ClientService()
        {
            APIConnection = new APIConnection();
        }
        public Client GetClient(int id )
        {
            string url = "$api/Feedback/{"+id+"}";
            Task<string> json = APIConnection.GetJsonFromApi(url);
            Client client = (Client)JsonConvert.DeserializeObject(json.Result); 
            return client; 
        }

        public bool Create(Client client)
        {
            //Client client = new Client { Height = 124, Birthdate = DateTime.Now, Weight = 22, Gender = Gender.mand };
            Task<bool> task = APIConnection.PostJsonToApi("api/Feedback?height={height}&date={date}&weight={weight}&gender={gender}", client);

            return task.IsCompleted; 
            
            
                
                
                

        }
    }
}
