using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class MusikTelt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int MusikId { get; set; }
        [Required]
        public string Navn { get; set; }
        [Required]
        public int Varrighed { get; set; }
        [Required]
        public string Location { get; set; }

        public MusikTelt( string navn, int varrighed, string location)
        {
            
            Navn = navn;
            Varrighed = varrighed;
            Location = location;
        }

        public MusikTelt()
        {
            
        }
    }
}
