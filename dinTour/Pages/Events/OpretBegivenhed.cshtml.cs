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
    public class OpretBegivenhedModel : PageModel
    {
        private MusikTeltService _musikTeltService;
        private List<MusikTelt> Artister;
        [BindProperty]
        public MusikTelt Artist { get; set; }
        public OpretBegivenhedModel(MusikTeltService ms)
        {
            _musikTeltService = ms;
            Artister = _musikTeltService.GetAllArtister().ToList();
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
            _musikTeltService.AddArtist(Artist);
            return RedirectToPage("GetEvents");
        }
    }
}
