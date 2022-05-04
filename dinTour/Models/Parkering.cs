using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class Parkering
    {
        public int ParkeringsNr { get; set; }

        public int Pris { get; set; }

        public Parkering(int parkeringsNr, int pris)
        {
            ParkeringsNr = parkeringsNr;
            Pris = pris;
        }

        public Parkering()
        {
            
        }
    }
}
