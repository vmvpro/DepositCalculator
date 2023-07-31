using DepositCalculator.Core.Domain.Strategy;
using DepositCalculator.Core.Enums;
using DepositCalculator.Core.Models;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator.Core.Domain
{
	public class Deposit
	{
		IDepositStrategy _strategy;
		DepositModel _depositModel;

		public Deposit(DepositModel depositModel)
		{
			_depositModel = depositModel;
		}

		public Task<double> CalculateAsync()
		{
			if (Strategy == null)
			{
				return Task.FromResult((double)0);
			}

			return Strategy.ExecuteAsync(_depositModel);
		}

		public IDepositStrategy Strategy { private get; set; }

		public Task<bool> IsValid()
		{
			DepositModelValidator validator = new DepositModelValidator();
			ValidationResult results = validator.Validate(_depositModel);

			if (!results.IsValid)
			{
				foreach (var failure in results.Errors)
				{
					ErrorMessage = "Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage;
				}
				return Task.FromResult(false);
			}
			else
			{
				ErrorMessage = "OK";
				return Task.FromResult(true);
			}
		}

		public string ErrorMessage { get; private set; }

	}
}
