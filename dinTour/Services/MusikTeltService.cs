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
        public DBGService<Begivenhed<MusikTelt>> DbService { get; set; }

        public List<Begivenhed<MusikTelt>> Artister { get; set; }

        public MusikTeltService(DBGService<Begivenhed<MusikTelt>> dbService)
        {
            //DbService = dbService;
            Artister = MockMusiktelt.GetAllMusik();
            //Artister = = DbService.GetObjectsAsync().Result.ToList();
            //foreach (MusikTelt artister in Artister)
            //{
            //    dbService.AddObjectAsync(artister);
            //}
        }

        public List<Begivenhed<MusikTelt>> GetAllArtister()
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
