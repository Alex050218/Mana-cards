using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace Tarjetas_de_credito
{
    public partial class Caja : Form
    {
            // stores the data of the card to handle
        private string SelectedCard;
        private readonly string Path_bills = @"C:\Users\Alejandro\Desktop";

        public Caja()
        {
            // 'Caja' stands for ATM in spanish
            InitializeComponent();
        }

        // dialogo de cerrar sesion
        private void VentanaRetiro(double bill)
        {

            // withdrawal money sign out confirmation
            DialogResult dialogResult = MessageBox.Show(

                "You have withdraw" + bill.ToString() + "$. " + Environment.NewLine
                + "¿Would you want to sign out?"

                , "Sign out confirmation",

                MessageBoxButtons.YesNo
            );

            switch (dialogResult)
            {
                case DialogResult.No:
                    Update_balance(bill, "Substract");
                    break;

                case DialogResult.Yes:

                    // the teacher did not tell to store the data somewhere
                    Close();
                    break;
            }
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            // whitdrawal button
            panelBills.BringToFront();

            panelBills.Visible = true;
            panelBalance.Visible = false;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            // showing the balance
            SelectedCard = txtCard.Text;
            lblBalance.Text = Cards[SelectedCard].ToString();

            panelBalance.BringToFront();

            panelBills.Visible = false;
            panelBalance.Visible = true;
        }

        private void txtTarjeta_TextChanged(object sender, EventArgs e)
        {
            // changes the states of both buttons if the card is valid
            SelectedCard = txtCard.Text;
            
            btnBalance.Enabled = Cards.ContainsKey(SelectedCard);
            bntWhitD.Enabled = btnBalance.Enabled;

            panelBalance.Enabled = btnBalance.Enabled;
            panelBills.Enabled = panelBalance.Enabled;
        }

        private void Withdraw_all(object sender, EventArgs e)
        {

            DialogResult Confirmation_W =  MessageBox.Show(
                "Are you sure that you want to withdraw everything from your account?",
                "Withdrawal confirmation", MessageBoxButtons.YesNo
            );

            if (Confirmation_W.Equals(DialogResult.Yes))
            {
                Double Money = Math.Round(Cards[SelectedCard]);
                Dictionary<int, int> Given_bills = Calculate_bills(Money, Avaible_Bills);

                // if the current amount could not be broken into pieces
                if (Given_bills == null)
                {
                    MessageBox.Show(
                        "Not enough money in the ATM or amount can´t be withdrawn", 
                        "Advice",
                        MessageBoxButtons.OK
                    );
                } else
                {
                    Create_txt(SelectedCard, Given_bills);
                    Update_bills(Given_bills);
                    Update_balance(Money, "Substract");
                }
            }
        }

        private void Create_txt(string Card, Dictionary<int, int> Bills)
        {
            StreamWriter New_bills = new StreamWriter($@"{Path_bills}\{Card}.txt", false);

            New_bills.WriteLine("--------------------------------------");
            New_bills.WriteLine("\t Bills to take");
            New_bills.WriteLine("--------------------------------------");

            foreach (KeyValuePair<int, int> Bill in Bills)
            {
                New_bills.WriteLine($"\t {Bill.Key} : {Bill.Value}");
            }

            New_bills.WriteLine("--------------------------------------");
            New_bills.Close();
        }
    }
}
