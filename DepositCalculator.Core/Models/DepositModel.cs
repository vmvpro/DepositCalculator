using DepositCalculator.Core.Enums;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator.Core.Models
{
	public class DepositModel
	{
		public double Balance { get; set; }
		public double InitialAmount { get; set; }
		public double InterestRate { get; set; }
		public int NumberOfMonths { get; set; }

		public CalculationAlgorithm Capitalization { get; set; }

		public DateTime DateOpenDeposit { get; set; } = DateTime.Now;

		#region Properties for reading

		/// <summary>
		/// Number of days in a year
		/// </summary>
		public int NumberOfDaysInYear => Enumerable.Range(1, 12).Select(m => DateTime.DaysInMonth(DateOpenDeposit.Year, m)).Sum();

		public DateTime DateCloseDeposit => DateOpenDeposit.AddMonths(NumberOfMonths);

		#endregion


	}

	public class DepositModelValidator : AbstractValidator<DepositModel>
	{
		public DepositModelValidator()
		{
			RuleFor(x => x.InitialAmount).Must(x => x >= 100).WithMessage("The initial balance must be more than 100");
			RuleFor(x => x.NumberOfMonths).Must(x => x >= 1).WithMessage("The number of months must be more than 1");
		}
	}






}
