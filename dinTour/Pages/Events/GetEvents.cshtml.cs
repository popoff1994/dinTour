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

        [BindProperty]
        public Microsoft.AspNetCore.Http.HttpContext Context { get; }

        public DeltagerService DeltagerService { get; set; }

        public BegivenhedService _begivenhedService;

        public GetEventsModel(BegivenhedService begivenhedService, HttpContext context)
        {
            this._begivenhedService = begivenhedService;
            Context = context;
        }


        public async Task<IActionResult> OnGetAsync()
        {
            Deltager currentUser = DeltagerService.GetUserByUserName(HttpContext.User.Identity.Name);
            Begivenheder = _begivenhedService.GetAllBegivenheder().ToList();

            return Page();
        }
    }
}
