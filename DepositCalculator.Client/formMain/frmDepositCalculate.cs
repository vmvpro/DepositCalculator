using DepositCalculator.Core.Domain;
using DepositCalculator.Core.Domain.Strategy;
using DepositCalculator.Core.Enums;
using DepositCalculator.Core.Models;
using FluentValidation.Results;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Text.Json;
using System.Text;
using DepositCalculator.Core.Models.Response;

namespace DepositCalculator.Client.FormMain
{
	public partial class frmDepositCalculate : Form
	{
		private BindingCollections currencySource;

		public frmDepositCalculate()
		{
			InitializeComponent();
		}

		private void frmDepositCalculate_Load(object sender, EventArgs e)
		{
			DataBindingToFormControls();
		}

		private void DataBindingToFormControls()
		{
			lblInterestRateValue.DataBindings.Add(
				   new Binding(nameof(lblInterestRateValue.Text), 
				   trbInterestRate, 
				   nameof(trbInterestRate.Value)));

			lblNumberOfMonthValue.DataBindings.Add(
				new Binding(nameof(lblNumberOfMonthValue.Text), 
				trbNumberOfMonths, 
				nameof(trbNumberOfMonths.Value)));

			currencySource = new BindingCollections()
			{
				Сurrencies = new List<Currency>()
				{
					new Currency(){ Name = "Ukraine", ShortName = "UA", Interest = 1, Sign = "₴", Course = 1},
					new Currency(){ Name = "Euro",  ShortName = "EUR", Interest = 100, Sign = "€", Course = 41.1 },
					new Currency(){ Name = "USA", ShortName = "USD", Interest = 100, Sign = "$", Course = 37.7},
				}
			};

			cbxCurrency.DataSource = currencySource.Сurrencies;
			cbxCurrency.DisplayMember = nameof(Currency.ShortName);
			cbxCurrency.ValueMember = nameof(Currency.Course);

			cbxCurrency.SelectedIndexChanged += btnCalculate_Click;

			cbxPaymentMethod.SelectedIndex = (int)CalculationAlgorithm.DailyCapitalization;

		}

		private string GetTotalResultToStringWithSign(double totalResult)
		{
			var result = totalResult / (double)cbxCurrency.SelectedValue;

			var index = cbxCurrency.SelectedIndex;
			var sign = currencySource.Сurrencies[index].Sign;

			return result.ToString($"### ### ##0.00 {sign}");
		}

		private DepositModel GetDepositModelFromForm() => new DepositModel()
		{
			InitialAmount = Convert.ToDouble(txtInitialAmount.Text),
			InterestRate = Convert.ToDouble(trbInterestRate.Value),
			NumberOfMonths = Convert.ToInt32(trbNumberOfMonths.Value),

			Capitalization = (CalculationAlgorithm)cbxPaymentMethod.SelectedIndex
		};

		#region btnWebCalculateAsync

		private async void btnWebCalculateAsync_Click(object sender, EventArgs e)
		{
			var totalResult = await Buttons.CalculateAsync(GetDepositModelFromForm());

			lblTotalResult.Text = totalResult != (double)0.0 ? GetTotalResultToStringWithSign(totalResult) : "Error";
		}

		#endregion

		#region btnCalculateAsync

		private async void btnCalculateAsync_Click(object sender, EventArgs e)
		{
			var totalResult = await Buttons.CalculateAsync(GetDepositModelFromForm());

			lblTotalResult.Text = totalResult != (double)0.0 ? GetTotalResultToStringWithSign(totalResult) : "Error";
		}

		#endregion

		#region btnCalculate

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			var depositModel = GetDepositModelFromForm();

			DepositModelValidator validator = new DepositModelValidator();
			ValidationResult results = validator.Validate(depositModel);

			if (!results.IsValid)
			{
				foreach (var failure in results.Errors)
				{
					MessageBox.Show("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
				}

				lblTotalResult.Text = "Error";

				return;
			}

			lblTotalResult.Text = GetTotalResultToStringWithSign(CalculationDefinition(depositModel));

		}



		private double CalculationDefinition(DepositModel depositModel)
		{

			// Simple Interest
			if (depositModel.Capitalization == CalculationAlgorithm.SimpleInterest)
			{
				// P is the initial deposit amount
				double P = depositModel.InitialAmount;

				// I - annual rate
				double I = depositModel.InterestRate;

				// K is the number of days in a year - 365 or 366
				double K = depositModel.NumberOfDaysInYear;

				// T - number of deposit days
				var T = (depositModel.DateCloseDeposit - depositModel.DateOpenDeposit.AddDays(1)).Days;

				// General calculation formula
				// Result is the amount at the end of the term,
				// including the opening amount and accrued interest

				return P + ((P * I * T / K) / 100);

			}

			//Daily capitalization
			if (depositModel.Capitalization == CalculationAlgorithm.DailyCapitalization)
			{
				// P is the initial deposit amount
				double P = depositModel.InitialAmount;

				// N is the annual interest rate divided by 100
				double N = depositModel.InterestRate / 100;

				// K is the number of days in a year - 365 or 366
				double K = depositModel.NumberOfDaysInYear;

				// T is the investment period in days.
				var T = (depositModel.DateCloseDeposit - depositModel.DateOpenDeposit.AddDays(1)).Days;

				// General calculation formula
				// D is the amount at the end of the term, including the opening amount and accrued interest
				return P * Math.Pow(1 + N / K, T);

			}

			//Monthly capitalization
			if (depositModel.Capitalization == CalculationAlgorithm.MonthlyCapitalization)
			{
				//P — the initial deposit,
				double P = depositModel.InitialAmount;

				//N — the annual rate divided by 100,
				double N = depositModel.InterestRate / 100;

				// T — the term of the contract in months
				var T = depositModel.NumberOfMonths;

				// General calculation formula

				return P * Math.Pow(1 + N / 12, T);
			}

			return (double) 0.0;
		}

		#endregion

	}
}