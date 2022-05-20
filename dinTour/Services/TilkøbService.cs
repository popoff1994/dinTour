using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.MockData;
using dinTour.Models;

namespace dinTour.Services
{
    public class TilkøbService
    {
        public List<Tilkøb> TilkøbsList { get; set; }

        public DBGService<Tilkøb> DbService { get; set; }

        public TilkøbService(DBGService<Tilkøb> dbService)
        {
            DbService = dbService;
            TilkøbsList = DbService.GetObjectsAsync().Result.ToList();
        }

        public async void AddTilkøb(Tilkøb tilkøb)
        {
            TilkøbsList.Add(tilkøb);
            await DbService.AddObjectAsync(tilkøb);
        }
    }
}
