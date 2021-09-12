using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using VacationSite3.Models.Data;
using VacationSite3.Repositories;

namespace VacationSite3.Controllers
{
    public class HomeController : Controller
    {
        FlightRepository fr = new FlightRepository();
        CountryRepository cr = new CountryRepository();
        Context c = new Context();
        [HttpGet]
        public IActionResult MainPage()
        {
            return View(fr.TList("Country"));
        }
        [Authorize]
        [HttpGet]
        public IActionResult AddFlight()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFlight(Flights f)
        {
            if (!ModelState.IsValid)
            {
                return View("AddFlight");
            }
            fr.TAdd(f);

           return RedirectToAction("MainPage");
            
        }
        [Authorize]
        [HttpGet]
        public IActionResult AddCountry()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddCountry(Countries c)
        {
            if (!ModelState.IsValid)
            {
                return View("AddCountry");
            }
            cr.TAdd(c);
            return RedirectToAction("MainPage");
        }
        [Authorize]
        public IActionResult DeleteFlight(int id)
        {
            fr.TDelete(new Flights { FlightId = id });
            return RedirectToAction("MainPage");
        }
        [HttpPost]
        public IActionResult UpdateFlight(Flights f)
        {
           var x= fr.TGetById(f.FlightId);
            x.FlightName = f.FlightName;
            x.FlightTime = f.FlightTime;
            x.FlightPrice = f.FlightPrice;
            x.FlightsPilot = f.FlightsPilot;
            x.CountryId = f.CountryId;
            fr.TUpdate(x);
            c.SaveChanges();
            return RedirectToAction("MainPage");
        }
        [Authorize]
        [HttpGet]
        public IActionResult UpdateFlight()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> Login(Accounts p)
        {
            var bilgiler = c.Accounts.FirstOrDefault(x => x.AccountName == p.AccountName && x.AccountPass == p.AccountPass);
            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.AccountName)};
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("MainPage","Home");
            }
            return View();
        }
        public IActionResult Statistics()
        {
            using (Context c = new Context())
            {
                var deger1 = c.Flight.Count();
                ViewBag.d1 = deger1;


                var deger2 = c.Country.Count();
                ViewBag.d2 = deger2;

                var deger3 = c.Flight.Sum(x=>x.FlightPrice);
                ViewBag.d3 = deger3;

                return View();
            }

        }
    }
}
