using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Models;
using dinTour.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceStack.DataAnnotations;

namespace dinTour.Pages.Tilkøb
{
    public class GetTilkøbModel : PageModel
    {
        private VIPService _vipService;


        
        [Required]
        public List<VIP> VipMenu { get; set; }

        public GetTilkøbModel(VIPService vipService, DeltagerService deltagerService, TilkøbService tilkøbService)
        {
            _vipService = vipService;

        }

        public IActionResult OnGet()
        {
            VipMenu = _vipService.GetAllVIPS().ToList();
            return Page();
        }
    }
}
