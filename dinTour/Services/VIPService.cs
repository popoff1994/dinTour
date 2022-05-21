using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.MockData;
using dinTour.Models;

namespace dinTour.Services
{
    public class VIPService
    {
        public List<VIP> VIPMenu { get; set; }

        public DBGService<VIP> DBService { get; set; }

        public VIPService(DBGService<VIP> dbService)
        {
            //VIPMenu = MockVIP.GetVipMenu().ToList();
            DBService = dbService;
            VIPMenu = DBService.GetObjectsAsync().Result.ToList();
            ////foreach (var vip in VIPMenu)
            ////{
            ////    dbService.AddObjectAsync(vip);
            ////}
        }
        public List<VIP> GetAllVIPS()
        {
            return VIPMenu;
        }
        public VIP GetVIP(int id)
        {
            foreach (VIP vip in VIPMenu)
            {
                if (vip.VIPId == id) return vip;
            }
            return null;
        }
    }
}
