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
        public async Task Create(Step step)
        {
            await APIConnection.PostJsonToApi("api/Step/{id}?date={date}&count={count}", step);
        }
    }
}
