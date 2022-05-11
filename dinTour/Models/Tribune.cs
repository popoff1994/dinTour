using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class Tribune : Begivenhed<Tribune>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int TrbiuneId { get; set; }



        public Tribune(string navn, int varrighed, string location) : base(navn, varrighed, location)
        {

        }

    }
}
