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
    public class ParkeringDeltagerModel : PageModel
    {

        public DeltagerService DeltagerService { get; set; }
        public BookningService BookningService { get; set; }


        //public IEnumerable<OrderDAO> MyOrders { get; set; }
        public IEnumerable<Models.Bookning> CurrentBookings { get; set; }

        public ParkeringDeltagerModel(DeltagerService deltagerService, BookningService bookningService)
        {
            DeltagerService = deltagerService;
            BookningService = bookningService;

        }
        public async Task<IActionResult> OnGetAsync()
        {
            CurrentBookings = BookningService.BookningList.ToList();
            //Deltager CurrentUser = DeltagerService.GetUserByUserName(HttpContext.User.Identity.Name);
            //MyOrders = UserService.GetUserOrders(CurrentUser);
            //CurrentBookings = DeltagerService.GetParkingByUser(CurrentUser).Result.Bookning;
            return Page();
        }
    }
}
