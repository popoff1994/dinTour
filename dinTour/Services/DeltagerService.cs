using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.MockData;
using dinTour.Models;

namespace dinTour.Services
{
    public class DeltagerService
    {
        public List<Deltager> Deltager { get; set; }



        public DeltagerService()
        {
            Deltager = MockDeltager.GetMockDeltager();
            //DbService = dbService;
            //Deltager = DbService.GetObjectsAsync().Result.ToList();
            //foreach (Deltager deltager in Deltager)
            //{
            //    dbService.AddObjectAsync(deltager);
            //}
        }

        public void AddUser(Deltager user)
        {
            Deltager.Add(user);
            //DbService.AddObjectAsync(user);
        }
    }


}
