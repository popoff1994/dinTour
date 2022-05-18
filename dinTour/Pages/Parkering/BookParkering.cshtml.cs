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
    public class BookParkeringModel : PageModel
    {
        private DeltagerService _deltagerService;
        private ParkeringService parkeringService;
        private BookningService _bookningService;
        [BindProperty]
        public Models.Parkering Parkering { get; set; }

        public DeltagerService DeltagerService { get; set; }
        public ParkeringService ParkeringService { get; set; }

        public Deltager Deltager { get; set; }
        public Models.Bookning ParkeringBy { get; set; } = new Models.Bookning();

        public BookParkeringModel(ParkeringService parkeringService, DeltagerService deltagerService, BookningService bookningService)
        {
            this.parkeringService = parkeringService;
            this._deltagerService = deltagerService;
            this._bookningService = bookningService;
        }
        public IActionResult OnGet(int id)
        {
            Parkering = parkeringService.GetParkering(id);
            Deltager = DeltagerService.GetUserByUserName(HttpContext.User.Identity.Name);
            if (Parkering == null)
            {
                return RedirectToPage("/NotFound"); // mangler implementation
            }
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
            ParkeringBy.DeltagerNr = Deltager.DeltagerNr;
            ParkeringBy.BookingId = Parkering.ParkeringsNr;
            ParkeringBy.Date = DateTime.Now;
            _bookningService.AddBookning(ParkeringBy);
            parkeringService.BookParkering(Parkering);
            return RedirectToPage("/GetParkering");
        }

    }
}
