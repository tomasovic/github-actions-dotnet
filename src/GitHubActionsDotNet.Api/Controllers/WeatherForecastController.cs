namespace GitHubActionsDotNet.Api.Controllers;
using GitHubActionsDotNet.Api.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries =
    [
        "Ledeno",
        "Zaleđeno",
        "Prohladno",
        "Hladno",
        "Umereno",
        "Toplo",
        "Prijatno",
        "Vruće",
        "Ugušujuće",
        "Užareno"
    ];

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get() => Enumerable.Range(1, 5).Select(index => new WeatherForecast
    {
        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        TemperatureC = Random.Shared.Next(-20, 55),
        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    })
        .ToArray();
}
