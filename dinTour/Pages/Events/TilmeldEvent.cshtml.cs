using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dinTour.Pages.Events
{
    public class TilmeldEventModel : PageModel
    {
        private EventService _eventService;
        [BindProperty]
        public List<Models.Event> Events { get; set; }



        public TilmeldEventModel(EventService eventService)
        {
            this._eventService = eventService;
        }

        public IActionResult OnGet()
        {
            Events = _eventService.GetEvents().ToList();
            return Page();
        }
    }
}
