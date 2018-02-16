using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCount.Models;

namespace WordCount.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
