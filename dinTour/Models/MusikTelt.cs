using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class MusikTelt : Begivenhed <MusikTelt>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int MusikId { get; set; }


        public MusikTelt(string navn, int varrighed, string location) : base(navn, varrighed, location)
        {
            
        }
    }
}
