using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class VIP
    
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VIPId { get; set; }
        public int Pris { get; set; }
        public string Menu { get; set; }

        public bool ChampagneMenu { get; set; }

        public VIP(int pris, string menu)
        {
            Pris = pris;
            Menu = menu;
        }
        public VIP()
        {
            
        }
    }
}
