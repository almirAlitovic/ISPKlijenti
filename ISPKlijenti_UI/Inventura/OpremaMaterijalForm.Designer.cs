namespace ISPKlijenti_UI.Inventura
{
    partial class OpremaMaterijalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpremaMaterijalForm));
            this.dgvOpremaMaterijal = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjernaJedinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.cbxMjernaJedinica = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpremaMaterijal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOpremaMaterijal
            // 
            this.dgvOpremaMaterijal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOpremaMaterijal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpremaMaterijal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv,
            this.Cijena,
            this.MjernaJedinica});
            this.dgvOpremaMaterijal.Location = new System.Drawing.Point(26, 36);
            this.dgvOpremaMaterijal.MultiSelect = false;
            this.dgvOpremaMaterijal.Name = "dgvOpremaMaterijal";
            this.dgvOpremaMaterijal.ReadOnly = true;
            this.dgvOpremaMaterijal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOpremaMaterijal.Size = new System.Drawing.Size(416, 349);
            this.dgvOpremaMaterijal.TabIndex = 0;
            this.dgvOpremaMaterijal.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOpremaMaterijal_CellContentDoubleClick);
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
            // MjernaJedinica
            // 
            this.MjernaJedinica.DataPropertyName = "MjernaJedinica";
            this.MjernaJedinica.HeaderText = "Mjerna jedinica";
            this.MjernaJedinica.Name = "MjernaJedinica";
            this.MjernaJedinica.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(582, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(580, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cijena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(561, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mjerna jedninica";
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(519, 213);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(160, 36);
            this.btnSnimi.TabIndex = 4;
            this.btnSnimi.Text = "Snimi izmjene";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(519, 48);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(160, 20);
            this.txtNaziv.TabIndex = 5;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(519, 103);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(160, 20);
            this.txtCijena.TabIndex = 6;
            // 
            // cbxMjernaJedinica
            // 
            this.cbxMjernaJedinica.FormattingEnabled = true;
            this.cbxMjernaJedinica.Location = new System.Drawing.Point(519, 167);
            this.cbxMjernaJedinica.Name = "cbxMjernaJedinica";
            this.cbxMjernaJedinica.Size = new System.Drawing.Size(160, 21);
            this.cbxMjernaJedinica.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(519, 270);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(160, 36);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj novo";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(519, 329);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(160, 36);
            this.btnPonisti.TabIndex = 9;
            this.btnPonisti.Text = "Poništi unos";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // OpremaMaterijalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(756, 419);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbxMjernaJedinica);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOpremaMaterijal);
            this.Name = "OpremaMaterijalForm";
            this.Text = "Oprema i materijal";
            this.Activated += new System.EventHandler(this.OpremaMaterijalForm_Activated);
            this.Load += new System.EventHandler(this.OpremaMaterijalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpremaMaterijal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOpremaMaterijal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjernaJedinica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.ComboBox cbxMjernaJedinica;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPonisti;
    }
}