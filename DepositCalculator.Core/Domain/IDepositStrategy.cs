using DepositCalculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator.Core.Domain
{
	public interface IDepositStrategy
	{
		Task<double> ExecuteAsync(DepositModel depositModel);

	}
}
