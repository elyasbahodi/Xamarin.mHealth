using mHealth.core.Business_Logic;
using mHealth.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Services
{
    public class AccountService
    {
        Crypto crypto; 

        public APIConnection APIConnection { get; set; }

        public AccountService()
        {
            APIConnection = new APIConnection();
            crypto = new Crypto();
        }
        public Account Get(int id)
        {
            Account account = null;
            return (Account)APIConnection.GetJsonFromApiAsync("api/Account/{id}", id, account);
        }

        public Account Create(Account account)
        {
            if (account.CPR.Equals(Get(account.ID).CPR))
            {
                return false;
            }
            else
            {

            byte[] salt = crypto.GenerateSalt();
            byte[] derivedKey = crypto.DeriveKey(account.Password, salt);
            string hash = crypto.HashPassword(derivedKey);
            account.Password = hash;
            account.Salt = Convert.ToBase64String(salt);
            Task<bool> task = APIConnection.PostJsonToApi("api/Account?cpr={cpr}&password={password}&salt={salt}", account);
            return task.IsCompleted;
            }

            


        }
    }
}
