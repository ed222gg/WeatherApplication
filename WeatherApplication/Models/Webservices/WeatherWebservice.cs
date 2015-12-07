using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WeatherApplication.Models.Webservices
{
    public class WeatherWebservice
    {
        public IEnumerable<Weather> ByCityId(string id)
        {
            string rawJson;

            using (StreamReader reader = new StreamReader(HttpContext.Current.Server.MapPath("~/App_Data/weather_14.json")))
            {
                rawJson = reader.ReadToEnd();
            }
            var j = JArray.Parse(rawJson);
            var j2 = JArray.Parse(rawJson).Select(w => new Weather(w));
            return JArray.Parse(rawJson).Select(w => new Weather(w)).ToList();
        }
    }
}