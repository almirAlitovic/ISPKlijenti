namespace ISPKlijenti_UI.RadniNalog
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxPostojeciKlijenti = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpisPosla = new System.Windows.Forms.RichTextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.cbxTehnicar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnStampajSacuvaj = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.cbxUsluga = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbxPostojeciKlijenti);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtKorisnickoIme);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOpisPosla);
            this.groupBox1.Controls.Add(this.lblAdresa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAdresa);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Location = new System.Drawing.Point(36, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o klijentu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Postojeći klijent:";
            // 
            // cbxPostojeciKlijenti
            // 
            this.cbxPostojeciKlijenti.FormattingEnabled = true;
            this.cbxPostojeciKlijenti.Location = new System.Drawing.Point(105, 20);
            this.cbxPostojeciKlijenti.Name = "cbxPostojeciKlijenti";
            this.cbxPostojeciKlijenti.Size = new System.Drawing.Size(272, 21);
            this.cbxPostojeciKlijenti.TabIndex = 14;
            this.cbxPostojeciKlijenti.SelectedIndexChanged += new System.EventHandler(this.cbxPostojeciKlijenti_SelectedIndexChanged);
            this.cbxPostojeciKlijenti.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbxPostojeciFormat);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Telefon:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Email:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(105, 160);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.ReadOnly = true;
            this.txtTelefon.Size = new System.Drawing.Size(142, 20);
            this.txtTelefon.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(105, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(272, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Korisničko ime:";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(105, 80);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.ReadOnly = true;
            this.txtKorisnickoIme.Size = new System.Drawing.Size(272, 20);
            this.txtKorisnickoIme.TabIndex = 8;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(242, 53);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(135, 20);
            this.txtPrezime.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Opis posla:";
            // 
            // txtOpisPosla
            // 
            this.txtOpisPosla.Location = new System.Drawing.Point(105, 186);
            this.txtOpisPosla.Name = "txtOpisPosla";
            this.txtOpisPosla.Size = new System.Drawing.Size(272, 78);
            this.txtOpisPosla.TabIndex = 5;
            this.txtOpisPosla.Text = "";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(56, 136);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(43, 13);
            this.lblAdresa.TabIndex = 4;
            this.lblAdresa.Text = "Adresa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime i prezime:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(105, 133);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.ReadOnly = true;
            this.txtAdresa.Size = new System.Drawing.Size(272, 20);
            this.txtAdresa.TabIndex = 1;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(105, 53);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(135, 20);
            this.txtIme.TabIndex = 0;
            // 
            // cbxTehnicar
            // 
            this.cbxTehnicar.FormattingEnabled = true;
            this.cbxTehnicar.Location = new System.Drawing.Point(141, 356);
            this.cbxTehnicar.Name = "cbxTehnicar";
            this.cbxTehnicar.Size = new System.Drawing.Size(219, 21);
            this.cbxTehnicar.TabIndex = 8;
            this.cbxTehnicar.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbxFormat);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(50, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nalog dodijeljen:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(48, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Iznos za naplatu:";
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(141, 399);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(142, 20);
            this.txtIznos.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(291, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "KM";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(480, 46);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(199, 55);
            this.btnSacuvaj.TabIndex = 13;
            this.btnSacuvaj.Text = "Sačuvaj nalog";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnStampajSacuvaj
            // 
            this.btnStampajSacuvaj.Location = new System.Drawing.Point(480, 119);
            this.btnStampajSacuvaj.Name = "btnStampajSacuvaj";
            this.btnStampajSacuvaj.Size = new System.Drawing.Size(199, 55);
            this.btnStampajSacuvaj.TabIndex = 14;
            this.btnStampajSacuvaj.Text = "Štampaj i sačuvaj nalog";
            this.btnStampajSacuvaj.UseVisualStyleBackColor = true;
            this.btnStampajSacuvaj.Click += new System.EventHandler(this.btnStampajSacuvaj_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(480, 194);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(199, 55);
            this.btnPonisti.TabIndex = 15;
            this.btnPonisti.Text = "Poništi unos";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // cbxUsluga
            // 
            this.cbxUsluga.FormattingEnabled = true;
            this.cbxUsluga.Location = new System.Drawing.Point(141, 46);
            this.cbxUsluga.Name = "cbxUsluga";
            this.cbxUsluga.Size = new System.Drawing.Size(272, 21);
            this.cbxUsluga.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(67, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Vrsta usluge:";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(729, 480);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxUsluga);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnStampajSacuvaj);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxTehnicar);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddForm";
            this.Text = "Kreiranje radnog naloga";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtOpisPosla;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.ComboBox cbxTehnicar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnStampajSacuvaj;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.ComboBox cbxUsluga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxPostojeciKlijenti;
    }
}