using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherApplication.Models
{
    public class Weather
    {
         
        public string Name { get; set; }
        public string Description { get; set;  }

        public string Id { get; set; }

        public Weather(JToken weatherAppToken)
        {
            Name = (weatherAppToken["city"]["name"]).ToString();
            Id = (weatherAppToken["city"]["id"]).ToString();
         
        }
    }
}