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

        [HttpPost("/result")]
        public ActionResult Result()
        {
            string checkWord = Request.Form["word"];
            string given = Request.Form["phrase"];
            RepeatCounter myRepeatCounter = new RepeatCounter();
            myRepeatCounter.CountMatches(checkWord, given);
            return View("Result", myRepeatCounter);
        }
    }
}
