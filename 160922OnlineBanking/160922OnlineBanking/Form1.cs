﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160922OnlineBanking
{
    public partial class Form1 : Form
    {
        private System.Collections.ArrayList _customers;
        private System.Collections.ArrayList Transactions;
        public Form1()
        {
            InitializeComponent();
            _customers = new System.Collections.ArrayList();
            Transactions = new System.Collections.ArrayList();

            Customer c = new Customer() { FirstName = "Test", LastName = "Namn", PersonalID = 971118 };
            c.CreateAccount(1200, "Konto");
            _customers.Add(c);

            c = new Customer() { FirstName = "Daniel", LastName = "Lundgren", PersonalID = 2332 };
            c.CreateAccount(1000, "Daniels Konto");
            c.CreateAccount(2500, "Daniels andra konto");
            _customers.Add(c);

            DisplayCustomers();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxPersonType.SelectedIndex)
            {
                case 0:
                    ToggleButtons(true, true, true, true, true, false); 
                    listBox1.Enabled = true;
                    break;

                case 1:
                    ToggleButtons(true, true, false, false, false, true);
                    listBox1.Enabled = true;
                    break;

                default:
                    ToggleButtons(false, false, false, false, false, false);
                    listBox1.Enabled = false;
                    break;
            }
        }
        private void ToggleButtons(bool ToggleButtonCustomer, bool ToggleButtonAccount, bool ToggleButtonDeposit, bool ToggleButtonWithdraw, bool ToggleButtonBalance, bool ToggleButtonTransactions)
        {
            btnViewCustomer.Enabled = ToggleButtonCustomer;
            btnViewAccount.Enabled = ToggleButtonAccount;
            btnViewDeposit.Enabled = ToggleButtonDeposit;
            btnViewWithdraw.Enabled = ToggleButtonWithdraw;
            btnViewBalance.Enabled = ToggleButtonBalance;
            btnViewTransactions.Enabled = ToggleButtonTransactions;
        }

        private void TogglePanels(bool TogglePanelCustomer, bool TogglePanelAccount, bool TogglePanelDeposit, bool TogglePanelWithdraw, bool TogglePanelBalance, bool TogglePanelTransactions)
        {
            pnlCustomer.Visible = TogglePanelCustomer;
            pnlAccount.Visible = TogglePanelAccount;
            pnlDeposit.Visible = TogglePanelDeposit;
            pnlWithdraw.Visible = TogglePanelWithdraw;
            pnlBalance.Visible = TogglePanelBalance;
            pnlTransactions.Visible = TogglePanelTransactions;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            TogglePanels(true, false, false, false, false, false);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            TogglePanels(false, true, false, false, false, false);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, true, false, false, false);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, true, false, false);
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, false, true, false);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, false, false, true);
            lbxTransactions.Items.Clear();
            foreach (Transaction item in Transactions)
            {
                lbxTransactions.Items.Add(item);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txbFirstName.Text != string.Empty || txbLastName.Text != string.Empty || txbPersonalID.Text != string.Empty)
            {
                _customers.Add(new Customer() { FirstName = txbFirstName.Text, LastName = txbLastName.Text, PersonalID = Int32.Parse(txbPersonalID.Text) });
                DisplayCustomers();
                ClearTextBoxes();
            }

            else
            {
                MessageBox.Show("Var vänlig och fyll i formuläret!");
            }


        }

        private void DisplayCustomers()
        {
            listBox1.Items.Clear();
            foreach (Customer item in _customers)
            {
                listBox1.Items.Add(item);
            }

        }

        private void ClearTextBoxes() {
            txbFirstName.Clear();
            txbLastName.Clear();
            txbPersonalID.Clear();
            txbInitialDeposit.Clear();
            txbAccountName.Clear();
            txbDeposit.Clear();
        }

        private void DisplayAccounts(Customer c)
        {
            listBox2.Items.Clear();
            listBox2.DisplayMember = "AccountName";

            foreach (Account item in c.GetAccounts())
            {
                listBox2.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Customer c = (Customer)listBox1.SelectedItem;
                DisplayAccounts(c);
                lblBalance.Text = string.Empty;
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (txbAccountName.Text != string.Empty || txbInitialDeposit.Text != string.Empty)
            {
                Customer c = (Customer)listBox1.SelectedItem;
                if (listBox1.SelectedItem != null)
                {
                    c.CreateAccount(decimal.Parse(txbInitialDeposit.Text), txbAccountName.Text);
                    ClearTextBoxes();
                    DisplayAccounts(c);
                }

                else
                {
                    MessageBox.Show("Var vänlig och välj en kund!");
                }

                if (listBox1.SelectedItem != null && c.Error == true)
                {
                    MessageBox.Show("Du måste sätta in minst 1000 kronor för att skapa ett konto!");
                }
            }

            else
            {
                MessageBox.Show("Var vänlig och fyll i formuläret!");
            }
        }

        private void btnCancelCustomer_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, false, false, false);
        }

        private void btnCancelAccount_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, false, false, false);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                Account a = (Account)listBox2.SelectedItem;
                lblBalance.Text = string.Format("{0}", a.Balance);
            }

        }

        private void btnDeposit_Click_1(object sender, EventArgs e)
        {
            if (txbDeposit.Text != string.Empty)
            {
                if (listBox2.SelectedItem != null)
                {
                    Account a = (Account)listBox2.SelectedItem;
                    Customer c = (Customer)listBox1.SelectedItem;
                    a.Deposit(decimal.Parse(txbDeposit.Text));
                    lblBalance.Text = string.Format("{0}", a.Balance);
                    Transactions.Add(new Transaction() {CustomerName = c.FirstName, AccountName = a.AccountName, TransactionAmount = decimal.Parse(txbDeposit.Text), TransactionType = "satt in", TransactionWord = "i" });
                    ClearTextBoxes();
                    TogglePanels(false, false, false, false, true, false);
                }

            }

            else
            {
                MessageBox.Show("Var vänlig och ange ett värde!");
            }
        }

        private void btnWithdraw_Click_1(object sender, EventArgs e)
        {
            if (txbWithdraw.Text != string.Empty)
            {
                Account a = (Account)listBox2.SelectedItem;
                Customer c = (Customer)listBox1.SelectedItem;
                if (listBox2.SelectedItem != null)
                {
                    a.withdraw(decimal.Parse(txbWithdraw.Text));
                    lblBalance.Text = string.Format("{0}", a.Balance);
                    ClearTextBoxes();
                    TogglePanels(false, false, false, false, true, false);
                    if (a.Error == false)
                    {
                        Transactions.Add(new Transaction() { CustomerName = c.FirstName, AccountName = a.AccountName, TransactionAmount = decimal.Parse(txbWithdraw.Text), TransactionType = "tagit ur", TransactionWord = "ur" });
                    }
                }

                if (a.Error == true)
                {
                    MessageBox.Show("Det måste vara minst 500kr kvar på ditt konto!");
                }
            }

            else
            {
                MessageBox.Show("Var vänlig och ange ett värde!");
            }
        }
    }
}
