using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Models
{
    public class StringResources
    {
        
       
    
        public Dictionary<string, string> Login()
        {
            Dictionary<string, string> LoginStrings = new Dictionary<string, string>()
            {
                {"@Heading", "Her kan du logge ind" },
                {"@lblCpr", "Cpr : " },
                {"@lblKodeord" , "Kodeord : "},
                {"@txtLogin", "Login" },
                {"@lblProfil", "Har du ingen konto ?" },
                {"@txtOpretProfil", "Opret profil" }

            };
            return LoginStrings; 
        }
     








    }
}
