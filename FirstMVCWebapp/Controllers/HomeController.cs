using FirstMVCWebapp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FirstMVCWebapp.Services;
using Microsoft.AspNetCore.Http;

namespace FirstMVCWebapp.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IFizzBuzzService fizzBuzzService;
        public HomeController(IFizzBuzzService fizzBuzzService)
        {
            this.fizzBuzzService = fizzBuzzService;
        }

        public IActionResult Index()
        {
            var results = new List<string>();
            ViewBag.Results = results;
            return View("Index");
        }

      

        public IActionResult ProcessArray(string numbers)
    {
        var resultslist = new List<(string number, string result)>();
        var numberArray = numbers.Split(',');

        foreach (var number in numberArray)
        {
                var result = fizzBuzzService.GetResult(number);
                resultslist.Add((number.ToString(), result));
        }

        ViewBag.NumberResultPairs = resultslist;
        return View("Index");
    }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}