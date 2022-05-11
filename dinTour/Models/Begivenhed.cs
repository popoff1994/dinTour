using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class Begivenhed
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int BegivenhedId { get; set; }

        public List<MusikTelt> MusikTelt { get; set; }
        public List<Tribune> Tribune { get; set; }
        public List<MadTelt> Madtelt { get; set; }


        public Begivenhed()
        {
            
        }

        public Begivenhed(List<MusikTelt> musikTelt, List<Tribune> tribune, List<MadTelt> madtelt)
        {
            MusikTelt = musikTelt;
            Tribune = tribune;
            Madtelt = madtelt;
        }

    }
}
