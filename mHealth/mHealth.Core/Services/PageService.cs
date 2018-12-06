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
        public async Task Create(Page page)
        {
            await APIConnection.PostJsonToApi("api/Page?date={date}&description={description}", page);
        }

    }
}
