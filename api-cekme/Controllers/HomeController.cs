using api_cekme.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace api_cekme.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            

            // DateTime now = DateTime.Now;
            string apiurl = "https://api.genelpara.com/embed/para-birimleri.json";

            WebClient client = new WebClient();
            var json = client.DownloadString(apiurl);

          
           
             kurmodel a = JsonConvert.DeserializeObject<kurmodel>(json);
            string usd = a.USD.alis;
            
            //ViewData["usd"] = usd;

            return View(a);
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