using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventId { get; set; }

        public string Navn { get; set; }

        public List<Begivenhed> Begivenheder { get; set; }


        public Event()
        {
            
        }

        public Event(string navn)
        {
            Navn = navn;
        }
    }
}
