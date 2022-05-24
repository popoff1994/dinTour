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

        public string EventName { get; set; }

        public int AntalTilmeldte { get; set; }

        public Event(string eventName, int antalTilmeldte)
        {
            EventName = eventName;
            AntalTilmeldte = antalTilmeldte;
        }

        public Event()
        {
            
        }
    }
}
