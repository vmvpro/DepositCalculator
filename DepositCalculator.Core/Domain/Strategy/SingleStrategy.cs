﻿using DepositCalculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DepositCalculator.Core.Domain.Strategy
{
	public class SingleStrategy : IDepositStrategy
	{
		public async Task<double> ExecuteAsync(DepositModel depositModel)
		{
			// P is the initial deposit amount
			double P = depositModel.InitialAmount;

			// I - annual rate
			double I = depositModel.InterestRate;

			// K is the number of days in a year - 365 or 366
			double K = depositModel.NumberOfDaysInYear;

			// T - number of deposit days
			var T = (depositModel.DateCloseDeposit - depositModel.DateOpenDeposit.AddDays(1)).Days;

			// General calculation formula
			// Result is the amount at the end of the term, including the opening amount and accrued interest
			return await Task.Run(() => P + P * I * T / K / 100);

		}
	}
}
