using mHealth.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Services
{
    public class StepService
    {
        public APIConnection APIConnection { get; set; }

        public StepService()
        {
            APIConnection = new APIConnection();
        }
        public bool Create(Step step)
        {
            Task<bool> task = APIConnection.PostJsonToApi("api/Step/{id}?date={date}&count={count}", step);
            return task.IsCompleted;
        }
    }
}
