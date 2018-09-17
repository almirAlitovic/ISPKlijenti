namespace ISPKlijenti_UI.Bills
{
    partial class SpecialBillAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialBillAddForm));
            this.checkPlaceno = new System.Windows.Forms.CheckBox();
            this.cbxNacinPlacanja = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.txtIznosSaPDV = new System.Windows.Forms.TextBox();
            this.txtIznosBezPDV = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKlijent = new System.Windows.Forms.TextBox();
            this.txtUsluga = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // checkPlaceno
            // 
            this.checkPlaceno.AutoSize = true;
            this.checkPlaceno.BackColor = System.Drawing.Color.Transparent;
            this.checkPlaceno.Location = new System.Drawing.Point(246, 245);
            this.checkPlaceno.Name = "checkPlaceno";
            this.checkPlaceno.Size = new System.Drawing.Size(71, 17);
            this.checkPlaceno.TabIndex = 36;
            this.checkPlaceno.Text = "Plaćeno?";
            this.checkPlaceno.UseVisualStyleBackColor = false;
            // 
            // cbxNacinPlacanja
            // 
            this.cbxNacinPlacanja.FormattingEnabled = true;
            this.cbxNacinPlacanja.Location = new System.Drawing.Point(138, 204);
            this.cbxNacinPlacanja.Name = "cbxNacinPlacanja";
            this.cbxNacinPlacanja.Size = new System.Drawing.Size(179, 21);
            this.cbxNacinPlacanja.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(51, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Način plaćanja:";
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(127, 281);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(145, 32);
            this.btnKreiraj.TabIndex = 33;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // txtIznosSaPDV
            // 
            this.txtIznosSaPDV.Location = new System.Drawing.Point(138, 178);
            this.txtIznosSaPDV.Name = "txtIznosSaPDV";
            this.txtIznosSaPDV.ReadOnly = true;
            this.txtIznosSaPDV.Size = new System.Drawing.Size(178, 20);
            this.txtIznosSaPDV.TabIndex = 30;
            // 
            // txtIznosBezPDV
            // 
            this.txtIznosBezPDV.Location = new System.Drawing.Point(138, 149);
            this.txtIznosBezPDV.Name = "txtIznosBezPDV";
            this.txtIznosBezPDV.ReadOnly = true;
            this.txtIznosBezPDV.Size = new System.Drawing.Size(178, 20);
            this.txtIznosBezPDV.TabIndex = 29;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(138, 123);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(178, 20);
            this.txtCijena.TabIndex = 28;
            this.txtCijena.TextChanged += new System.EventHandler(this.txtCijena_TextChanged);
            this.txtCijena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCijena_KeyPress);
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(138, 93);
            this.numKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(179, 20);
            this.numKolicina.TabIndex = 27;
            this.numKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(58, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Iznos sa PDV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(43, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Iznos bez PDV-a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(93, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cijena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(85, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Količina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(89, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Usluga:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(94, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Klijent:";
            // 
            // txtKlijent
            // 
            this.txtKlijent.Location = new System.Drawing.Point(138, 37);
            this.txtKlijent.Name = "txtKlijent";
            this.txtKlijent.Size = new System.Drawing.Size(177, 20);
            this.txtKlijent.TabIndex = 37;
            // 
            // txtUsluga
            // 
            this.txtUsluga.Location = new System.Drawing.Point(138, 63);
            this.txtUsluga.Name = "txtUsluga";
            this.txtUsluga.Size = new System.Drawing.Size(176, 20);
            this.txtUsluga.TabIndex = 38;
            // 
            // SpecialBillAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(376, 333);
            this.Controls.Add(this.txtUsluga);
            this.Controls.Add(this.txtKlijent);
            this.Controls.Add(this.checkPlaceno);
            this.Controls.Add(this.cbxNacinPlacanja);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.txtIznosSaPDV);
            this.Controls.Add(this.txtIznosBezPDV);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SpecialBillAddForm";
            this.Text = "Kreiranje posebnog računa";
            this.Load += new System.EventHandler(this.SpecialBillAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkPlaceno;
        private System.Windows.Forms.ComboBox cbxNacinPlacanja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.TextBox txtIznosSaPDV;
        private System.Windows.Forms.TextBox txtIznosBezPDV;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKlijent;
        private System.Windows.Forms.TextBox txtUsluga;
    }
}