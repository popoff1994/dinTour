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
            new ("Bamse", 20, "MusikTelt", "Bamse spiller Musik. KOM GLAD!"),
            new ("Rektor Tale", 15, "Tribune", "Rektor holder tale til at starte dagens event"),
            new ("FOOD WAR!", 45, "MadTelt", "Kom og vær med til årets FoodFight, man skal ikke selv rydde op!"),
            new ("FOOD WAR!", 45, "MusikTelt", "Kom og vær med til årets FoodFight, man skal ikke selv rydde op!"),
            new ("FOOD WAR!", 45, "Tribune", "Kom og vær med til årets FoodFight, man skal ikke selv rydde op!"),
            new ("FOOD WAR!", 45, "MadTelt", "Kom og vær med til årets FoodFight, man skal ikke selv rydde op!"),
        };

        public static List<Begivenhed> GetAllBegivenheder()
        {
            return begivenheder;
        }
    }
}
