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
        }

        public void AddUser(Deltager user)
        {
            Deltager.Add(user);
            //JsonFileService.SaveJsonObjects(Users);
            //DbService.AddObjectAsync(user);
        }
    }


}
