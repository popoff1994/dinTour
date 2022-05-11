using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class Event <T>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventId { get; set; }

        public List<Begivenhed> Begivenheder { get; set; }

        public Event()
        {
            
        }

        public Event(List<Begivenhed> begivenheder)
        {
            Begivenheder = begivenheder;
        }
    }
}
