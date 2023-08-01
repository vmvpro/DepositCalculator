using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator.Client
{
	public record Currency
	{
		public string Name { get; init; }

		public string ShortName { get; init; }

		public double Interest { get; init; }

		public string Sign { get; init; }

		public double Course { get; init; }


	}

	public class BindingCollections
	{
		public IList<Currency>? Сurrencies { get; set; }
	}

}
