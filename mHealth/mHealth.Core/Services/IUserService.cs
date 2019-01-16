using mHealth.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Services
{
   public interface IUserService
    {
        User Get(string username, string password, User user);
        Task<HttpResponseMessage> Create(User user);
    }
}
