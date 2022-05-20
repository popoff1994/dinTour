using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Models;
using dinTour.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dinTour.Pages.Tilkøb
{
    public class BekræftTilkøbModel : PageModel
    {
        private VIPService _vipService;
        private DeltagerService _deltagerService;
        private TilkøbService _tilkøbService;

        public List<VIP> VipMenu { get; set; }

        public VIP Vip { get; set; }
        public Deltager Deltager { get; set; }
        public Models.Tilkøb Tilkøb { get; set; } = new Models.Tilkøb();



        public BekræftTilkøbModel(VIPService vipService, DeltagerService deltagerService, TilkøbService tilkøbService)
        {
            _vipService = vipService;
            _deltagerService = deltagerService;
            _tilkøbService = tilkøbService;
        }

        public IActionResult OnGet()
        {
            VipMenu = _vipService.GetAllVIPS().ToList();
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Vip = _vipService.GetVIP(id);
            Deltager = _deltagerService.GetUserByUserName(HttpContext.User.Identity.Name);
            Tilkøb.DeltagerId = Deltager.DeltagerId;
            Tilkøb.VIPId = Vip.VIPId;
            Tilkøb.Date = DateTime.Now;
            _tilkøbService.AddTilkøb(Tilkøb);
            return RedirectToPage("/Tilkøb/GetTilkøb");
        }
    }
}
