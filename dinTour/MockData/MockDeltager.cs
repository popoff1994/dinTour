using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using dinTour.Models;
using Microsoft.AspNetCore.Identity;

namespace dinTour.MockData
{
    public class MockDeltager
    {
        public static PasswordHasher<string> passwordHasher = new PasswordHasher<string>();
        public static List<Deltager> deltager = new List<Deltager>()
        {
            new Deltager( "AntonJonasSaimSimon", "42156804", "saimnadeem1999@hotmail.com", "admin", passwordHasher.HashPassword(null, "1234")),
            new Deltager( "Jonas", "88888888", "jonas@gmail.com", "popoff", passwordHasher.HashPassword(null, "1234"))
        };

        public static List<Deltager> GetMockDeltager()
        {
            return deltager;
        }
    }
}