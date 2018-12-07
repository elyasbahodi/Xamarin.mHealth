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
        public async Task<Account> Get(long cpr, string password)
        {
            Account emptyAccount = null;
            Account account = await (Task<Account>)APIConnection.GetJsonFromApiAsync("api/Account/{cpr}", cpr, emptyAccount).Result;

            byte[] salt = Convert.FromBase64String(account.Salt);
            byte[] derivedKey = crypto.DeriveKey(account.Password, salt);
            string hash = crypto.HashPassword(derivedKey);

            if (account.Password.Equals(hash))
            {
                return account;

            }
            else
            {
                return emptyAccount;
            }

        }

        public async Task Create(Account account)
        {
            byte[] salt = crypto.GenerateSalt();
            byte[] derivedKey = crypto.DeriveKey(account.Password, salt);
            string hash = crypto.HashPassword(derivedKey);
            account.Password = hash;
            account.Salt = Convert.ToBase64String(salt);
            await APIConnection.PostJsonToApi("api/Account?cpr={cpr}&password={password}&salt={salt}", account);
          
        }
    }
}
