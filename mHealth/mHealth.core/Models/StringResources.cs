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
                {"@Heading", "Login"},
                {"@lblTopText", "Her kan du logge ind" },
                {"@lblCpr", "Cpr : " },
                {"@lblKodeord" , "Kodeord : "},
                {"@txtLogin", "Login" },
                {"@lblProfil", "Har du ingen konto ?" },
                {"@txtOpretProfil", "Opret profil" }

            };
            return LoginStrings;
        }

        public Dictionary<string, string> OpretProfil12()
        {
            Dictionary<string, string> OpretProfil12Strings = new Dictionary<string, string>()
            {
                {"@Heading" , "Opret Profil"},
                {"@TopText", "Profil oprettelse 1/2" },
                {"@lblCpr", "Cpr : " },
                {"@lblKodeord" , "Kodeord : "},
                {"@btnVidere", "Videre" },
               

            };
            return OpretProfil12Strings;
        }

        public Dictionary<string, string> OpretProfil22()
        {
            Dictionary<string, string> OpretProfil22Strings = new Dictionary<string, string>()
            {
                {"@Heading" , "Opret Profil"},
                {"@lblTopText", "Profil oprettelse 2/2" },
                {"@lblKøn", "Køn : " },
                {"@lblFøs" , "Føs dato : "},
                {"@lblVægt", "Vægt : " },
                {"@lblHøjde", "Højde : " },
                {"@btnVidere", "Videre"}


            };
            return OpretProfil22Strings;
        }

        public Dictionary<string, string> SmartStep()
        {
            Dictionary<string, string> SmartStepStrings = new Dictionary<string, string>()
            {
                {"@Heading" , "Smart Step"},
                {"@lblTopText", "Dagens skridt til nu :" },
                {"@btnStatistik", "Statistik"}


            };
            return SmartStepStrings;
        }
        public Dictionary<string, string> RedigerLogin()
        {
            Dictionary<string, string> RedigerLoginStrings = new Dictionary<string, string>()
            {
                {"@Heading" , "Rediger Login"},
                {"@lblTopText", "Rediger dit login her" },
                {"@lblGamle", "Gamle : "},
                {"@lblNyt", "Nyt : "},
                {"@lblGodkend", "Godkend : "},
                {"@txtKodeord", "Kodeord"},
                {"@btnGem", "Gem ændringer"},
            };
            return RedigerLoginStrings;
        }

        public Dictionary<string, string> MinProfil()
        {
            Dictionary<string, string> MinProfilStrings = new Dictionary<string, string>()
            {
                {"@Heading" , "Min Profil"},
                {"@lblTopText", "Se din profil her"},
                 {"@lblKøn", "Køn : " },
                {"@lblFøs" , "Fødselsdato : "},
                {"@lblVægt", "Vægt : " },
                {"@lblHøjde", "Højde : " },
                 {"@lblKg", "kg" },
                  {"@lblCm", "cm" },
                {"@btnRedigerProfil", "Rediger Profil"},
                  {"@btnRedigerLogin", "Rediger Login"},
            };
            return MinProfilStrings;
        }

        public Dictionary<string, string> RedigerProfil()
        {
            Dictionary<string, string> RedigerProfilStrings = new Dictionary<string, string>()
            {
                {"@Heading" , "Rediger Profil"},
                {"@lblTopText", "Rediger din profil her"},
                 {"@lblKøn", "Køn : " },
                {"@lblFøs" , "Fødselsdato : "},
                {"@lblVægt", "Vægt : " },
                {"@lblHøjde", "Højde : " },
                 {"@lblKg", "kg" },
                  {"@lblCm", "cm" },
                {"@btnGem", "Gem ændringer"}
                
            };
            return RedigerProfilStrings;
        }

        public Dictionary<string, string> MålSvimmelhed()
        {
            Dictionary<string, string> MålSvimmelhedStrings = new Dictionary<string, string>()
            {
                {"@Heading" , "Mål din svimmelhed"},
                {"@lblTopText", "Hvor svimmel er du ? "},
                 {"@lblChoose", "Vælg mellem 1-10" },
                {"@btnIndsend", "Indsend"}

            };
            return MålSvimmelhedStrings;
        }
        public Dictionary<string, string> Statistik()
        {
            Dictionary<string, string> StatistikStrings = new Dictionary<string, string>()
            {
                {"@Heading" , "Statistik"},
                {"@lblTopText", "Vælg graf... "},
                 {"@btnUge", "Uge" },
                 {"@btnMåned", "Måned" },
                 {"@btn3Mnd", "3 Mnd" },
                 {"@btnÅr", "År" },
             

            };
            return StatistikStrings;
        }
        public Dictionary<string, string> MineØverlser()
        {
            Dictionary<string, string> MineØvelserStrings = new Dictionary<string, string>()
            {
                {"@Heading" , "Mine Øvelser"},
                {"@lblTopText", "Vælg en øvelse "},
                


            };
            return MineØvelserStrings;
        }
        public Dictionary<string, string> Øverlse()
        {
            Dictionary<string, string> MineØvelserStrings = new Dictionary<string, string>()
            {
                {"@Heading" , "Øvelse"},
            };
            return MineØvelserStrings;
        }

        public Dictionary<string, string> MinDagbog()
        {
            Dictionary<string, string> MinDagbogStrings = new Dictionary<string, string>()
            {
                {"@Heading" , "Min Dagbog"},
              
                 {"@btnUge", "Uge" },
                 {"@btnMåned", "Måned" },
                 {"@btn3Mnd", "3 Mnd" },
                 {"@btnÅr", "År" },
                  {"@btnBedste", "Bedste" },
                 {"@btnDårligste", "Dårligste" },
                
            };
            return MinDagbogStrings;
        }

        public Dictionary<string, string> OpretDag()
        {
            Dictionary<string, string> OpretDagStrings = new Dictionary<string, string>()
            {
                {"@Heading" , "Opret Dag"},
                {"@lblTopText" , "Beskrivelse"},
                {"@txtSkriv", "Skriv om din dag" },
                {"@btnGem", "Gem" } 

            };
            return OpretDagStrings;
        }
        public Dictionary<string, string> MinDag()
        {
            Dictionary<string, string> MinDagStrings = new Dictionary<string, string>()
            {
                {"@Heading" , "Min Dag"},
                {"@lblTopText" , "Beskrivelse af dag"},
                 {"@btnGem", "Gem" }

            };
            return MinDagStrings;
        }



    }
}
