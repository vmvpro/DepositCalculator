using DepositCalculator.Core.Domain;
using DepositCalculator.Core.Domain.Strategy;
using DepositCalculator.Core.Enums;
using DepositCalculator.Core.Models;
using DepositCalculator.Core.Models.Response;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DepositCalculator.WebAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class DepositController : ControllerBase
	{
		private readonly ILogger<DepositController> _logger;

		public DepositController(ILogger<DepositController> logger)
		{
			_logger = logger;
		}

		[HttpGet(Name = "GetDeposit")]
		public async Task<Response<double>> Get()
		{
			var depositModel = new DepositModel
			{
				InitialAmount = 10000,
				InterestRate = 3,
				NumberOfMonths = 6,
				Capitalization = CalculationAlgorithm.DailyCapitalization,
			};

			var deposit = new Deposit(depositModel);

			deposit.Strategy = GetDepositStrategy(depositModel.Capitalization);

			var totalResult = await deposit.CalculateAsync();

			return Response<double>.Success(totalResult, HttpStatusCode.OK);

		}

		/// <summary>
		/// Calculate deposit
		/// </summary>
		/// <param name="taskDTO"></param>
		/// <returns></returns>
		[HttpPost]
		[Route("Calculate")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<Response<double>> CalculateAsync([FromBody] DepositModel depositModel)
		{
			var deposit = new Deposit(depositModel);

			try
			{
				if (!(await deposit.IsValid()))
				{
					throw new Exception(deposit.ErrorMessage);
				}

				deposit.Strategy = GetDepositStrategy(depositModel.Capitalization);

				var totalResult = await deposit.CalculateAsync();

				return Response<double>.Success(totalResult, HttpStatusCode.OK);
			}
			catch (Exception ex)
			{
				return Response<double>.Fail(ex.Message, HttpStatusCode.BadRequest);
			}
		}

		private IDepositStrategy GetDepositStrategy(CalculationAlgorithm calculationAlgorithm) =>
			calculationAlgorithm switch
			{
				CalculationAlgorithm.SimpleInterest => new SingleStrategy(),
				CalculationAlgorithm.DailyCapitalization => new DailyStrategy(),
				CalculationAlgorithm.MonthlyCapitalization => new MonthStrategy(),
				_ => new SingleStrategy()
			};



	}
}