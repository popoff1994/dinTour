using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class Bookning
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingId { get; set; }
        
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }
        [Required]
        public int DeltagerNr { get; set; }
        public Deltager Deltager { get; set; }
        [Required]
        public int ParkeringId { get; set; }
        public Parkering Parkering { get; set; }

        public Bookning()
        {

        }

        public Bookning(Deltager deltager, Parkering parkering)
        {
            Date = DateTime.Now;
            Deltager = deltager;
            Parkering = parkering;
        }

    }
}
