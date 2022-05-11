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
        [Required]
        public int ParkeringsNr { get; set; }
        [Required]
        public bool Ocupied { get; set; }
        [Required]
        public int Pris { get; set; }

        public Parkering(bool ocupied, int pris)
        {
            Ocupied = ocupied;
            Pris = pris;
        }

        public Parkering()
        {
            
        }
    }
}
