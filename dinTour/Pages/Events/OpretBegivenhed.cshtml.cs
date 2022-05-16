using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Models;
using dinTour.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace dinTour.Pages.Events
{
    public class OpretBegivenhedModel : PageModel
    {
        [BindProperty]
        public List<Begivenhed> Begivenheder { get; set; }

        [BindProperty]
        public Begivenhed Begivenhed { get; set; }

        [BindProperty]
        public string Location { get; set; }

        public BegivenhedService BegivenhedService { get; set; }

        public OpretBegivenhedModel(BegivenhedService begivenhedService)
        {
            BegivenhedService = begivenhedService;
            Begivenheder = begivenhedService.GetAllBegivenheder().ToList();
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            BegivenhedService.AddBegivenhed(Begivenhed);
            return RedirectToPage("/Events/GetEvents");
        }
    }
}
