using mHealth.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task Create(Dizziness dizziness)
        {
            await APIConnection.PostJsonToApi("api/Dizziness/{id}?height={height}&date={date}&level={level}", dizziness);
            
        }
    }
}
