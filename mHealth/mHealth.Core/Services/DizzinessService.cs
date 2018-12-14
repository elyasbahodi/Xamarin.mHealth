using mHealth.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Services
{
    public class DizzinessService
    {
        public APIConnection APIConnection { get; set; }

        public DizzinessService()
        {
            APIConnection = new APIConnection();
        }
        public async Task<HttpResponseMessage> Create(Dizziness dizziness)
        {
           return await APIConnection.PostJsonToApi("api/Dizziness?userId={userId}&date={date}&level={level}", dizziness);
            
        }


    }
}
