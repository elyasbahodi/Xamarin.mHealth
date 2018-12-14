using mHealth.core.Models;
using mHealth.core.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestClass]
    public class PostJsonToApiTest
    {
        DizzinessService dizzinessService;
   

        public PostJsonToApiTest()
        {
            dizzinessService = new DizzinessService();
        }

        [TestMethod]
        public void PostDizzinessJsonToApi()
        {
            Dizziness dizziness = new Dizziness();
            Task<HttpResponseMessage> httpResponseMessage = await dizzinessService.Create("api/Dizziness?userId={userId}&date={date}&level={level}" ,dizziness );

        }
    }
}
