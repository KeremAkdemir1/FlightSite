using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VacationSite3.Repositories;

namespace VacationSite3.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult CountryMainPage()
        {
            CountryRepository cr = new CountryRepository();
            return View(cr.TList());
        }
    }
}
