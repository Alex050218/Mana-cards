using System;
using System.Windows.Forms;

namespace Tarjetas_de_credito
{
    public partial class Caja : Form
    {

            // stores the data of the card to handle
        private string SelectedCard;

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
                    Calcular(bill, "Substract");
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
                
            SelectedCard = txtCard.Text;

            panelBills.Enabled = true;
                
            lblBalance.Text = Cards[SelectedCard].ToString();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {

            // button of balance, I couldn´t translate this, sorry
                
            panelBalance.BringToFront();
            panelBalance.Visible = true;
            panelBills.Visible = false;

            SelectedCard = txtCard.Text;
            lblBalance.Text = Cards[SelectedCard].ToString();            
        }
    }
}
