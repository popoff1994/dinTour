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
    public class AntalTilmeldteModel : PageModel
    {

        public List<Deltager> Deltagere { get; set; }

        public DeltagerService DeltagerService { get; set; }

        public AntalTilmeldteModel(DeltagerService deltagerService)
        {
            this.DeltagerService = deltagerService;
        }

        public void OnGet()
        {
            Deltagere = DeltagerService.GetUsers().ToList();
        }
    }
}
