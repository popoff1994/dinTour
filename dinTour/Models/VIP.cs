using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class VIP
    {
        public int VIPNr { get; set; }
        public int Pris { get; set; }
        public string Menu1 { get; set; }

        public string Menu2 { get; set; }

        public string Menu3 { get; set; }


        public VIP(int vipNr, int pris, string menu1, string menu2, string menu3)
        {
            VIPNr = vipNr;
            Pris = pris;
            Menu1 = menu1;
            Menu2 = menu2;
            Menu3 = menu3;
        }
        public VIP()
        {
            
        }
    }
}
