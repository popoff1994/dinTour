using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class Deltager
    {
        public int DeltagerNr { get; set; }
        public string Name { get; set; }
        public string Tlf { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public Deltager(int deltagerNr, string name, string tlf, string email, string userName, string password)
        {
            DeltagerNr = deltagerNr;
            Name = name;
            Tlf = tlf;
            Email = email;
            UserName = userName;
            Password = password;
        }

        public Deltager()
        {
            
        }
    }
}
