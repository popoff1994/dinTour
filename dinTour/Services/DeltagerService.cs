using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using dinTour.MockData;
using dinTour.Models;

namespace dinTour.Services
{
    public class DeltagerService
    {
        public List<Deltager> Deltager { get; set; }

        public DBGService<Deltager> DbService { get; set; }


        public DeltagerService(DBGService<Deltager> dbService)
        {
            Deltager = MockDeltager.GetMockDeltager();
            DbService = dbService;
            //Deltager = DbService.GetObjectsAsync().Result.ToList();
            foreach (var deltager in Deltager)
            {
                dbService.AddObjectAsync(deltager);
            }
        }

        public void AddUser(Deltager user)
        {
            Deltager.Add(user);
            DbService.AddObjectAsync(user);
        }
    }


}
