using System;
using System.Windows.Forms;

namespace Tarjetas_de_credito
{
    public partial class Caja : Form
    {

            // almacena el numero de tarjeta que se usara para las transacciones
        private string TarjetaSel;

        public Caja()
        {
            InitializeComponent();
        }

        // dialogo de cerrar sesion
        private void VentanaRetiro(double billete)
        {
        	
            DialogResult Res = MessageBox.Show(

                "Retiro " + billete.ToString() + "$. " + Environment.NewLine
                + "¿Desea cerrar sesion?"

                , "Cerrar sesion",

                MessageBoxButtons.YesNo
            );

            switch (Res)
            {
                case DialogResult.No:
                    Calcular(billete, "Restar");
                    break;

                case DialogResult.Yes:
                    Close();
                    break;
            }
        }

            // retirar dinero
        private void btnTarjeta_Click(object sender, EventArgs e)
        {

                // trayendo los billetes al frente
            panelBilletes.BringToFront();
            panelBilletes.Visible = true;
            panelSaldo.Visible = false;
                
                // obteniendo el texto de la caja de entrada
            TarjetaSel = txtTarjeta.Text;

                // habilitando los billetes
            panelBilletes.Enabled = true;
                
                // saldo de la tarjeta en pantalla 
            lblSaldo.Text = Tarjetas[TarjetaSel].ToString();
        }

        // consulta el saldo
        private void btnConsulta_Click(object sender, EventArgs e)
        {

                // trayendo el panel del saldo hacia el frente
            panelSaldo.BringToFront();
            panelSaldo.Visible = true;
            panelBilletes.Visible = false;

                // actualizando la tarjeta seleccionado
            TarjetaSel = txtTarjeta.Text;
            lblSaldo.Text = Tarjetas[TarjetaSel].ToString();

            
        }
    }
}
