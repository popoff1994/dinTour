using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dinTour.Pages.Tilkøb
{
    public class DeltagerBestillingerModel : PageModel
    {

        public DeltagerService DeltagerService { get; set; }
        public BookningService BookningService { get; set; }
        public TilkøbService TilkøbService { get; set; }


        //public IEnumerable<OrderDAO> MyOrders { get; set; }
        public IEnumerable<Models.Bookning> CurrentBookings { get; set; }
        public IEnumerable<Models.Tilkøb> CurrentTilkøb { get; set; }

        public DeltagerBestillingerModel(DeltagerService deltagerService, BookningService bookningService, TilkøbService tilkøbService)
        {
            DeltagerService = deltagerService;
            BookningService = bookningService;
            TilkøbService = tilkøbService;

        }
        public async Task<IActionResult> OnGetAsync()
        {
            CurrentBookings = BookningService.BookningList.ToList();
            CurrentTilkøb = TilkøbService.TilkøbsList.ToList();
            return Page();
        }
    }
}
