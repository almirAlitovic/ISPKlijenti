namespace ISPKlijenti_UI.Bills
{
    partial class SpecialBillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialBillForm));
            this.dgvPosebniRacuni = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usluga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosBezPDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosSaPDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeIsporuke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NacinPlacanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.btnStampaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosebniRacuni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPosebniRacuni
            // 
            this.dgvPosebniRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosebniRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosebniRacuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Klijent,
            this.Usluga,
            this.Kolicina,
            this.Cijena,
            this.IznosBezPDV,
            this.IznosSaPDV,
            this.VrijemeIsporuke,
            this.Placeno,
            this.NacinPlacanja});
            this.dgvPosebniRacuni.Location = new System.Drawing.Point(12, 12);
            this.dgvPosebniRacuni.MultiSelect = false;
            this.dgvPosebniRacuni.Name = "dgvPosebniRacuni";
            this.dgvPosebniRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosebniRacuni.Size = new System.Drawing.Size(650, 333);
            this.dgvPosebniRacuni.TabIndex = 0;
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
            // Usluga
            // 
            this.Usluga.DataPropertyName = "Usluga";
            this.Usluga.HeaderText = "Usluga";
            this.Usluga.Name = "Usluga";
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
            this.IznosBezPDV.HeaderText = "Iznos bez PDV";
            this.IznosBezPDV.Name = "IznosBezPDV";
            // 
            // IznosSaPDV
            // 
            this.IznosSaPDV.DataPropertyName = "IznosSaPDV";
            this.IznosSaPDV.HeaderText = "Iznos sa PDV";
            this.IznosSaPDV.Name = "IznosSaPDV";
            // 
            // VrijemeIsporuke
            // 
            this.VrijemeIsporuke.DataPropertyName = "VrijemeIsporuke";
            this.VrijemeIsporuke.HeaderText = "Vrijeme isporuke";
            this.VrijemeIsporuke.Name = "VrijemeIsporuke";
            // 
            // Placeno
            // 
            this.Placeno.DataPropertyName = "Placeno";
            this.Placeno.HeaderText = "Plaćeno";
            this.Placeno.Name = "Placeno";
            // 
            // NacinPlacanja
            // 
            this.NacinPlacanja.DataPropertyName = "NacinPlacanja";
            this.NacinPlacanja.HeaderText = "Način plaćanja";
            this.NacinPlacanja.Name = "NacinPlacanja";
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(344, 353);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(156, 73);
            this.btnKreiraj.TabIndex = 1;
            this.btnKreiraj.Text = "Kreiraj novi";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // btnStampaj
            // 
            this.btnStampaj.Location = new System.Drawing.Point(506, 353);
            this.btnStampaj.Name = "btnStampaj";
            this.btnStampaj.Size = new System.Drawing.Size(156, 73);
            this.btnStampaj.TabIndex = 2;
            this.btnStampaj.Text = "Štampaj";
            this.btnStampaj.UseVisualStyleBackColor = true;
            this.btnStampaj.Click += new System.EventHandler(this.btnStampaj_Click);
            // 
            // SpecialBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.btnStampaj);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.dgvPosebniRacuni);
            this.Name = "SpecialBillForm";
            this.Text = "Računi za dodatne usluge";
            this.Load += new System.EventHandler(this.SpecialBillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosebniRacuni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPosebniRacuni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usluga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosBezPDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosSaPDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeIsporuke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placeno;
        private System.Windows.Forms.DataGridViewTextBoxColumn NacinPlacanja;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Button btnStampaj;
    }
}