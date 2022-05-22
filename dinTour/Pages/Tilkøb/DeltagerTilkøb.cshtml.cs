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
    public class DeltagerTilkøbModel : PageModel
    {
        public DeltagerService DeltagerService { get; set; }
        public BookningService BookningService { get; set; }

        public TilkøbService TilkøbService { get; set; }

        public string Menu { get; set; }

        //public IEnumerable<OrderDAO> MyOrders { get; set; }
        public IEnumerable<Models.Bookning> CurrentBookings { get; set; }
        public IEnumerable<Models.Tilkøb> CurrentTilkøb { get; set; }


        public DeltagerTilkøbModel(DeltagerService deltagerService, BookningService bookningService, TilkøbService tilkøbService)
        {
            DeltagerService = deltagerService;
            BookningService = bookningService;
            TilkøbService = tilkøbService;

        }
        public async Task<IActionResult> OnGetAsync()
        {
            //CurrentBookings = BookningService.BookningList.ToList();
            
            Deltager CurrentUser = DeltagerService.GetUserByUserName(HttpContext.User.Identity.Name);
            //MyOrders = UserService.GetUserOrders(CurrentUser);
            CurrentBookings = DeltagerService.GetParkingByUser(CurrentUser).Result.Bookning;
            CurrentTilkøb = DeltagerService.GetTilkøbByUser(CurrentUser).Result.Tilkøb;
            return Page();
        }
    }
}
