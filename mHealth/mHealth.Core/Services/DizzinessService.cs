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
        public bool Create(Dizziness dizziness)
        {
            Task<bool> task = APIConnection.PostJsonToApi("api/Dizziness/{id}?height={height}&date={date}&level={level}", dizziness);
            return task.IsCompleted;
        }
    }
}
