using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using dinTour.MockData;
using dinTour.Models;

namespace dinTour.Services
{
    public class ParkeringService
    {
        public List<Parkering> ParkeringsPladser { get; set; }
        public DBGService<Parkering> DbService { get; set; }

        public ParkeringService(DBGService<Parkering> dbService)
        {
            //ParkeringsPladser = MockParkering.GetMockParkering();
            DbService = dbService;
            ParkeringsPladser = DbService.GetObjectsAsync().Result.ToList();
            //foreach (Parkering parkering in ParkeringsPladser)
            //{
            //    dbService.AddObjectAsync(parkering);
            //}

        }


        public List<Parkering> GetParkerings()
        {
            return ParkeringsPladser;
        }

        public Parkering GetParkering(int id)
        {
            foreach (Parkering item in ParkeringsPladser)
            {
                if (item.ParkeringId == id) return item;
            }
            return null;
        }


 

        public void BookParkering(Parkering parkering)
        {
            if (parkering != null)
            {
                foreach (Parkering i in ParkeringsPladser)
                {
                    if (i.ParkeringId == parkering.ParkeringId)
                    {
                        i.Ocupied = true;
                        break;
                    }
                    DbService.UpdateObjectAsync(parkering);
                }

            }
        }
    }
}
