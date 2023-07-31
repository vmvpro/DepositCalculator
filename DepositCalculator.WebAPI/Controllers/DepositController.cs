using DepositCalculator.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepositCalculator.WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class DepositController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		private readonly ILogger<DepositController> _logger;

		public DepositController(ILogger<DepositController> logger)
		{
			_logger = logger;
		}

		[HttpGet(Name = "GetWeatherForecast")]
		public IEnumerable<WeatherForecast> Get()
		{
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateTime.Now.AddDays(index),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			})
			.ToArray();
		}

		/// <summary>
		/// Створення нової задачі для конкретного співробітника
		/// </summary>
		/// <param name="taskDTO"></param>
		/// <returns></returns>
		[HttpPost]
		[Route("employee/createTask")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<ActionResult> CalculateAsync([FromBody] DepositModel depositModel)
		{
			try
			{
				

				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}


	}
}