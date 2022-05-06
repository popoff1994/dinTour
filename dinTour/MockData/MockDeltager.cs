using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using dinTour.Models;

namespace dinTour.MockData
{
    public class MockDeltager
    {
        private static List<Deltager> deltager = new List<Deltager>()
        {
            new Deltager(1, "AntonJonasSaimSimon", "42156804", "saimnadeem1999@hotmail.com", "AASS", "123"),
        };

        public static List<Deltager> GetMockDeltager()
        {
            return deltager;
        }
    }
}