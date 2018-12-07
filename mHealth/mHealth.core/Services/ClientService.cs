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
        //public T Get<T>(int id, string url)
        //{
        //    return APIConnection.GetJsonFromApi(url, id);
        //}

        public async Task Create(Client client)
        {
            await APIConnection.PostJsonToApi("api/Client?cvr={cvr}&height={height}&birthdate={birthdate}&weight={weight}&gender={gender}", client);
            
            
        }


    }
}
