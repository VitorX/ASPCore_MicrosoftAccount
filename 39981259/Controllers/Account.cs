using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _39981259.Controllers
{
    public class AccountController: Controller
    {
        public async Task Login()
        {
            
            await HttpContext.Authentication.ChallengeAsync(new AuthenticationProperties() { RedirectUri = "/" });
        }

        public async Task LogOff()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                await HttpContext.Authentication.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme, new AuthenticationProperties() { RedirectUri = "/" });

                HttpContext.Response.Redirect("/");
            }
        }
    }
}
