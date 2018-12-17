using Java.Sql;
using mHealth.core.Business_Logic;
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
        APIConnection aPIConnection;
        Crypto Crypto;

        public PostJsonToApiTest()
        {
            dizzinessService = new DizzinessService();
            aPIConnection = new APIConnection();
            Crypto = new Crypto();
        }

        [TestMethod]
        public async Task PostDizzinessJsonToApiAsync()
        {
            //Dizziness dizziness = new Dizziness { Date = DateTime.Now, UserID = "444", Level = 3 }; 
            //HttpResponseMessage httpResponseMessage = await dizzinessService.Create(dizziness);

            //Assert.IsTrue(httpResponseMessage.StatusCode == System.Net.HttpStatusCode.Accepted);
            //Assert.IsTrue(await httpResponseMessage.Content.ReadAsStringAsync() == "Svimmelhed er gemt"); 

            
            User user = new User {  Birthdate = DateTime.Now, Gender = 1 , Height = 2, Weight = 3, Password = "d", Salt ="d", Username ="d"}; 
            string url = "api/User?username={username}&password={password}&salt={salt}&height={height}&birthdate={birthdate}&weight={weight}&gender={gender}";
            byte[] salt = Crypto.GenerateSalt();
            byte[] derivedKey = Crypto.DeriveKey(user.Password, salt);
            string hash = Crypto.HashPassword(derivedKey);
            user.Password = hash;
            user.Salt = Convert.ToBase64String(salt);
            HttpResponseMessage httpResponseMessage = await aPIConnection.PostJsonToApi(url, user);

            System.Net.HttpStatusCode hh =   httpResponseMessage.StatusCode; 
            
            Assert.IsTrue(httpResponseMessage.StatusCode == System.Net.HttpStatusCode.BadRequest);

        }
    }
}
