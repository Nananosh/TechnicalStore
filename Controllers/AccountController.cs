using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using TechnicalStore.DataBaseConnection;
using TechnicalStore.DataBaseConnection.db.connections;
using TechnicalStore.DataBaseConnection.Factory;
using TechnicalStore.Models;

namespace TechnicalStore.Controllers
{
    public class AccountController : Controller
    {
        public AccountController() { }
        [HttpGet]
        public IActionResult Register(string returnUrl)
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            var lstUser = Factory.GetAllProfileInformation(DatabaseConnection.GetAllProfileInformation());

            foreach (User u in lstUser)
            {
                if (u.Email != user.Email)
                {
                    if (ModelState.IsValid)
                    {
                        Factory.InsertProfile(user);
                        return Redirect("/");
                    }
                    else { return Redirect("/"); }
                }
            }
            TempData["Error"] = "Ошибка, данные введены неверно";
            return View();
        }
        [HttpGet("login")]
        public IActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(User account, string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            var listUser = Factory.GetAllProfileInformation(DatabaseConnection.GetAllProfileInformation());
            
            foreach (User us in listUser)
            {
                if (us.Email == account.Email && us.Password == account.Password)
                {
                    var claims = new List<Claim>();
                    claims.Add(new Claim("Id", us.Id.ToString()));
                    claims.Add(new Claim("Balance", us.Balance.ToString()));
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, us.Name));
                    //claims.Add(new Claim(ClaimTypes.Name, us.Id.ToString()));
                    //claims.Add(new Claim(ClaimTypes.Role, "Admin"));
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    // var t1 = claims[0].Value;
                    // var t2 = claims[1].Value;
                    await HttpContext.SignInAsync(claimsPrincipal);
                    if (returnUrl != null)
                    {
                        return Redirect(returnUrl);
                    }
                    else
                        return Redirect("/");
                    
                }
            }
            TempData["Error"] = "Ошибка, Логин или пароль введены неверно";
            return View("login");
        }
        [Authorize]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}
