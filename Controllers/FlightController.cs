using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VacationSite3.Repositories;
using X.PagedList;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VacationSite3.Controllers
{
    public class FlightController : Controller
    {
        FlightRepository fr = new FlightRepository();
        CountryRepository cr = new CountryRepository();
        [Authorize]
        public IActionResult Index(int page=1)
        {
            return View(fr.TList("Country").ToPagedList(page, 3));
        }
        [Authorize]
        public IActionResult GetCountry()
        {
            return View(cr.TList());
        }
    }
}
