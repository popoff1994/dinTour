using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Models;

namespace dinTour.MockData
{
    public class MockEvent
    {
        private static List<Event> events = new List<Event>()
        {
            new ("Tour de France", 0),
         
        };

        public static List<Event> GetAllBegivenheder()
        {
            return events;
        }
    }
}
