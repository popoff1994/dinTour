using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dinTour.Pages.Parkering
{
    public class BookParkeringModel : PageModel
    {
        private ParkeringService parkeringService;
        [BindProperty]
        public Models.Parkering Parkeringspladser { get; set; }

        public BookParkeringModel(ParkeringService parkeringService)
        {
            this.parkeringService = parkeringService;
        }
        public IActionResult OnGet(int id)
        {
            Parkeringspladser = parkeringService.GetParkering(id);
            if(Parkeringspladser == null)
            {
                return RedirectToPage("/NotFound"); // mangler implementation
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            parkeringService.BookParkering(Parkeringspladser);
            return RedirectToPage("GetParkering");
        }

    }
}
