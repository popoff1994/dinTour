using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.MockData;
using dinTour.Models;

namespace dinTour.Services
{
    public class ParkeringService
    {
        public List<Parkering> ParkeringsPladser { get; set; }

        public ParkeringService()
        {
            ParkeringsPladser = MockParkering.GetMockParkering();
        }

        public List<Parkering> GetParkerings()
        {
            return ParkeringsPladser;
        }

        public Parkering GetParkering(int nr)
        {
            foreach (Parkering item in ParkeringsPladser)
            {
                if (item.ParkeringsNr == nr) return item;
            }
            return null;
        }

        //public Parkering BookParkering(int nr)
        //{
        //    Parkering parkeringtobebooked = null;
        //    foreach (Parkering item in ParkeringsPladser)
        //    {
        //        if (item.ParkeringsNr == nr)
        //        {
        //            parkeringtobebooked = item;
        //            break;
        //        }

        //        if (parkeringtobebooked != null)
        //        {
        //            parkeringtobebooked.Ocupied = true;
        //        }
        //    }
        //}
        public void BookParkering(Parkering parkering)
        {
            if (parkering != null)
            {
                foreach (Parkering i in ParkeringsPladser)
                {
                    if (i.ParkeringsNr == parkering.ParkeringsNr)
                    {
                        i.Ocupied = parkering.Ocupied = true;
                        break;
                    }
                    
                }

            }
        }
    }
}
