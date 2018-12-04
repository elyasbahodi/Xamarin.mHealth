using mHealth.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Services
{
    public class PageService
    {
        public APIConnection APIConnection { get; set; }

        public PageService()
        {
            APIConnection = new APIConnection();
        }
        public string Create(Page page)
        {
            Task<string> task = APIConnection.PostJsonToApi("api/Page?date={date}&description={description}", page);
            return task.Result;


        }

    }
}
