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
    public class GetParkeringModel : PageModel
    {
        private ParkeringService _parkeringService;
        [BindProperty]
        public List<Models.Parkering> parkeringspladser { get; set; }


        public GetParkeringModel(ParkeringService parkeringService)
        {
            this._parkeringService = parkeringService;
        }
        
        public IActionResult OnGet()
        {
            parkeringspladser = _parkeringService.GetParkerings().ToList();
            return Page();
        }
    }
}
