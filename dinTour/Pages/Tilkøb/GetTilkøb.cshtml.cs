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

        public int Count { get; set; }

        
        [Required]
        public List<VIP> VipMenu { get; set; }

        public GetTilkøbModel(VIPService vipService)
        {
            _vipService = vipService;

        }

        public IActionResult OnGet(int id)
        {
            VipMenu = _vipService.GetAllVIPS().ToList();
            return Page();
        }
    }
}
