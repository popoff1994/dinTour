using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.MockData;
using dinTour.Models;
using dinTour.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dinTour.Pages.Events
{
    public class GetEventsModel : PageModel
    {
        public List<Begivenhed> Begivenheder { get; set; }

        public List<Deltager> Deltagere { get; set; }
        public DeltagerService DeltagerService { get; set; }

        public BegivenhedService _begivenhedService;

        public GetEventsModel(BegivenhedService begivenhedService, DeltagerService deltagerService)
        {
            this._begivenhedService = begivenhedService;
            this.DeltagerService = deltagerService;
        }


        public async Task<IActionResult> OnGetAsync()
        {
            Deltagere = DeltagerService.GetUsers();
            Begivenheder = _begivenhedService.GetAllBegivenheder().ToList();
            return Page();
        }
    }
}
