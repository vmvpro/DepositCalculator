namespace DepositCalculator.Client.FormMain
{
	partial class frmDepositCalculate
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblInitialAmount = new System.Windows.Forms.Label();
			this.txtInitialAmount = new System.Windows.Forms.TextBox();
			this.lblInterestRate = new System.Windows.Forms.Label();
			this.lblNumberOfMonth = new System.Windows.Forms.Label();
			this.cbxPaymentMethod = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.TotalResult = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblInterestRateValue = new System.Windows.Forms.Label();
			this.lblNumberOfMonthValue = new System.Windows.Forms.Label();
			this.trbNumberOfMonths = new System.Windows.Forms.TrackBar();
			this.trbInterestRate = new System.Windows.Forms.TrackBar();
			this.cbxCurrency = new System.Windows.Forms.ComboBox();
			this.btnWebCalculateAsync = new System.Windows.Forms.Button();
			this.btnCalculateAsync = new System.Windows.Forms.Button();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.lblTotalResult = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trbNumberOfMonths)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trbInterestRate)).BeginInit();
			this.SuspendLayout();
			// 
			// lblInitialAmount
			// 
			this.lblInitialAmount.AutoSize = true;
			this.lblInitialAmount.Location = new System.Drawing.Point(16, 38);
			this.lblInitialAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblInitialAmount.Name = "lblInitialAmount";
			this.lblInitialAmount.Size = new System.Drawing.Size(72, 13);
			this.lblInitialAmount.TabIndex = 0;
			this.lblInitialAmount.Text = "Initial amount:";
			// 
			// txtInitialAmount
			// 
			this.txtInitialAmount.Location = new System.Drawing.Point(109, 39);
			this.txtInitialAmount.Margin = new System.Windows.Forms.Padding(2);
			this.txtInitialAmount.Name = "txtInitialAmount";
			this.txtInitialAmount.Size = new System.Drawing.Size(181, 20);
			this.txtInitialAmount.TabIndex = 1;
			this.txtInitialAmount.Text = "10000";
			// 
			// lblInterestRate
			// 
			this.lblInterestRate.AutoSize = true;
			this.lblInterestRate.Location = new System.Drawing.Point(16, 84);
			this.lblInterestRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblInterestRate.Name = "lblInterestRate";
			this.lblInterestRate.Size = new System.Drawing.Size(66, 13);
			this.lblInterestRate.TabIndex = 2;
			this.lblInterestRate.Text = "Interest rate:";
			// 
			// lblNumberOfMonth
			// 
			this.lblNumberOfMonth.AutoSize = true;
			this.lblNumberOfMonth.Location = new System.Drawing.Point(16, 130);
			this.lblNumberOfMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNumberOfMonth.Name = "lblNumberOfMonth";
			this.lblNumberOfMonth.Size = new System.Drawing.Size(96, 13);
			this.lblNumberOfMonth.TabIndex = 4;
			this.lblNumberOfMonth.Text = "Number of months:";
			// 
			// cbxPaymentMethod
			// 
			this.cbxPaymentMethod.DisplayMember = "1";
			this.cbxPaymentMethod.FormattingEnabled = true;
			this.cbxPaymentMethod.Items.AddRange(new object[] {
            "Simple interest",
            "Daily capitalization",
            "Monthly capitalization"});
			this.cbxPaymentMethod.Location = new System.Drawing.Point(109, 170);
			this.cbxPaymentMethod.Margin = new System.Windows.Forms.Padding(2);
			this.cbxPaymentMethod.Name = "cbxPaymentMethod";
			this.cbxPaymentMethod.Size = new System.Drawing.Size(235, 21);
			this.cbxPaymentMethod.TabIndex = 6;
			this.cbxPaymentMethod.ValueMember = "1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 171);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Payment method:";
			// 
			// TotalResult
			// 
			this.TotalResult.AutoSize = true;
			this.TotalResult.Location = new System.Drawing.Point(29, 322);
			this.TotalResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TotalResult.Name = "TotalResult";
			this.TotalResult.Size = new System.Drawing.Size(62, 13);
			this.TotalResult.TabIndex = 7;
			this.TotalResult.Text = "Total result:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblInterestRateValue);
			this.groupBox1.Controls.Add(this.lblNumberOfMonthValue);
			this.groupBox1.Controls.Add(this.trbNumberOfMonths);
			this.groupBox1.Controls.Add(this.trbInterestRate);
			this.groupBox1.Controls.Add(this.cbxCurrency);
			this.groupBox1.Controls.Add(this.btnWebCalculateAsync);
			this.groupBox1.Controls.Add(this.btnCalculateAsync);
			this.groupBox1.Controls.Add(this.btnCalculate);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cbxPaymentMethod);
			this.groupBox1.Controls.Add(this.lblNumberOfMonth);
			this.groupBox1.Controls.Add(this.lblInterestRate);
			this.groupBox1.Controls.Add(this.txtInitialAmount);
			this.groupBox1.Controls.Add(this.lblInitialAmount);
			this.groupBox1.Location = new System.Drawing.Point(32, 32);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(363, 269);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input data";
			// 
			// lblInterestRateValue
			// 
			this.lblInterestRateValue.AutoSize = true;
			this.lblInterestRateValue.Location = new System.Drawing.Point(109, 84);
			this.lblInterestRateValue.Name = "lblInterestRateValue";
			this.lblInterestRateValue.Size = new System.Drawing.Size(25, 13);
			this.lblInterestRateValue.TabIndex = 16;
			this.lblInterestRateValue.Text = "___";
			// 
			// lblNumberOfMonthValue
			// 
			this.lblNumberOfMonthValue.AutoSize = true;
			this.lblNumberOfMonthValue.Location = new System.Drawing.Point(109, 130);
			this.lblNumberOfMonthValue.Name = "lblNumberOfMonthValue";
			this.lblNumberOfMonthValue.Size = new System.Drawing.Size(25, 13);
			this.lblNumberOfMonthValue.TabIndex = 16;
			this.lblNumberOfMonthValue.Text = "___";
			// 
			// trbNumberOfMonths
			// 
			this.trbNumberOfMonths.Location = new System.Drawing.Point(155, 123);
			this.trbNumberOfMonths.Maximum = 12;
			this.trbNumberOfMonths.Minimum = 1;
			this.trbNumberOfMonths.Name = "trbNumberOfMonths";
			this.trbNumberOfMonths.Size = new System.Drawing.Size(189, 45);
			this.trbNumberOfMonths.TabIndex = 15;
			this.trbNumberOfMonths.Value = 1;
			// 
			// trbInterestRate
			// 
			this.trbInterestRate.Location = new System.Drawing.Point(155, 84);
			this.trbInterestRate.Maximum = 14;
			this.trbInterestRate.Minimum = 6;
			this.trbInterestRate.Name = "trbInterestRate";
			this.trbInterestRate.Size = new System.Drawing.Size(189, 45);
			this.trbInterestRate.TabIndex = 14;
			this.trbInterestRate.Value = 6;
			// 
			// cbxCurrency
			// 
			this.cbxCurrency.FormattingEnabled = true;
			this.cbxCurrency.Location = new System.Drawing.Point(295, 38);
			this.cbxCurrency.Name = "cbxCurrency";
			this.cbxCurrency.Size = new System.Drawing.Size(49, 21);
			this.cbxCurrency.TabIndex = 13;
			this.cbxCurrency.Text = "UA";
			// 
			// btnWebCalculateAsync
			// 
			this.btnWebCalculateAsync.Location = new System.Drawing.Point(206, 239);
			this.btnWebCalculateAsync.Name = "btnWebCalculateAsync";
			this.btnWebCalculateAsync.Size = new System.Drawing.Size(75, 23);
			this.btnWebCalculateAsync.TabIndex = 12;
			this.btnWebCalculateAsync.Text = "web_async";
			this.btnWebCalculateAsync.UseVisualStyleBackColor = true;
			this.btnWebCalculateAsync.Click += new System.EventHandler(this.btnWebCalculateAsync_Click);
			// 
			// btnCalculateAsync
			// 
			this.btnCalculateAsync.Location = new System.Drawing.Point(109, 238);
			this.btnCalculateAsync.Margin = new System.Windows.Forms.Padding(2);
			this.btnCalculateAsync.Name = "btnCalculateAsync";
			this.btnCalculateAsync.Size = new System.Drawing.Size(92, 24);
			this.btnCalculateAsync.TabIndex = 11;
			this.btnCalculateAsync.Text = "CalculateAsync";
			this.btnCalculateAsync.UseVisualStyleBackColor = true;
			this.btnCalculateAsync.Click += new System.EventHandler(this.btnCalculateAsync_Click);
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(9, 238);
			this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(96, 24);
			this.btnCalculate.TabIndex = 8;
			this.btnCalculate.Text = "Calculate (local)";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// lblTotalResult
			// 
			this.lblTotalResult.AutoSize = true;
			this.lblTotalResult.Location = new System.Drawing.Point(108, 322);
			this.lblTotalResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTotalResult.Name = "lblTotalResult";
			this.lblTotalResult.Size = new System.Drawing.Size(22, 13);
			this.lblTotalResult.TabIndex = 9;
			this.lblTotalResult.Text = "0 ₴";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(209, 405);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 15);
			this.label1.TabIndex = 10;
			this.label1.Text = "©vmvpro 2023☺";
			// 
			// frmDepositCalculate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(420, 430);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTotalResult);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.TotalResult);
			this.Name = "frmDepositCalculate";
			this.Text = "Deposit Calculate";
			this.Load += new System.EventHandler(this.frmDepositCalculate_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trbNumberOfMonths)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trbInterestRate)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label lblInitialAmount;
		public System.Windows.Forms.TextBox txtInitialAmount;
		public System.Windows.Forms.Label lblInterestRate;
		public System.Windows.Forms.Label lblNumberOfMonth;
		public System.Windows.Forms.ComboBox cbxPaymentMethod;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.Label TotalResult;
		public System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.Button btnCalculate;
		public System.Windows.Forms.Label lblTotalResult;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button btnCalculateAsync;
		public Button btnWebCalculateAsync;
		public Label lblNumberOfMonthValue;
		public TrackBar trbNumberOfMonths;
		public TrackBar trbInterestRate;
		public ComboBox cbxCurrency;
		public Label lblInterestRateValue;
	}
}