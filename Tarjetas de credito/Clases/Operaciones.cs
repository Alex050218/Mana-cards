using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tarjetas_de_credito
{
    public partial class Caja
    {

        // tarjetas incluidas por defecto
        private readonly Dictionary<string, double> Tarjetas = new Dictionary<string, double>
        {
            { "1234557", 3450 },
            { "7658973", 9658 },
            { "7845783", 532.67 }
        };

        // cierra el form y todo acaba
        private void CerrarSesion(object sender, EventArgs e) {



            MessageBox.Show(

                "Ha cerrado la sesion",
                "Sesion cerrada",
                MessageBoxButtons.OK
            );

            Close(); 
        }

        // hace las operaciones de retiro
        private void Calcular(double cantidad, string Modo)
        {

            switch (Modo)
            {
                case "Restar":
                    Tarjetas[TarjetaSel] -= cantidad;
                    break;
                case "Añadir":
                    Tarjetas[TarjetaSel] += cantidad;
                    break;
            }
        }

        // obtiene el texto del boton 
        private void Billete(Object sender, EventArgs e)
        {

            // convirtiendo el texto del boton billete a double
            Button botonSel = (Button)sender;
            double BilleteSel = Convert.ToDouble(botonSel.Text);

            // mostrar el dialogo de confirmacion
            VentanaRetiro(BilleteSel);
        }

        private void txtTarjeta_TextChanged(object sender, EventArgs e)
        {

                // valor de la tarjeta cuando se borra o introduce texto
            string NumTarjeta = txtTarjeta.Text;

                // los botones se activan cuando
            btnConsulta.Enabled =
                !string.IsNullOrEmpty(NumTarjeta) // no es "" o null
                & NumTarjeta.Length == 7 // el texto tiene 7 caracteres
                & Tarjetas.ContainsKey(NumTarjeta); // la tarjeta existe en la lista

                // si es verdadero entonces este tambien
            bntRetiro.Enabled = btnConsulta.Enabled;
        }
    }
}
