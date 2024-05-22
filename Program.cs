using ServiceContracts;
using WeatherServices;
internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();

        // ading custom service to IoC container
        builder.Services.AddTransient<IWeatherService, WeatherService>();

        var app = builder.Build();
        app.UseStaticFiles();
        app.UseRouting();
        app.MapControllers();
        app.Run();
    }
}