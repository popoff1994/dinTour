using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.MockData;
using dinTour.Models;

namespace dinTour.Services
{
    public class BegivenhedService
    {
        public DBGService<Begivenhed> DbService { get; set; }

        public List<Begivenhed> Begivenheder { get; set; }

        public BegivenhedService(DBGService<Begivenhed> dbService)
        {
            DbService = dbService;
            Begivenheder = MockBegivenheder.GetAllBegivenheder().ToList();
            //Begivenheder = DbService.GetObjectsAsync().Result.ToList();
            //foreach (var begivenhed in Begivenheder)
            //{
            //    dbService.AddObjectAsync(begivenhed);
            //}
        }
        public List<Begivenhed> GetAllBegivenheder()
        {
            return Begivenheder;
        }

        public void AddBegivenhed(Begivenhed begivenhed)
        {
            Begivenheder.Add(begivenhed);
            //DbService.AddObjectAsync(begivenhed);
        }
    }
    
}
