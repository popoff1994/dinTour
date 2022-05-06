using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using dinTour.Models;
using Microsoft.AspNetCore.Identity;

namespace dinTour.MockData
{
    public class MockDeltager
    {
        public static PasswordHasher<string> passwordHasher = new PasswordHasher<string>();
        private static List<Deltager> deltager = new List<Deltager>()
        {
            new Deltager(1, "AntonJonasSaimSimon", "42156804", "saimnadeem1999@hotmail.com", "admin", passwordHasher.HashPassword(null, "1234")),
        };

        public static List<Deltager> GetMockDeltager()
        {
            return deltager;
        }
    }
}