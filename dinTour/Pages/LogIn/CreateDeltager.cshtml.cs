using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Models;
using dinTour.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dinTour.Pages.LogIn
{
    public class CreateDeltagerModel : PageModel
    {
        private DeltagerService _deltagerService;
        private PasswordHasher<string> passwordHasher;

        [BindProperty]
        public string UserName { get; set; }

        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }

        public int DeltagerId { get; set; }

        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Tlf { get; set; }
        [BindProperty]
        public string Email { get; set; }



        public CreateDeltagerModel(DeltagerService userService)
        {
            _deltagerService = userService;
            passwordHasher = new PasswordHasher<string>();
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _deltagerService.AddUser(new Deltager( Name, Tlf, Email, UserName, passwordHasher.HashPassword(null, Password)));
            return RedirectToPage("/Index");
        }

    }
}
