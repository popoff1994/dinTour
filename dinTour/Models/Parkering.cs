using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class Parkering
    {
        public int ParkeringsNr { get; set; }
        public bool Ocupied { get; set; }

        public int Pris { get; set; }

        public Parkering(int parkeringsNr, bool ocupied, int pris)
        {
            ParkeringsNr = parkeringsNr;
            Ocupied = ocupied;
            Pris = pris;
        }

        public Parkering()
        {
            
        }
    }
}
