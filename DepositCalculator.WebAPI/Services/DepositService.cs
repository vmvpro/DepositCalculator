using DepositCalculator.Core.Domain;

namespace DepositCalculator.WebAPI.Services
{
	public class DepositService
	{
		public readonly Deposit _deposit;

		public DepositService(Deposit deposit)
		{
			_deposit = deposit;
		}

		public async Task<double> CalculateAsync()
		{
			return await _deposit.CalculateAsync();
		}

		public async Task<bool> IsValid()
		{
			if ((await _deposit.IsValid()))
				throw new Exception(_deposit.ErrorMessage);

			return true;
		}
	}
}
