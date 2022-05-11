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
    public class GetEventsModel : PageModel
    {
        public List<Begivenhed<MusikTelt>> Musik { get; set; }

        public MusikTeltService MusikTeltService { get; set; }

        public GetEventsModel(MusikTeltService musikTeltService)
        {
            MusikTeltService = musikTeltService;
        }


        public IActionResult OnGet()
        {
            Musik = MusikTeltService.GetAllArtister().ToList();
            return Page();
        }
    }
}
