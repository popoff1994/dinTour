using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Models;
using dinTour.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dinTour.Pages.Parkering
{
    public class ParkeringDeltagerModel : PageModel
    {
        
        private DeltagerService _deltagerService;
        private ParkeringService _parkeringService;
        private BookningService _bookningService;

        public DeltagerService DeltagerService { get; set; }
        public ParkeringService ParkeringService { get; set; }

        public Models.Parkering Parkering { get; set; }

        public Deltager Deltager { get; set; }

        public Models.Bookning ParkeringBy { get; set; } = new Models.Bookning();


        public ParkeringDeltagerModel(DeltagerService deltagerService, ParkeringService parkeringService, BookningService bookningService)
        {
            this._deltagerService = deltagerService;
            this._parkeringService = parkeringService;
            this._bookningService = bookningService;
        }


        public void OnGet(int id)
        {
            Parkering = ParkeringService.GetParkering(id);
            Deltager = DeltagerService.GetUserByUserName(HttpContext.User.Identity.Name);
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Parkering = ParkeringService.GetParkering(id);
            Deltager = DeltagerService.GetUserByUserName(HttpContext.User.Identity.Name);
            ParkeringBy.DeltagerNr = Deltager.DeltagerNr;
            ParkeringBy.BookingId = Parkering.ParkeringsNr;
            ParkeringBy.Date = DateTime.Now;
            _bookningService.AddBookning(ParkeringBy);
            return RedirectToPage("../Item/GetAllItems");
        }
    }
}
