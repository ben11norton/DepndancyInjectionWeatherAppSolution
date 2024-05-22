In Main Program: 
using Services;
using ServiceContracts;
builder.Services.AddTransient<IWeatherService, WeatherService>

Project Directory Layout:
--Main Project (enable dependency for Model, Services, and ServiceContracts in reference manager)
----> remains the same 
--Models
----> model class placed outside main project
--------> enables both main project and services and serviceContract to have access to model
--Services (enable dependency for ServiceContracts and Models)
----> service class (WeatherService)
--ServiceContract (enable dependency for Models)
----> service contract class (IWeatherService)
