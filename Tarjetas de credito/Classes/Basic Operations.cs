using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tarjetas_de_credito
{
    public partial class Caja
    {

        // cards to handle althroughout the system

        private readonly Dictionary<string, double> Cards = new Dictionary<string, double>
        {
            { "1234557", 3450 },
            { "7658973", 9658 },
            { "7845783", 532.67 }
        };

        private void CerrarSesion(object sender, EventArgs e) {

            // sign out button in balance screen

            MessageBox.Show(

                "You have sign out",
                "Signed out",
                MessageBoxButtons.OK
            );

            Close(); 
        }

        private void Calcular(double amount, string flag)
        {

            // perform the basics operations such as substracting of adding money

            switch (flag)
            {
                case "Substract":
                    Cards[SelectedCard] -= amount;
                    break;
                case "Add":
                    Cards[SelectedCard] += amount;
                    break;
            }
        }

        
        private void Billete(Object sender, EventArgs e)
        {

            // get´s the value of the selected bill

            Button botonSel = (Button)sender;
            double BilleteSel = Convert.ToDouble(botonSel.Text);

            VentanaRetiro(BilleteSel);
        }

        private void txtTarjeta_TextChanged(object sender, EventArgs e)
        {
            // changes the states of both buttons if the card is valid

            string CardNumber = txtCard.Text;

            btnBalance.Enabled =
                !string.IsNullOrEmpty(CardNumber) 
                & CardNumber.Length == 7 
                & Cards.ContainsKey(CardNumber);

            bntWhitD.Enabled = btnBalance.Enabled;
        }
    }
}
