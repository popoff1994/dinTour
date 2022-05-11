using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class Begivenhed <T> where T : class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int BegivenhedId { get; set; }

        public string Navn { get; set; }
        public int Varrighed { get; set; }
        public string Location { get; set; }

        public List<Begivenhed<T>> _begivenheder;


        public Begivenhed(string navn, int varrighed, string location)
        {
            Navn = navn;
            Varrighed = varrighed;
            Location = location;
        }
    }
}
