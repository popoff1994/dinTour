using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.MockData;
using dinTour.Models;

namespace dinTour.Services
{
    public class MusikTeltService
    {
        public DBGService<MusikTelt> DbService { get; set; }

        public List<MusikTelt> Artister { get; set; }

        public MusikTeltService(DBGService<MusikTelt> dbService)
        {
            DbService = dbService;
            Artister = MockMusiktelt.GetAllMusik();
            //Artister = = DbService.GetObjectsAsync().Result.ToList();
            //foreach (MusikTelt artister in Artister)
            //{
            //    dbService.AddObjectAsync(artister);
            //}
        }

        public List<MusikTelt> GetAllArtister()
        {
            return Artister;
        }

        public void AddArtist(MusikTelt artist)
        {
            Artister.Add(artist);
            DbService.AddObjectAsync(artist);
        }

    }
}
