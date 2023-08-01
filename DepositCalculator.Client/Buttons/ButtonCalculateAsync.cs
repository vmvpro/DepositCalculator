using DepositCalculator.Core.Domain;
using DepositCalculator.Core.Domain.Strategy;
using DepositCalculator.Core.Enums;
using DepositCalculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator.Client.Buttons
{
	public partial class Buttons
	{
		public static async Task<string> CalculateAsync(DepositModel depositModel)
		{
			var deposit = new Deposit(depositModel);

			if (!await deposit.IsValid())
			{
				MessageBox.Show(deposit.ErrorMessage);

				return "Error";
			}

			deposit.Strategy = GetDepositStrategy(depositModel.Capitalization);

			var totalResult = await deposit.CalculateAsync();

			return totalResult.ToString("### ### ###.00 ₴");
		}

		private static IDepositStrategy GetDepositStrategy(CalculationAlgorithm calculationAlgorithm) =>
			calculationAlgorithm switch
			{
				CalculationAlgorithm.SimpleInterest => new SingleStrategy(),
				CalculationAlgorithm.DailyCapitalization => new DailyStrategy(),
				CalculationAlgorithm.MonthlyCapitalization => new MonthStrategy(),
				_ => new SingleStrategy()
			};
	}
}
