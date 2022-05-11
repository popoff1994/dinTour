using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class Parkering
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
