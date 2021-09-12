
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VacationSite3.Models.Data;
using VacationSite3.Repositories;

namespace VacationSite3.Controllers
{
    public class BlogController : Controller
    {
        CommentRepository cr = new CommentRepository();
        public IActionResult Index()
        {
            return View(cr.TList());
        }
        [HttpGet]
        public IActionResult AddComment()
        {
            return View(); 
        }
         [HttpPost]
        public IActionResult AddComment(Comments c)
        {
            if (!ModelState.IsValid)
            {
                return View("AddComment");
            }
            cr.TAdd(c);
            return RedirectToAction("Index");
        }
    }
}
