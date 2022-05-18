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
        public List<VIP> VIPMenu { get; set; }

        public DBGService<VIP> DBService { get; set; }

        public TilkøbService(DBGService<VIP> dbService)
        {
            VIPMenu = MockVIP.GetVipMenu().ToList();
            DBService = dbService;
            //VIPMenu = DBService.GetObjectsAsync().Result.ToList();
            //foreach (var vip in VIPMenu)
            //{
            //    dbService.AddObjectAsync(vip);
            //}
        }
        public List<VIP> GetAllVIPS()
        {
            return VIPMenu;
        }

    }
}
