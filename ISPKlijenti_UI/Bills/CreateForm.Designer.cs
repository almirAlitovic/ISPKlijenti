namespace ISPKlijenti_UI.Bills
{
    partial class CreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxKlijent = new System.Windows.Forms.ComboBox();
            this.cbxUsluga = new System.Windows.Forms.ComboBox();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtIznosBezPDV = new System.Windows.Forms.TextBox();
            this.txtIznosSaPDV = new System.Windows.Forms.TextBox();
            this.cbxMjesec = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxNacinPlacanja = new System.Windows.Forms.ComboBox();
            this.checkPlaceno = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(53, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klijent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(48, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usluga:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(44, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Količina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(52, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cijena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(2, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Iznos bez PDV-a:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(17, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Iznos sa PDV:";
            // 
            // cbxKlijent
            // 
            this.cbxKlijent.FormattingEnabled = true;
            this.cbxKlijent.Location = new System.Drawing.Point(97, 32);
            this.cbxKlijent.Name = "cbxKlijent";
            this.cbxKlijent.Size = new System.Drawing.Size(179, 21);
            this.cbxKlijent.TabIndex = 6;
            this.cbxKlijent.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbxKlijent_Format);
            // 
            // cbxUsluga
            // 
            this.cbxUsluga.FormattingEnabled = true;
            this.cbxUsluga.Location = new System.Drawing.Point(97, 58);
            this.cbxUsluga.Name = "cbxUsluga";
            this.cbxUsluga.Size = new System.Drawing.Size(179, 21);
            this.cbxUsluga.TabIndex = 7;
            this.cbxUsluga.SelectedIndexChanged += new System.EventHandler(this.cbxUsluga_SelectedIndexChanged);
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(97, 88);
            this.numKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(179, 20);
            this.numKolicina.TabIndex = 8;
            this.numKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKolicina.ValueChanged += new System.EventHandler(this.numKolicina_ValueChanged);
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(97, 118);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.ReadOnly = true;
            this.txtCijena.Size = new System.Drawing.Size(178, 20);
            this.txtCijena.TabIndex = 9;
            // 
            // txtIznosBezPDV
            // 
            this.txtIznosBezPDV.Location = new System.Drawing.Point(97, 144);
            this.txtIznosBezPDV.Name = "txtIznosBezPDV";
            this.txtIznosBezPDV.ReadOnly = true;
            this.txtIznosBezPDV.Size = new System.Drawing.Size(178, 20);
            this.txtIznosBezPDV.TabIndex = 10;
            // 
            // txtIznosSaPDV
            // 
            this.txtIznosSaPDV.Location = new System.Drawing.Point(97, 173);
            this.txtIznosSaPDV.Name = "txtIznosSaPDV";
            this.txtIznosSaPDV.ReadOnly = true;
            this.txtIznosSaPDV.Size = new System.Drawing.Size(178, 20);
            this.txtIznosSaPDV.TabIndex = 11;
            // 
            // cbxMjesec
            // 
            this.cbxMjesec.FormattingEnabled = true;
            this.cbxMjesec.Location = new System.Drawing.Point(97, 200);
            this.cbxMjesec.Name = "cbxMjesec";
            this.cbxMjesec.Size = new System.Drawing.Size(178, 21);
            this.cbxMjesec.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(47, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mjesec:";
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(85, 303);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(145, 32);
            this.btnKreiraj.TabIndex = 14;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(10, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Način plaćanja:";
            // 
            // cbxNacinPlacanja
            // 
            this.cbxNacinPlacanja.FormattingEnabled = true;
            this.cbxNacinPlacanja.Location = new System.Drawing.Point(97, 227);
            this.cbxNacinPlacanja.Name = "cbxNacinPlacanja";
            this.cbxNacinPlacanja.Size = new System.Drawing.Size(179, 21);
            this.cbxNacinPlacanja.TabIndex = 16;
            // 
            // checkPlaceno
            // 
            this.checkPlaceno.AutoSize = true;
            this.checkPlaceno.BackColor = System.Drawing.Color.Transparent;
            this.checkPlaceno.Location = new System.Drawing.Point(205, 266);
            this.checkPlaceno.Name = "checkPlaceno";
            this.checkPlaceno.Size = new System.Drawing.Size(71, 17);
            this.checkPlaceno.TabIndex = 18;
            this.checkPlaceno.Text = "Plaćeno?";
            this.checkPlaceno.UseVisualStyleBackColor = false;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(308, 347);
            this.Controls.Add(this.checkPlaceno);
            this.Controls.Add(this.cbxNacinPlacanja);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxMjesec);
            this.Controls.Add(this.txtIznosSaPDV);
            this.Controls.Add(this.txtIznosBezPDV);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.cbxUsluga);
            this.Controls.Add(this.cbxKlijent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateForm";
            this.Text = "Kreiranje novog računa";
            this.Load += new System.EventHandler(this.CreateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxKlijent;
        private System.Windows.Forms.ComboBox cbxUsluga;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtIznosBezPDV;
        private System.Windows.Forms.TextBox txtIznosSaPDV;
        private System.Windows.Forms.ComboBox cbxMjesec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxNacinPlacanja;
        private System.Windows.Forms.CheckBox checkPlaceno;
    }
}