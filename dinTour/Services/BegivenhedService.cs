using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.MockData;
using dinTour.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace dinTour.Services
{
    public class BegivenhedService
    {
        public DBGService<Begivenhed> DbService { get; set; }

        public List<Begivenhed> Begivenheder { get; set; }

        public BegivenhedService(DBGService<Begivenhed> dbService)
        {
            DbService = dbService;
            //Begivenheder = MockBegivenheder.GetAllBegivenheder().ToList();
            Begivenheder = DbService.GetObjectsAsync().Result.ToList();
            //foreach (var begivenhed in Begivenheder)
            //{
            //    dbService.AddObjectAsync(begivenhed);
            //}
        }

        public List<Begivenhed> GetAllBegivenheder()
        {
            return Begivenheder;
        }

        public Begivenhed GetBegivenhed(int id)
        {
            foreach (Begivenhed begivenhed in Begivenheder)
            {
                if (begivenhed.BegivenhedId == id) return begivenhed;
            }

            return null;
        }

        public void AddBegivenhed(Begivenhed begivenhed)
        {
            Begivenheder.Add(begivenhed);
            DbService.AddObjectAsync(begivenhed);
        }

        public async Task DeleteBegivenhedAsync(int begivId)
        {
            Begivenhed begivenhedToBeDeleted = Begivenheder.Find(begivenhed => begivenhed.BegivenhedId == begivId);
            if (begivenhedToBeDeleted != null)
            {
                Begivenheder.Remove(begivenhedToBeDeleted);
                //JsonFileService.SaveJsonObjects(items);
                await DbService.DeleteObjectAsync(begivenhedToBeDeleted);
            }

        }
    }
}
