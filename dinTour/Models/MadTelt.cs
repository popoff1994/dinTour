using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class MadTelt
    {
        public int MadId { get; set; }
        public string Navn { get; set; }
        public int Varrighed { get; set; }

        public string Location { get; set; }


        public MadTelt(int madId, string navn, int varrighed, string location)
        {
            MadId = madId;
            Navn = navn;
            Varrighed = varrighed;
            Location = location;
        }

        public MadTelt()
        {
            
        }
    }
}
