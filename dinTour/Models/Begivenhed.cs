using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Immutable;

namespace dinTour.Models
{
    public class Begivenhed
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int BegivenhedId { get; set; }

        public string Navn { get; set; }
        public int Varrighed { get; set; }
        public string Location { get; set; }

        public string Beskrivelse { get; set; }



        public Begivenhed(string navn, int varrighed, string location, string beskrivelse)
        {
            Navn = navn;
            Varrighed = varrighed;
            Location = location;
            Beskrivelse = beskrivelse;
        }

        public Begivenhed()
        {
            
        }
    }
}
