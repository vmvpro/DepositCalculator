namespace WinFormsAppDotNet6
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
			this.label3 = new System.Windows.Forms.Label();
			this.cbxPaymentMethod = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.TotalResult = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCalculateAsync = new System.Windows.Forms.Button();
			this.txtInterestRate = new System.Windows.Forms.NumericUpDown();
			this.txtNumberOfMonths = new System.Windows.Forms.NumericUpDown();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.lblTotalResult = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtInterestRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumberOfMonths)).BeginInit();
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
			this.txtInitialAmount.Location = new System.Drawing.Point(109, 36);
			this.txtInitialAmount.Margin = new System.Windows.Forms.Padding(2);
			this.txtInitialAmount.Name = "txtInitialAmount";
			this.txtInitialAmount.Size = new System.Drawing.Size(144, 20);
			this.txtInitialAmount.TabIndex = 1;
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 130);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Number of months:";
			// 
			// cbxPaymentMethod
			// 
			this.cbxPaymentMethod.FormattingEnabled = true;
			this.cbxPaymentMethod.Items.AddRange(new object[] {
            "Simple interest",
            "Daily capitalization",
            "Monthly capitalization"});
			this.cbxPaymentMethod.Location = new System.Drawing.Point(109, 168);
			this.cbxPaymentMethod.Margin = new System.Windows.Forms.Padding(2);
			this.cbxPaymentMethod.Name = "cbxPaymentMethod";
			this.cbxPaymentMethod.Size = new System.Drawing.Size(144, 21);
			this.cbxPaymentMethod.TabIndex = 6;
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
			this.groupBox1.Controls.Add(this.btnCalculateAsync);
			this.groupBox1.Controls.Add(this.txtInterestRate);
			this.groupBox1.Controls.Add(this.txtNumberOfMonths);
			this.groupBox1.Controls.Add(this.btnCalculate);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cbxPaymentMethod);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.lblInterestRate);
			this.groupBox1.Controls.Add(this.txtInitialAmount);
			this.groupBox1.Controls.Add(this.lblInitialAmount);
			this.groupBox1.Location = new System.Drawing.Point(32, 32);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(276, 269);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input data";
			// 
			// btnCalculateAsync
			// 
			this.btnCalculateAsync.Location = new System.Drawing.Point(180, 238);
			this.btnCalculateAsync.Margin = new System.Windows.Forms.Padding(2);
			this.btnCalculateAsync.Name = "btnCalculateAsync";
			this.btnCalculateAsync.Size = new System.Drawing.Size(92, 24);
			this.btnCalculateAsync.TabIndex = 11;
			this.btnCalculateAsync.Text = "CalculateAsync";
			this.btnCalculateAsync.UseVisualStyleBackColor = true;
			this.btnCalculateAsync.Click += new System.EventHandler(this.btnCalculateAsync_Click);
			// 
			// txtInterestRate
			// 
			this.txtInterestRate.Location = new System.Drawing.Point(109, 82);
			this.txtInterestRate.Margin = new System.Windows.Forms.Padding(2);
			this.txtInterestRate.Name = "txtInterestRate";
			this.txtInterestRate.Size = new System.Drawing.Size(144, 20);
			this.txtInterestRate.TabIndex = 10;
			// 
			// txtNumberOfMonths
			// 
			this.txtNumberOfMonths.Location = new System.Drawing.Point(109, 128);
			this.txtNumberOfMonths.Margin = new System.Windows.Forms.Padding(2);
			this.txtNumberOfMonths.Name = "txtNumberOfMonths";
			this.txtNumberOfMonths.Size = new System.Drawing.Size(144, 20);
			this.txtNumberOfMonths.TabIndex = 10;
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(103, 238);
			this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(73, 24);
			this.btnCalculate.TabIndex = 8;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// lblTotalResult
			// 
			this.lblTotalResult.AutoSize = true;
			this.lblTotalResult.Location = new System.Drawing.Point(108, 322);
			this.lblTotalResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTotalResult.Name = "lblTotalResult";
			this.lblTotalResult.Size = new System.Drawing.Size(36, 13);
			this.lblTotalResult.TabIndex = 9;
			this.lblTotalResult.Text = "0 грн.";
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 430);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTotalResult);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.TotalResult);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.frmDepositCalculate_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtInterestRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumberOfMonths)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblInitialAmount;
		private System.Windows.Forms.TextBox txtInitialAmount;
		private System.Windows.Forms.Label lblInterestRate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbxPaymentMethod;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label TotalResult;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.NumericUpDown txtInterestRate;
		private System.Windows.Forms.NumericUpDown txtNumberOfMonths;
		private System.Windows.Forms.Label lblTotalResult;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCalculateAsync;


	}
}