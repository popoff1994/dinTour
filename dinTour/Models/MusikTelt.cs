using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class MusikTelt
    {
        public int MusikId { get; set; }

        public string Navn { get; set; }

        public int Varrighed { get; set; }

        public string Location { get; set; }

        public MusikTelt(int musikId, string navn, int varrighed, string location)
        {
            MusikId = musikId;
            Navn = navn;
            Varrighed = varrighed;
            Location = location;
        }

        public MusikTelt()
        {
            
        }
    }
}
