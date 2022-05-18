using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Models;
using dinTour.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dinTour.Pages.Tilkøb
{
    public class GetTilkøbModel : PageModel
    {
        private TilkøbService _tilkøbService;

        public List<VIP> VipMenu { get; set; }


        public GetTilkøbModel(TilkøbService tilkøbService)
        {
            _tilkøbService = tilkøbService;
        }

        public IActionResult OnGet()
        {
            VipMenu = _tilkøbService.GetAllVIPS().ToList();
            return Page();
        }
    }
}
