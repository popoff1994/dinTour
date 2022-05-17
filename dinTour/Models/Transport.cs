using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class Transport
    {
        public int TransportId { get; set; }
        public string Type { get; set; }
        public DateTime Afgang { get; set; }
        public DateTime Ankomst { get; set; }

        public Transport(string type, DateTime afgang, DateTime ankomst)
        {
            Type = type;
            Afgang = afgang;
            Ankomst = ankomst;
        }
    }
}
