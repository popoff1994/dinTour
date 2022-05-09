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
    }
}
