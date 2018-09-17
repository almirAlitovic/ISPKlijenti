namespace ISPKlijenti_UI.RadniNalog
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
            this.dgvRadniNalozi = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKreiranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usluga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dodijeljeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusNaloga = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IznosZaNaplatu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStampaj = new System.Windows.Forms.Button();
            this.txtKlijent = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadniNalozi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRadniNalozi
            // 
            this.dgvRadniNalozi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRadniNalozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadniNalozi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DatumKreiranja,
            this.Klijent,
            this.Usluga,
            this.Dodijeljeno,
            this.Detalji,
            this.Adresa,
            this.StatusNaloga,
            this.IznosZaNaplatu});
            this.dgvRadniNalozi.Location = new System.Drawing.Point(12, 102);
            this.dgvRadniNalozi.MultiSelect = false;
            this.dgvRadniNalozi.Name = "dgvRadniNalozi";
            this.dgvRadniNalozi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRadniNalozi.Size = new System.Drawing.Size(822, 425);
            this.dgvRadniNalozi.TabIndex = 0;
            this.dgvRadniNalozi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRadniNalozi_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // DatumKreiranja
            // 
            this.DatumKreiranja.DataPropertyName = "DatumKreiranja";
            this.DatumKreiranja.HeaderText = "Datum kreiranja";
            this.DatumKreiranja.Name = "DatumKreiranja";
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
            this.Usluga.HeaderText = "Vrsta usluge";
            this.Usluga.Name = "Usluga";
            // 
            // Dodijeljeno
            // 
            this.Dodijeljeno.DataPropertyName = "Dodijeljeno";
            this.Dodijeljeno.HeaderText = "Dodijeljeno";
            this.Dodijeljeno.Name = "Dodijeljeno";
            // 
            // Detalji
            // 
            this.Detalji.DataPropertyName = "Detalji";
            this.Detalji.HeaderText = "Opis posla";
            this.Detalji.Name = "Detalji";
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            // 
            // StatusNaloga
            // 
            this.StatusNaloga.DataPropertyName = "StatusNaloga";
            this.StatusNaloga.HeaderText = "Status naloga";
            this.StatusNaloga.Name = "StatusNaloga";
            this.StatusNaloga.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusNaloga.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IznosZaNaplatu
            // 
            this.IznosZaNaplatu.DataPropertyName = "IznosZaNaplatu";
            this.IznosZaNaplatu.HeaderText = "Iznos za naplatu";
            this.IznosZaNaplatu.Name = "IznosZaNaplatu";
            // 
            // btnStampaj
            // 
            this.btnStampaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStampaj.Location = new System.Drawing.Point(631, 60);
            this.btnStampaj.Name = "btnStampaj";
            this.btnStampaj.Size = new System.Drawing.Size(203, 36);
            this.btnStampaj.TabIndex = 1;
            this.btnStampaj.Text = "Štampaj";
            this.btnStampaj.UseVisualStyleBackColor = true;
            this.btnStampaj.Click += new System.EventHandler(this.btnStampaj_Click);
            // 
            // txtKlijent
            // 
            this.txtKlijent.Location = new System.Drawing.Point(6, 31);
            this.txtKlijent.Name = "txtKlijent";
            this.txtKlijent.Size = new System.Drawing.Size(272, 20);
            this.txtKlijent.TabIndex = 2;
            this.txtKlijent.TextChanged += new System.EventHandler(this.txtKlijent_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtKlijent);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga po klijentu";
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(846, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStampaj);
            this.Controls.Add(this.dgvRadniNalozi);
            this.Name = "IndexForm";
            this.Text = "Lista radnih naloga";
            this.Activated += new System.EventHandler(this.IndexForm_Activated);
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadniNalozi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRadniNalozi;
        private System.Windows.Forms.Button btnStampaj;
        private System.Windows.Forms.TextBox txtKlijent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKreiranja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usluga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dodijeljeno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalji;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewButtonColumn StatusNaloga;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosZaNaplatu;
    }
}