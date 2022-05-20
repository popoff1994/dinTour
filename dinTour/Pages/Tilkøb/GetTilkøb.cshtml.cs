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
    public class GetTilkøbModel : PageModel
    {
        private VIPService _vipService;

        public List<VIP> VipMenu { get; set; }


        public GetTilkøbModel(VIPService vipService)
        {
            _vipService = vipService;
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
            Parkering = ParkeringService.GetParkering(id);
            Deltager = DeltagerService.GetUserByUserName(HttpContext.User.Identity.Name);
            ParkeringBy.DeltagerId = Deltager.DeltagerId;
            ParkeringBy.ParkeringId = Parkering.ParkeringId;
            ParkeringBy.Date = DateTime.Now;
            _bookningService.AddBookning(ParkeringBy);
            ParkeringService.BookParkering(Parkering);
            return RedirectToPage("/Parkering/GetParkering");
        }
    }
}
