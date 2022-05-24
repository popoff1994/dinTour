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

        public DBGService<Deltager> DbService2 { get; set; }

        public DeltagerDBService DbService { get; set; }

        public DeltagerService(DeltagerDBService dbService)
        {
            //Deltager = MockDeltager.GetMockDeltager();
            DbService = dbService;
            Deltager = DbService.GetObjectsAsync().Result.ToList();
            foreach (var deltager in Deltager)
            {
                dbService.AddObjectAsync(deltager);
            }
        }

        public async Task AddUser(Deltager user)
        {
            Deltager.Add(user);
            await DbService.AddObjectAsync(user);
        }

        public async Task<Deltager> GetParkingByUser(Deltager user)
        {
            return DbService.GetParkeringByUserIdAsync(user.DeltagerId).Result;
        }
        public async Task<Deltager> GetTilkøbByUser(Deltager user)
        {
            return DbService.GetTilkøbByUserIdAsync(user.DeltagerId).Result;
        }


        public Deltager GetUserByUserName(string username)
        {
            //return DbService.GetObjectByIdAsync(username).Result;
            return Deltager.Find(user => user.UserName == username);
        }
    }


}
