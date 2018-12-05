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
        public string Create(Dizziness dizziness)
        {
            Task<string> task = APIConnection.PostJsonToApi("api/Dizziness/{id}?height={height}&date={date}&level={level}", dizziness);
            return task.Result;
        }
    }
}
