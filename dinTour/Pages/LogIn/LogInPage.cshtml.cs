using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading.Tasks;
using dinTour.Models;
using dinTour.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dinTour.Pages.LogIn
{
    public class LogInPageModel : PageModel
    {
        public static Deltager LogInDeltager { get; set; } = null;

        private DeltagerService _deltagerService;

        [BindProperty] public string UserName { get; set; }

        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }

        [BindProperty] public string Message { get; set; }

        public LogInPageModel(DeltagerService deltagerService)
        {
            _deltagerService = deltagerService;
        }


        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            List<Deltager> deltagers = _deltagerService.Deltager;

            var passwordHasher = new PasswordHasher<string>();
            foreach (Models.Deltager deltager in deltagers)
            {

                if (UserName == deltager.UserName &&
                    passwordHasher.VerifyHashedPassword(null, deltager.Password, Password) ==
                    PasswordVerificationResult.Success)
                {

                    var claims = new List<Claim>
                        {new Claim(ClaimTypes.Name, UserName), new Claim(ClaimTypes.Role, "admin")};

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity));
                    return RedirectToPage("/ ");

                }
            }
            Message = "Invalid attempt";
            return Page();
        }

    }
}