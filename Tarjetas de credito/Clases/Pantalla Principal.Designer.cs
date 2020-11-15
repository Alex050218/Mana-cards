namespace Tarjetas_de_credito
{
    partial class Caja
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.panelBilletes = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntRetiro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.panelSaldo = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelBilletes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(56, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de tarjeta";
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(12, 26);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(171, 20);
            this.txtTarjeta.TabIndex = 1;
            this.txtTarjeta.TextChanged += new System.EventHandler(this.txtTarjeta_TextChanged);
            // 
            // panelBilletes
            // 
            this.panelBilletes.Controls.Add(this.button5);
            this.panelBilletes.Controls.Add(this.button7);
            this.panelBilletes.Controls.Add(this.button6);
            this.panelBilletes.Controls.Add(this.button2);
            this.panelBilletes.Controls.Add(this.label3);
            this.panelBilletes.Enabled = false;
            this.panelBilletes.Location = new System.Drawing.Point(216, 51);
            this.panelBilletes.Name = "panelBilletes";
            this.panelBilletes.Size = new System.Drawing.Size(262, 119);
            this.panelBilletes.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(33, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 9;
            this.button5.Text = "200";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Billete);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(149, 70);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 27);
            this.button7.TabIndex = 8;
            this.button7.Text = "100";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Billete);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(149, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "500";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Billete);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "50";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Billete);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(81, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Billetes Disponibles";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Banco del sur";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntRetiro
            // 
            this.bntRetiro.Enabled = false;
            this.bntRetiro.Location = new System.Drawing.Point(12, 52);
            this.bntRetiro.Name = "bntRetiro";
            this.bntRetiro.Size = new System.Drawing.Size(171, 23);
            this.bntRetiro.TabIndex = 6;
            this.bntRetiro.Text = "Retiro de efectivo";
            this.bntRetiro.UseVisualStyleBackColor = true;
            this.bntRetiro.Click += new System.EventHandler(this.btnTarjeta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saldo disponible:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(129, 12);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(18, 20);
            this.lblSaldo.TabIndex = 8;
            this.lblSaldo.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConsulta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTarjeta);
            this.panel1.Controls.Add(this.bntRetiro);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 118);
            this.panel1.TabIndex = 9;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Enabled = false;
            this.btnConsulta.Location = new System.Drawing.Point(12, 81);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(171, 23);
            this.btnConsulta.TabIndex = 7;
            this.btnConsulta.Text = "Consulta de saldo";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // panelSaldo
            // 
            this.panelSaldo.Controls.Add(this.btnCerrarSesion);
            this.panelSaldo.Controls.Add(this.label4);
            this.panelSaldo.Controls.Add(this.lblSaldo);
            this.panelSaldo.Location = new System.Drawing.Point(233, 77);
            this.panelSaldo.Name = "panelSaldo";
            this.panelSaldo.Size = new System.Drawing.Size(226, 65);
            this.panelSaldo.TabIndex = 10;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(46, 35);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(140, 23);
            this.btnCerrarSesion.TabIndex = 11;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.CerrarSesion);
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 189);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelBilletes);
            this.Controls.Add(this.panelSaldo);
            this.MaximumSize = new System.Drawing.Size(509, 228);
            this.MinimumSize = new System.Drawing.Size(509, 228);
            this.Name = "Caja";
            this.Text = "Retiro de dinero";
            this.panelBilletes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSaldo.ResumeLayout(false);
            this.panelSaldo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Panel panelBilletes;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntRetiro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSaldo;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}

