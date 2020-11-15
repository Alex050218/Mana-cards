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
            this.txtCard = new System.Windows.Forms.TextBox();
            this.panelBills = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntWhitD = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBalance = new System.Windows.Forms.Button();
            this.panelBalance = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.panelBills.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(56, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(12, 26);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(171, 20);
            this.txtCard.TabIndex = 1;
            this.txtCard.TextChanged += new System.EventHandler(this.txtTarjeta_TextChanged);
            // 
            // panelBills
            // 
            this.panelBills.Controls.Add(this.button5);
            this.panelBills.Controls.Add(this.button7);
            this.panelBills.Controls.Add(this.button6);
            this.panelBills.Controls.Add(this.button2);
            this.panelBills.Controls.Add(this.label3);
            this.panelBills.Enabled = false;
            this.panelBills.Location = new System.Drawing.Point(216, 50);
            this.panelBills.Name = "panelBills";
            this.panelBills.Size = new System.Drawing.Size(262, 119);
            this.panelBills.TabIndex = 2;
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
            this.label3.Text = "Avaible bills";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label2.Text = "South bank";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntWhitD
            // 
            this.bntWhitD.Enabled = false;
            this.bntWhitD.Location = new System.Drawing.Point(12, 52);
            this.bntWhitD.Name = "bntWhitD";
            this.bntWhitD.Size = new System.Drawing.Size(171, 23);
            this.bntWhitD.TabIndex = 6;
            this.bntWhitD.Text = "Withdrawal";
            this.bntWhitD.UseVisualStyleBackColor = true;
            this.bntWhitD.Click += new System.EventHandler(this.btnTarjeta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Balance:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(129, 12);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(18, 20);
            this.lblBalance.TabIndex = 8;
            this.lblBalance.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBalance);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCard);
            this.panel1.Controls.Add(this.bntWhitD);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 118);
            this.panel1.TabIndex = 9;
            // 
            // btnBalance
            // 
            this.btnBalance.Enabled = false;
            this.btnBalance.Location = new System.Drawing.Point(12, 81);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(171, 23);
            this.btnBalance.TabIndex = 7;
            this.btnBalance.Text = "Check balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // panelBalance
            // 
            this.panelBalance.Controls.Add(this.btnSignOut);
            this.panelBalance.Controls.Add(this.label4);
            this.panelBalance.Controls.Add(this.lblBalance);
            this.panelBalance.Location = new System.Drawing.Point(233, 77);
            this.panelBalance.Name = "panelBalance";
            this.panelBalance.Size = new System.Drawing.Size(226, 65);
            this.panelBalance.TabIndex = 10;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(46, 35);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(140, 23);
            this.btnSignOut.TabIndex = 11;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.CerrarSesion);
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 189);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelBills);
            this.Controls.Add(this.panelBalance);
            this.MaximumSize = new System.Drawing.Size(509, 228);
            this.MinimumSize = new System.Drawing.Size(509, 228);
            this.Name = "Caja";
            this.Text = "Retiro de dinero";
            this.panelBills.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBalance.ResumeLayout(false);
            this.panelBalance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.Panel panelBills;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntWhitD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBalance;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnSignOut;
    }
}

