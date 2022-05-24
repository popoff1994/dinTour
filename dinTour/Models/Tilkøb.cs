using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class Tilkøb
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TlkøbId { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }
        [Required]
        public int DeltagerId { get; set; }

        public string Menu { get; set; }
        
        public int Count { get; set; }

        public string Name { get; set; }

        public Deltager Deltager { get; set; }
        [Required]
        public int VIPId { get; set; }

        public bool ChampagneMenu { get; set; }

        public VIP Vip { get; set; }

        public Tilkøb()
        {

        }

        public Tilkøb(Deltager deltager, VIP vip, int count)
        {
            Date = DateTime.Now;
            Deltager = deltager;
            Vip = vip;
            Count = count;
        }


    }
}
