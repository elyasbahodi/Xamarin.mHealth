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
        APIConnection apiConnection;
   

        public PostJsonToApiTest()
        {
            apiConnection = new APIConnection();
        }

        [TestMethod]
        public void PostJsonToApi()
        {
            Step step = new Step();
           Task<HttpResponseMessage> httpResponseMessage = apiConnection.PostJsonToApi("api/Step/{id}?date={date}&count={count}",step );

        }
    }
}
