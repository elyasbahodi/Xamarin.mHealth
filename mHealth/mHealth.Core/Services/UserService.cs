using mHealth.core.Business_Logic;
using mHealth.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Services
{
    public class UserService
    {
        private APIConnection APIConnection { get; set; }
        private Crypto Crypto;
        private User emptyUser;

        public UserService()
        {
            emptyUser = new User();
            APIConnection = new APIConnection();
            Crypto = new Crypto();
        }

        public async Task<User> Get(string username, string password, User user)
        {
            byte[] salt = Convert.FromBase64String(user.Salt);
            byte[] derivedKey = Crypto.DeriveKey(user.Password, salt);
            string hash = Crypto.HashPassword(derivedKey);

            User emptyUser = await (Task<User>)APIConnection.GetJsonFromApiAsync("api/User?username={username}", username, user).Result;
            return user;
        }

        public async Task Create(User user)
        {
            string url = "api/User?username={username}&password={password}&salt={salt}&height={height}&birthdate={birthdate}&weight={weight}&gender={gender}";
            byte[] salt = Crypto.GenerateSalt();
            byte[] derivedKey = Crypto.DeriveKey(user.Password, salt);
            string hash = Crypto.HashPassword(derivedKey);
            user.Password = hash;
            user.Salt = Convert.ToBase64String(salt);
            await APIConnection.PostJsonToApi(url, user);
        }
    }


}
