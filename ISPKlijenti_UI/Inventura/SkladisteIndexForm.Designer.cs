namespace ISPKlijenti_UI.Inventura
{
    partial class SkladisteIndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkladisteIndexForm));
            this.dgvSkladiste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjernaJedinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lokacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPromjeniKolicinu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladiste)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSkladiste
            // 
            this.dgvSkladiste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSkladiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladiste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv,
            this.Cijena,
            this.Kolicina,
            this.MjernaJedinica,
            this.Lokacija});
            this.dgvSkladiste.Location = new System.Drawing.Point(12, 24);
            this.dgvSkladiste.MultiSelect = false;
            this.dgvSkladiste.Name = "dgvSkladiste";
            this.dgvSkladiste.ReadOnly = true;
            this.dgvSkladiste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkladiste.Size = new System.Drawing.Size(718, 340);
            this.dgvSkladiste.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // MjernaJedinica
            // 
            this.MjernaJedinica.DataPropertyName = "MjernaJedinica";
            this.MjernaJedinica.HeaderText = "Mjerna jedinica";
            this.MjernaJedinica.Name = "MjernaJedinica";
            this.MjernaJedinica.ReadOnly = true;
            // 
            // Lokacija
            // 
            this.Lokacija.DataPropertyName = "Lokacija";
            this.Lokacija.HeaderText = "Lokacija";
            this.Lokacija.Name = "Lokacija";
            this.Lokacija.ReadOnly = true;
            // 
            // btnPromjeniKolicinu
            // 
            this.btnPromjeniKolicinu.Location = new System.Drawing.Point(293, 380);
            this.btnPromjeniKolicinu.Name = "btnPromjeniKolicinu";
            this.btnPromjeniKolicinu.Size = new System.Drawing.Size(142, 31);
            this.btnPromjeniKolicinu.TabIndex = 1;
            this.btnPromjeniKolicinu.Text = "Promjeni količinu";
            this.btnPromjeniKolicinu.UseVisualStyleBackColor = true;
            this.btnPromjeniKolicinu.Click += new System.EventHandler(this.btnPromjeniKolicinu_Click);
            // 
            // SkladisteIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(742, 423);
            this.Controls.Add(this.btnPromjeniKolicinu);
            this.Controls.Add(this.dgvSkladiste);
            this.Name = "SkladisteIndexForm";
            this.Text = "Stanje na skladištu";
            this.Activated += new System.EventHandler(this.SkladisteIndexForm_Activated);
            this.Load += new System.EventHandler(this.SkladisteIndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladiste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSkladiste;
        private System.Windows.Forms.Button btnPromjeniKolicinu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjernaJedinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokacija;
    }
}