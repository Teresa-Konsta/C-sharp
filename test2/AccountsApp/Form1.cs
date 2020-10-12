using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsApp
{
    public partial class frmAccounts : Form
    {
        private List<Account> accounts = new List<Account>();
        Account myAccount;

        public frmAccounts()
        {
            InitializeComponent();
        }

        private void rbtnChecking_CheckedChanged(object sender, EventArgs e)
        {
                txtDailyWithdrawLimit.Enabled = true;
                txtInterestRate.Enabled = false;
        }

        private void rbtnVisa_CheckedChanged(object sender, EventArgs e)
        {
                txtDailyWithdrawLimit.Enabled = false;
                txtInterestRate.Enabled = true;
        }

        public void ClearControls()
        {
            txtAccountNumber.Text = "";
            txtBalance.Text = "";
            txtClientName.Text = "";
            txtDailyWithdrawLimit.Text = "";
            txtInterestRate.Text = "";
            rbtnChecking.Checked = true;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnChecking.Checked)
                {
                    myAccount = new CheckingAccount(int.Parse(txtAccountNumber.Text), double.Parse(txtBalance.Text),
                    txtClientName.Text, double.Parse(txtDailyWithdrawLimit.Text));
                }
                else if(rbtnVisa.Checked)
                {
                    myAccount = new CheckingAccount(int.Parse(txtAccountNumber.Text), double.Parse(txtBalance.Text),
                    txtClientName.Text, double.Parse(txtInterestRate.Text));
                }
                accounts.Add(myAccount);
                ClearControls();
                MessageBox.Show($"Total number of accounts: {accounts.Count}");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            try
            {
                ClearControls();
                myAccount = null;

                foreach (Account anotherAccount in accounts)
                {
                    if (anotherAccount.Number.ToString() == txtSearchAccountInput.Text.ToString())
                        myAccount = anotherAccount;
                }

                txtAccountNumber.Text = myAccount.Number.ToString();
                txtBalance.Text = myAccount.Balance.ToString();
                txtClientName.Text = myAccount.ClientName;

                if(myAccount.GetType() == typeof(CheckingAccount))
                {
                    txtDailyWithdrawLimit.Text = ((CheckingAccount)myAccount).WithdrawLimit.ToString();
                }
                else if(myAccount.GetType() == typeof(VisaAccount))
                {
                    txtInterestRate.Text = ((VisaAccount)myAccount).InterestRate.ToString();
                }
            }
            catch (Exception)
            {
                ClearControls();
                MessageBox.Show("Account not found!");
            }
        }
    }
}
