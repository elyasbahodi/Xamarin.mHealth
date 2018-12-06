﻿using mHealth.core.Models;
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
        public async Task Create(Diary diary)
        {
            await APIConnection.PostJsonToApi("api/Diary?date={date}&title={title}", diary);
           


        }
    }
}
