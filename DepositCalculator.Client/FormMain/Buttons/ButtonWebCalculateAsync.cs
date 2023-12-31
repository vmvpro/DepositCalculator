﻿using DepositCalculator.Core.Domain;
using DepositCalculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator.Client.FormMain
{
	public partial class Buttons
	{
		public static async Task<double> WebCalculateAsync(DepositModel depositModel)
		{
			try
			{
				var response =
					await RestClient.PostAsyncToObject<double, DepositModel>(depositModel, "/calculate");

				var D = response.Result;

				return D;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

				return (double)0.0; //"Error";
			}
		}
	}
}
