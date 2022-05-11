﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Models;

namespace dinTour.MockData
{
    public class MockMusiktelt
    {
        private static List<MusikTelt> musik = new List<MusikTelt>()
        {
            new MusikTelt("Bamse", 30, "Musikteltet"),
            new MusikTelt("Nickelback", 15, "Musikteltet"),
            new MusikTelt("Sivas", 45, "Musikteltet"),
        };

        public static List<MusikTelt> GetAllMusik()
        {
            return musik;
        }
    }
}