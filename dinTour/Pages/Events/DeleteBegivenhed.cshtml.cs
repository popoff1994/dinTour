using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dinTour.Pages.Events
{
    public class DeleteBegivenhedModel : PageModel
    {
        private BegivenhedService begivenhedService;

        [BindProperty]
        public Models.Begivenhed Begivenhed { get; set; }

        public DeleteBegivenhedModel(BegivenhedService begivenhedService)
        {
            this.begivenhedService = begivenhedService;
        }
        public IActionResult OnGet(int id)
        {
            Begivenhed = begivenhedService.GetBegivenhed(id);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            Begivenhed = begivenhedService.GetBegivenhed(id);
            await begivenhedService.DeleteBegivenhedAsync(Begivenhed.BegivenhedId);
            return RedirectToPage("GetEvents");
        }
    }
}
