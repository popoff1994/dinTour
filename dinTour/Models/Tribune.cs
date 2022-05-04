using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class Tribune
    {
        public int TrbiuneId { get; set; }
        public string Navn { get; set; }
        public int varrighed { get; set; }
        public string Location { get; set; }


        public Tribune(int trbiuneId, string navn, int varrighed, string location)
        {
            TrbiuneId = trbiuneId;
            Navn = navn;
            this.varrighed = varrighed;
            Location = location;
        }


        public Tribune()
        {
            
        }
    }
}
