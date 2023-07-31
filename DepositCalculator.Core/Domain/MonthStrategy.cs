using DepositCalculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator.Core.Domain
{
	/// <summary>
	/// Monthly capitalization
	/// </summary>
	public class MonthStrategy : IDepositStrategy
	{
		public async Task<double> ExecuteAsync(DepositModel depositModel)
		{
			//P — the initial deposit,
			double P = depositModel.InitialAmount;

			//N — the annual rate divided by 100,
			double N = depositModel.InterestRate / 100;

			// T — the term of the contract in months
			var T = depositModel.NumberOfMonths;

			// General calculation formula
			// Result is, the amount of the deposit at the end of the term,
			// including the opening amount and accrued interest
			return await Task.Run(() => P * Math.Pow(1 + N / 12, T));

		}
	}
}
