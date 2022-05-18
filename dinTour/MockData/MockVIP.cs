using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Models;
using Microsoft.AspNetCore.Identity;

namespace dinTour.MockData
{
    public class MockVIP
    {
        
        public static List<VIP> VIPS = new List<VIP>()
        {
            new VIP(500, "Almindelig Menu"),
            new VIP(350, "Veganer Menu"),
        };

        public static List<VIP> GetVipMenu()
        {
            return VIPS;
        }
    }
}
