namespace ISPKlijenti_UI.Inventura
{
    partial class NabavkaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NabavkaForm));
            this.dgvNabavke = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NabavnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPrijema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumOd = new System.Windows.Forms.DateTimePicker();
            this.datumDo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNabavke)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNabavke
            // 
            this.dgvNabavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNabavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNabavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv,
            this.Kolicina,
            this.NabavnaCijena,
            this.DatumPrijema});
            this.dgvNabavke.Location = new System.Drawing.Point(12, 115);
            this.dgvNabavke.MultiSelect = false;
            this.dgvNabavke.Name = "dgvNabavke";
            this.dgvNabavke.ReadOnly = true;
            this.dgvNabavke.Size = new System.Drawing.Size(711, 429);
            this.dgvNabavke.TabIndex = 0;
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
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // NabavnaCijena
            // 
            this.NabavnaCijena.DataPropertyName = "NabavnaCijena";
            this.NabavnaCijena.HeaderText = "Nabavna cijena";
            this.NabavnaCijena.Name = "NabavnaCijena";
            this.NabavnaCijena.ReadOnly = true;
            // 
            // DatumPrijema
            // 
            this.DatumPrijema.DataPropertyName = "DatumPrijema";
            this.DatumPrijema.HeaderText = "Datum prijema";
            this.DatumPrijema.Name = "DatumPrijema";
            this.DatumPrijema.ReadOnly = true;
            // 
            // datumOd
            // 
            this.datumOd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datumOd.Location = new System.Drawing.Point(97, 43);
            this.datumOd.Name = "datumOd";
            this.datumOd.Size = new System.Drawing.Size(200, 20);
            this.datumOd.TabIndex = 1;
            // 
            // datumDo
            // 
            this.datumDo.Location = new System.Drawing.Point(443, 42);
            this.datumDo.Name = "datumDo";
            this.datumDo.Size = new System.Drawing.Size(200, 20);
            this.datumDo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(67, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(402, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Do:";
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.BackColor = System.Drawing.SystemColors.Control;
            this.btnFiltriraj.Location = new System.Drawing.Point(309, 76);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(125, 33);
            this.btnFiltriraj.TabIndex = 5;
            this.btnFiltriraj.Text = "Fitriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = false;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // NabavkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(735, 556);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datumDo);
            this.Controls.Add(this.datumOd);
            this.Controls.Add(this.dgvNabavke);
            this.Name = "NabavkaForm";
            this.Text = "Lista nabavki";
            this.Load += new System.EventHandler(this.NabavkaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNabavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNabavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn NabavnaCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPrijema;
        private System.Windows.Forms.DateTimePicker datumOd;
        private System.Windows.Forms.DateTimePicker datumDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFiltriraj;
    }
}