using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Models;
using dinTour.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dinTour.Pages.Events
{
    public class BekræftTilmeldingModel : PageModel
    {
        private EventService _eventService;
        [BindProperty]
        public Models.Event Event { get; set; }

        public DeltagerService DeltagerService { get; set; }


        public Deltager Deltager { get; set; }

        public BekræftTilmeldingModel( DeltagerService deltagerService, EventService eventService)
        {
            _eventService = eventService;
            DeltagerService = deltagerService;
        }
        public IActionResult OnGet(int id)
        {
            Event = _eventService.GetEvent(id);
            Deltager = DeltagerService.GetUserByUserName(HttpContext.User.Identity.Name);
          return Page();
        }
        public IActionResult OnPost(Event eventet)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _eventService.GetEvent(eventet.EventId);
            _eventService.TilmeldEvent(eventet);
            eventet = Event;
            return RedirectToPage("/Events/TilmeldEvent");
        }
    }
}
