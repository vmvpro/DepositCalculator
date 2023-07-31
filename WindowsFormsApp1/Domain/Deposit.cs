using DepositCalculator.Client.Enums;
using DepositCalculator.Client.Model;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepositCalculator.Client.Domain
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

		public bool IsValid()
		{
			DepositModelValidator validator = new DepositModelValidator();
			ValidationResult results = validator.Validate(_depositModel);

			if (!results.IsValid)
			{
				foreach (var failure in results.Errors)
				{
					ErrorMessage = "Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage;
				}
				return false;
			}
			else
			{
				ErrorMessage = "OK";
				return true;
			}
		}

		public string ErrorMessage { get; private set; }

	}
}
