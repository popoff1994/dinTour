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
        

        public BegivenhedService _begivenhedService;

        public GetEventsModel(BegivenhedService begivenhedService)
        {
            this._begivenhedService = begivenhedService;
        }


        public async Task<IActionResult> OnGetAsync()
        {
            Begivenheder = _begivenhedService.GetAllBegivenheder().ToList();
            return Page();
        }
    }
}
