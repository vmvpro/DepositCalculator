using DepositCalculator.Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator.Client.Domain
{
	public interface IDepositStrategy
	{
		Task<double> ExecuteAsync(DepositModel depositModel);

	}
}
