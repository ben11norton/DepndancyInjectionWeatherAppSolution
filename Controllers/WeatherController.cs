using Microsoft.AspNetCore.Mvc;
using WeatherServices;
using ServiceContracts;
using Models;

namespace WeatherAppDependancies.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [Route("/")]
        public IActionResult Index()
        {
            try
            {
                List<CityWeather> city = _weatherService.GetCityDetails();
                return View(city);
            }
            catch(Exception e1)
            {
                return Content($"{e1.Message}");
            }
            
        }

        [Route("/weather/{cityCode?}")]
        public IActionResult Details(string cityCode)
        {
            try
            {
                if (string.IsNullOrEmpty(cityCode))
                {
                    return View();
                }

                CityWeather? cityDetails = _weatherService.GetCityCode(cityCode);
                return View(cityDetails);
            }
            catch(Exception e2)
            {
                return Content($"{e2.Message}");
            }
        }
    }
}
