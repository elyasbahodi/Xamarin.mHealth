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
        public APIConnection APIConnection { get; set; }

        public AccountService()
        {
            APIConnection = new APIConnection();
        }
        public bool Create(Account account)
        {
            Task<bool> task = APIConnection.PostJsonToApi("api/Account?cpr={cpr}&password={password}&salt={salt}", account);
            return task.IsCompleted;


        }
    }
}
