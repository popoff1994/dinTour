using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Models;

namespace dinTour.MockData
{
    public class MockBegivenheder
    {
        private static List<Begivenhed> begivenheder = new List<Begivenhed>()
        {
            new ("Bamse", "MadTelt", DateTime.Now, DateTime.Now),
            new ("Basim", "MusikTelt", DateTime.Now, DateTime.Now),
            new ("Rektor introduktion", "Tribune", DateTime.Now, DateTime.Now)
        };

        public static List<Begivenhed> GetAllBegivenheder()
        {
            return begivenheder;
        }
    }
}
