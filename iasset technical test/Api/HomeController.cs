using iasset_technical_test.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Xml;

namespace iasset_technical_test.Api
{
    [RoutePrefix("api/Home")]
    public class HomeController : ApiController
    {
        private readonly IWeatherData _weatherData;
        public HomeController(IWeatherData weatherData)
        {
            _weatherData = weatherData;
        }
        [HttpGet]
        public List<string> GetCities(string country)
        {
            return _weatherData.GetCitiesData(country);
        }
    }
}