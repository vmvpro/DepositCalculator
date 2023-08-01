using DepositCalculator.Core.Domain;
using DepositCalculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator.Client.Buttons
{
	public partial class Buttons
	{
		public static async Task<string> WebCalculateAsync(DepositModel depositModel)
		{
			try
			{
				var response =
					await RestClient.PostAsyncToObject<double, DepositModel>(depositModel, "/calculate");

				var D = response.Result;

				return D.ToString("### ### ###.00 ₴");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				
				return "Error";
			}
		}
	}
}
