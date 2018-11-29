using mHealth.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Services
{
    public class DiaryService
    {
        public APIConnection APIConnection { get; set; }

        public DiaryService()
        {
            APIConnection = new APIConnection();
        }
        public bool Create(Diary diary)
        {
            Task<bool> task = APIConnection.PostJsonToApi("api/Diary?date={date}&title={title}", diary);
            return task.IsCompleted;


        }
    }
}
