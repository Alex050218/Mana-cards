using System;
using System.Collections.Generic;
using System.Linq;
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

        // mexican values
        private readonly Dictionary<int, int> Avaible_Bills = new Dictionary<int, int>
        {
            { 500, 4 },
            { 200, 10 },
            { 100, 40 },
            { 20, 2 }
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

        private void Update_balance(double amount, string flag)
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

            // checks if there is enough money to do the operation
            if (BilleteSel > Cards[SelectedCard])
            {
                MessageBox.Show(
                    "There is no enough money to make the transaction",
                    "", MessageBoxButtons.OK
                );
            }
            else
            {
                VentanaRetiro(BilleteSel);
            }

        }

        private void Update_bills(Dictionary<int,int> New_values)
        {
            foreach (KeyValuePair<int,int> Old_bills in New_values)
            {
                int Current_bill = Old_bills.Key;
                int Current_val = Old_bills.Value;

                if (!Avaible_Bills.ContainsKey(Current_bill))
                {
                    throw new System.ArgumentException($"{Current_bill} doen´t exist in the avaible bills");
                } else
                {
                    Avaible_Bills[Current_bill] = Current_val;
                }
            }
        }

        private Dictionary<int, int> Calculate_bills(double Amount, Dictionary<int, int> Amount_bills)
        {
            Dictionary<int, int> Given_bills = new Dictionary<int, int>();

            // we can´t withdraw cents
            double Remaining = Math.Round(Amount);

            // to check if all of the bills were used 
            List<bool> All_used = new List<bool>();

            foreach(KeyValuePair<int, int> Bill in Amount_bills)
            {
                Given_bills.Add(Bill.Key, 0);

                int Current_bill = Bill.Key;
                int Current_amount = Bill.Value;

                // Sucks dry the bill until expends it all
                while (Remaining >= Current_bill)
                {
                    // if all the bills were used
                    if(Given_bills[Current_bill] == Current_amount)
                    {
                        All_used.Add(true);
                        break;
                    }
                    else
                    {
                        Remaining -= Current_bill;
                        Given_bills[Current_bill] += 1;
                    }
                }

                // left out the bills that were not used
                if (Given_bills[Current_bill] == 0)
                {
                    Given_bills.Remove(Current_bill);
                }
            }

            // amount of bills that where used completely
            int Dry_bills = All_used.Count(Val => Val);

            // there is yet money to withdraw and all the bills were used
            bool NotEnoughbills = Dry_bills.Equals(Amount_bills.Count) && Remaining > 0;

            // the amount couldn´t be broken down into bills
            bool Small_amount = Remaining == Amount;

            if (NotEnoughbills || Small_amount)
            {
                return null;
            }
            else
            {
                return Given_bills;
            }
        }
    }
}
