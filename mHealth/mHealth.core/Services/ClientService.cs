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
        public async Task<Object> Get(long id, Client obj)
        {
            Client client = await (Task<Client>)APIConnection.GetJsonFromApiAsync("api/Client/{id}", id, obj).Result;
            return client;
        }

        public async Task Create(Client client)
        {
            await APIConnection.PostJsonToApi("api/Client?height={height}&date={date}&weight={weight}&gender={gender}", client);
            
            
        }


    }
}
