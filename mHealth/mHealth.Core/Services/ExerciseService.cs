using mHealth.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Services
{
    public class ExerciseService
    {
        public APIConnection APIConnection { get; set; }

        public ExerciseService()
        {
            APIConnection = new APIConnection();
        }
        public async Task Create(Exercise exercise)
        {
            await APIConnection.PostJsonToApi("api/Exercise?title={title}&description={description}", exercise);


        }

    }
}
