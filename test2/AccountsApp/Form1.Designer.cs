namespace AccountsApp
{
    partial class frmAccounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAccountDetails = new System.Windows.Forms.GroupBox();
            this.grpTypeOfAccount = new System.Windows.Forms.GroupBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.rbtnChecking = new System.Windows.Forms.RadioButton();
            this.rbtnVisa = new System.Windows.Forms.RadioButton();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtDailyWithdrawLimit = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblDailyWithdrawLimit = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblAccountNumberSearch = new System.Windows.Forms.Label();
            this.txtSearchAccountInput = new System.Windows.Forms.TextBox();
            this.btnSearchAccount = new System.Windows.Forms.Button();
            this.grpAccountDetails.SuspendLayout();
            this.grpTypeOfAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccountDetails
            // 
            this.grpAccountDetails.Controls.Add(this.lblInterestRate);
            this.grpAccountDetails.Controls.Add(this.lblDailyWithdrawLimit);
            this.grpAccountDetails.Controls.Add(this.lblBalance);
            this.grpAccountDetails.Controls.Add(this.lblClientName);
            this.grpAccountDetails.Controls.Add(this.lblAccountNumber);
            this.grpAccountDetails.Controls.Add(this.txtInterestRate);
            this.grpAccountDetails.Controls.Add(this.txtDailyWithdrawLimit);
            this.grpAccountDetails.Controls.Add(this.txtBalance);
            this.grpAccountDetails.Controls.Add(this.txtClientName);
            this.grpAccountDetails.Controls.Add(this.txtAccountNumber);
            this.grpAccountDetails.Controls.Add(this.grpTypeOfAccount);
            this.grpAccountDetails.Location = new System.Drawing.Point(0, 78);
            this.grpAccountDetails.Name = "grpAccountDetails";
            this.grpAccountDetails.Size = new System.Drawing.Size(866, 396);
            this.grpAccountDetails.TabIndex = 0;
            this.grpAccountDetails.TabStop = false;
            this.grpAccountDetails.Text = "Account Details";
            // 
            // grpTypeOfAccount
            // 
            this.grpTypeOfAccount.Controls.Add(this.rbtnVisa);
            this.grpTypeOfAccount.Controls.Add(this.rbtnChecking);
            this.grpTypeOfAccount.Location = new System.Drawing.Point(660, 21);
            this.grpTypeOfAccount.Name = "grpTypeOfAccount";
            this.grpTypeOfAccount.Size = new System.Drawing.Size(200, 144);
            this.grpTypeOfAccount.TabIndex = 0;
            this.grpTypeOfAccount.TabStop = false;
            this.grpTypeOfAccount.Text = "Type of Account";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(691, 500);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(169, 38);
            this.btnCreateAccount.TabIndex = 1;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // rbtnChecking
            // 
            this.rbtnChecking.AutoSize = true;
            this.rbtnChecking.Location = new System.Drawing.Point(31, 41);
            this.rbtnChecking.Name = "rbtnChecking";
            this.rbtnChecking.Size = new System.Drawing.Size(87, 21);
            this.rbtnChecking.TabIndex = 2;
            this.rbtnChecking.TabStop = true;
            this.rbtnChecking.Text = "Checking";
            this.rbtnChecking.UseVisualStyleBackColor = true;
            this.rbtnChecking.CheckedChanged += new System.EventHandler(this.rbtnChecking_CheckedChanged);
            // 
            // rbtnVisa
            // 
            this.rbtnVisa.AutoSize = true;
            this.rbtnVisa.Location = new System.Drawing.Point(31, 89);
            this.rbtnVisa.Name = "rbtnVisa";
            this.rbtnVisa.Size = new System.Drawing.Size(56, 21);
            this.rbtnVisa.TabIndex = 3;
            this.rbtnVisa.TabStop = true;
            this.rbtnVisa.Text = "Visa";
            this.rbtnVisa.UseVisualStyleBackColor = true;
            this.rbtnVisa.CheckedChanged += new System.EventHandler(this.rbtnVisa_CheckedChanged);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(222, 62);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(152, 22);
            this.txtAccountNumber.TabIndex = 1;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(222, 127);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(314, 22);
            this.txtClientName.TabIndex = 2;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(222, 190);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 22);
            this.txtBalance.TabIndex = 3;
            // 
            // txtDailyWithdrawLimit
            // 
            this.txtDailyWithdrawLimit.Location = new System.Drawing.Point(222, 257);
            this.txtDailyWithdrawLimit.Name = "txtDailyWithdrawLimit";
            this.txtDailyWithdrawLimit.Size = new System.Drawing.Size(100, 22);
            this.txtDailyWithdrawLimit.TabIndex = 4;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(222, 325);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 22);
            this.txtInterestRate.TabIndex = 5;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(76, 62);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(117, 17);
            this.lblAccountNumber.TabIndex = 6;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(105, 127);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(88, 17);
            this.lblClientName.TabIndex = 7;
            this.lblClientName.Text = "Client Name:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(130, 195);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(63, 17);
            this.lblBalance.TabIndex = 8;
            this.lblBalance.Text = "Balance:";
            // 
            // lblDailyWithdrawLimit
            // 
            this.lblDailyWithdrawLimit.AutoSize = true;
            this.lblDailyWithdrawLimit.Location = new System.Drawing.Point(55, 261);
            this.lblDailyWithdrawLimit.Name = "lblDailyWithdrawLimit";
            this.lblDailyWithdrawLimit.Size = new System.Drawing.Size(138, 17);
            this.lblDailyWithdrawLimit.TabIndex = 9;
            this.lblDailyWithdrawLimit.Text = "Daily Withdraw Limit:";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(100, 328);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(93, 17);
            this.lblInterestRate.TabIndex = 10;
            this.lblInterestRate.Text = "Interest Rate:";
            // 
            // lblAccountNumberSearch
            // 
            this.lblAccountNumberSearch.AutoSize = true;
            this.lblAccountNumberSearch.Location = new System.Drawing.Point(219, 35);
            this.lblAccountNumberSearch.Name = "lblAccountNumberSearch";
            this.lblAccountNumberSearch.Size = new System.Drawing.Size(184, 17);
            this.lblAccountNumberSearch.TabIndex = 7;
            this.lblAccountNumberSearch.Text = "Enter your account number:";
            // 
            // txtSearchAccountInput
            // 
            this.txtSearchAccountInput.Location = new System.Drawing.Point(423, 30);
            this.txtSearchAccountInput.Name = "txtSearchAccountInput";
            this.txtSearchAccountInput.Size = new System.Drawing.Size(242, 22);
            this.txtSearchAccountInput.TabIndex = 8;
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.Location = new System.Drawing.Point(691, 26);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(130, 30);
            this.btnSearchAccount.TabIndex = 9;
            this.btnSearchAccount.Text = "Search";
            this.btnSearchAccount.UseVisualStyleBackColor = true;
            this.btnSearchAccount.Click += new System.EventHandler(this.btnSearchAccount_Click);
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 550);
            this.Controls.Add(this.btnSearchAccount);
            this.Controls.Add(this.txtSearchAccountInput);
            this.Controls.Add(this.lblAccountNumberSearch);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.grpAccountDetails);
            this.Name = "frmAccounts";
            this.Text = "Accounts";
            this.grpAccountDetails.ResumeLayout(false);
            this.grpAccountDetails.PerformLayout();
            this.grpTypeOfAccount.ResumeLayout(false);
            this.grpTypeOfAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccountDetails;
        private System.Windows.Forms.GroupBox grpTypeOfAccount;
        private System.Windows.Forms.RadioButton rbtnChecking;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.RadioButton rbtnVisa;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblDailyWithdrawLimit;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtDailyWithdrawLimit;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblAccountNumberSearch;
        private System.Windows.Forms.TextBox txtSearchAccountInput;
        private System.Windows.Forms.Button btnSearchAccount;
    }
}

