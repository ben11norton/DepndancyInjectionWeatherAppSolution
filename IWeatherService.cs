using Models;

namespace ServiceContracts
{
    public interface IWeatherService
    {
        List<CityWeather> GetCityDetails();

        CityWeather? GetCityCode(string cityCode);
    }
}
