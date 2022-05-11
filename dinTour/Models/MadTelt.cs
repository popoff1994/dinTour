using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class MadTelt : Begivenhed <MadTelt>
    {
        public int MadId { get; set; }

        public MadTelt(string navn, int varrighed, string location) : base(navn, varrighed, location)
        {
           
        }

    }
}
