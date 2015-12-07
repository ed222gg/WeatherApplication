using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherApplication.Models.Webservices;

namespace WeatherApplication.Controllers
{
    public class WeatherAppController : Controller
    {
        // GET: WeatherApp
        public ActionResult Index()
        {
            var webservice = new WeatherWebservice();
            var weather = webservice.ByCityId("1283240");

            return View(weather);
        }
    }
}