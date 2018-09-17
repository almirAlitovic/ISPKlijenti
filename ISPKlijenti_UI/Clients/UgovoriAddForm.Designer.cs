namespace ISPKlijenti_UI.Clients
{
    partial class UgovoriAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UgovoriAddForm));
            this.dgvUgovori = new System.Windows.Forms.DataGridView();
            this.ugovorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojUgovora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPotpisivanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodijeli = new System.Windows.Forms.Button();
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cbxUsluge = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrojUgovora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUgovori
            // 
            this.dgvUgovori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUgovori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUgovori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ugovorId,
            this.BrojUgovora,
            this.DatumPotpisivanja});
            this.dgvUgovori.Location = new System.Drawing.Point(572, 49);
            this.dgvUgovori.Name = "dgvUgovori";
            this.dgvUgovori.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUgovori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUgovori.Size = new System.Drawing.Size(367, 551);
            this.dgvUgovori.TabIndex = 0;
            // 
            // ugovorId
            // 
            this.ugovorId.DataPropertyName = "Id";
            this.ugovorId.HeaderText = "Id";
            this.ugovorId.Name = "ugovorId";
            this.ugovorId.Visible = false;
            // 
            // BrojUgovora
            // 
            this.BrojUgovora.DataPropertyName = "BrojUgovora";
            this.BrojUgovora.HeaderText = "Broj ugovora";
            this.BrojUgovora.Name = "BrojUgovora";
            // 
            // DatumPotpisivanja
            // 
            this.DatumPotpisivanja.DataPropertyName = "DatumPotpisivanja";
            this.DatumPotpisivanja.HeaderText = "Datum potpisivanja";
            this.DatumPotpisivanja.Name = "DatumPotpisivanja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(711, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTA UGOVORA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(136, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "KLIJENTI";
            // 
            // btnDodijeli
            // 
            this.btnDodijeli.Location = new System.Drawing.Point(362, 324);
            this.btnDodijeli.Name = "btnDodijeli";
            this.btnDodijeli.Size = new System.Drawing.Size(191, 59);
            this.btnDodijeli.TabIndex = 3;
            this.btnDodijeli.Text = "Dodijeli";
            this.btnDodijeli.UseVisualStyleBackColor = true;
            this.btnDodijeli.Click += new System.EventHandler(this.btnDodijeli_Click);
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ime,
            this.Prezime,
            this.KorisnickoIme,
            this.Email,
            this.Adresa,
            this.Telefon,
            this.Aktivan});
            this.dgvKlijenti.Location = new System.Drawing.Point(12, 75);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlijenti.Size = new System.Drawing.Size(331, 525);
            this.dgvKlijenti.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisničko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.KorisnickoIme.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            // 
            // cbxUsluge
            // 
            this.cbxUsluge.FormattingEnabled = true;
            this.cbxUsluge.Location = new System.Drawing.Point(362, 219);
            this.cbxUsluge.Name = "cbxUsluge";
            this.cbxUsluge.Size = new System.Drawing.Size(191, 21);
            this.cbxUsluge.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(423, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Paketi i usluge";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(68, 49);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(275, 20);
            this.txtImePrezime.TabIndex = 7;
            this.txtImePrezime.TextChanged += new System.EventHandler(this.txtImePrezime_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pretraga:";
            // 
            // txtBrojUgovora
            // 
            this.txtBrojUgovora.Location = new System.Drawing.Point(362, 278);
            this.txtBrojUgovora.Name = "txtBrojUgovora";
            this.txtBrojUgovora.Size = new System.Drawing.Size(191, 20);
            this.txtBrojUgovora.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(423, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Broj ugovora";
            // 
            // UgovoriAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(951, 627);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBrojUgovora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxUsluge);
            this.Controls.Add(this.dgvKlijenti);
            this.Controls.Add(this.btnDodijeli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUgovori);
            this.Name = "UgovoriAddForm";
            this.Text = "Dodjeljivanje ugovora";
            this.Load += new System.EventHandler(this.UgovoriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUgovori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodijeli;
        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.ComboBox cbxUsluge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrojUgovora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugovorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojUgovora;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPotpisivanja;
    }
}