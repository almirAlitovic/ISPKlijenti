namespace ISPKlijenti_UI.Bills
{
    partial class IndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosBezPDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosSaPDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mjesec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeIsporuke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NacinPlacanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placeno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtKlijent = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.btnStampaj = new System.Windows.Forms.Button();
            this.btnPromjeniStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Klijent,
            this.Naziv,
            this.Kolicina,
            this.Cijena,
            this.IznosBezPDV,
            this.IznosSaPDV,
            this.Mjesec,
            this.VrijemeIsporuke,
            this.NacinPlacanja,
            this.Placeno});
            this.dgvRacuni.Location = new System.Drawing.Point(12, 92);
            this.dgvRacuni.MultiSelect = false;
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacuni.Size = new System.Drawing.Size(933, 510);
            this.dgvRacuni.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Klijent
            // 
            this.Klijent.DataPropertyName = "Klijent";
            this.Klijent.HeaderText = "Klijent";
            this.Klijent.Name = "Klijent";
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Usluga";
            this.Naziv.Name = "Naziv";
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            // 
            // IznosBezPDV
            // 
            this.IznosBezPDV.DataPropertyName = "IznosBezPDV";
            this.IznosBezPDV.HeaderText = "IznosBezPDV";
            this.IznosBezPDV.Name = "IznosBezPDV";
            // 
            // IznosSaPDV
            // 
            this.IznosSaPDV.DataPropertyName = "IznosSaPDV";
            this.IznosSaPDV.HeaderText = "IznosSaPDV";
            this.IznosSaPDV.Name = "IznosSaPDV";
            // 
            // Mjesec
            // 
            this.Mjesec.DataPropertyName = "Mjesec";
            this.Mjesec.HeaderText = "Mjesec";
            this.Mjesec.Name = "Mjesec";
            // 
            // VrijemeIsporuke
            // 
            this.VrijemeIsporuke.DataPropertyName = "VrijemeIsporuke";
            this.VrijemeIsporuke.HeaderText = "Vrijeme isporuke";
            this.VrijemeIsporuke.Name = "VrijemeIsporuke";
            // 
            // NacinPlacanja
            // 
            this.NacinPlacanja.DataPropertyName = "NacinPlacanja";
            this.NacinPlacanja.HeaderText = "Način plaćanja";
            this.NacinPlacanja.Name = "NacinPlacanja";
            // 
            // Placeno
            // 
            this.Placeno.DataPropertyName = "Placeno";
            this.Placeno.HeaderText = "Plaćeno";
            this.Placeno.Name = "Placeno";
            this.Placeno.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Placeno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtKlijent
            // 
            this.txtKlijent.Location = new System.Drawing.Point(6, 22);
            this.txtKlijent.Name = "txtKlijent";
            this.txtKlijent.Size = new System.Drawing.Size(270, 20);
            this.txtKlijent.TabIndex = 1;
            this.txtKlijent.TextChanged += new System.EventHandler(this.txtKlijent_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtKlijent);
            this.groupBox1.Location = new System.Drawing.Point(13, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga po klijentu";
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(475, 49);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(173, 37);
            this.btnKreiraj.TabIndex = 3;
            this.btnKreiraj.Text = "Kreiraj novi račun";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(301, 49);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(168, 37);
            this.btnPosalji.TabIndex = 4;
            this.btnPosalji.Text = "Pošalji obavijest na mail";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // btnStampaj
            // 
            this.btnStampaj.Location = new System.Drawing.Point(654, 49);
            this.btnStampaj.Name = "btnStampaj";
            this.btnStampaj.Size = new System.Drawing.Size(183, 37);
            this.btnStampaj.TabIndex = 5;
            this.btnStampaj.Text = "Štampaj selektovani";
            this.btnStampaj.UseVisualStyleBackColor = true;
            this.btnStampaj.Click += new System.EventHandler(this.btnStampaj_Click);
            // 
            // btnPromjeniStatus
            // 
            this.btnPromjeniStatus.Location = new System.Drawing.Point(843, 49);
            this.btnPromjeniStatus.Name = "btnPromjeniStatus";
            this.btnPromjeniStatus.Size = new System.Drawing.Size(102, 37);
            this.btnPromjeniStatus.TabIndex = 6;
            this.btnPromjeniStatus.Text = "Promjeni u plaćeno";
            this.btnPromjeniStatus.UseVisualStyleBackColor = true;
            this.btnPromjeniStatus.Click += new System.EventHandler(this.btnPromjeniStatus_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(957, 614);
            this.Controls.Add(this.btnPromjeniStatus);
            this.Controls.Add(this.btnStampaj);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRacuni);
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Računi";
            this.Activated += new System.EventHandler(this.IndexForm_Activated);
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.TextBox txtKlijent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosBezPDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosSaPDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mjesec;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeIsporuke;
        private System.Windows.Forms.DataGridViewTextBoxColumn NacinPlacanja;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Placeno;
        private System.Windows.Forms.Button btnStampaj;
        private System.Windows.Forms.Button btnPromjeniStatus;
    }
}