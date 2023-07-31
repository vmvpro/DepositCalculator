using DepositCalculator.ClientDotNet6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator.ClientDotNet6.Domain
{
	public interface IDepositStrategy
	{
		Task<double> ExecuteAsync(DepositModel depositModel);

	}
}
