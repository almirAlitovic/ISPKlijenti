namespace ISPKlijenti_UI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.klijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaKlijenataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeNovogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledUgovoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instaliranaOpremaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generisanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posebniRačunidodatneUslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radniNaloziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaNalogaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postavkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventuraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobavljačiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opremaIMaterijalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaNabavkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stanjeNaSkladištuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klijentiToolStripMenuItem,
            this.zaposleniciToolStripMenuItem,
            this.računiToolStripMenuItem,
            this.radniNaloziToolStripMenuItem,
            this.postavkeToolStripMenuItem,
            this.inventuraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1159, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // klijentiToolStripMenuItem
            // 
            this.klijentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaKlijenataToolStripMenuItem,
            this.dodavanjeNovogToolStripMenuItem,
            this.pregledUgovoraToolStripMenuItem,
            this.instaliranaOpremaToolStripMenuItem,
            this.uplateToolStripMenuItem});
            this.klijentiToolStripMenuItem.Name = "klijentiToolStripMenuItem";
            this.klijentiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.klijentiToolStripMenuItem.Text = "Klijenti";
            // 
            // listaKlijenataToolStripMenuItem
            // 
            this.listaKlijenataToolStripMenuItem.Name = "listaKlijenataToolStripMenuItem";
            this.listaKlijenataToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.listaKlijenataToolStripMenuItem.Text = "Lista klijenata";
            this.listaKlijenataToolStripMenuItem.Click += new System.EventHandler(this.listaKlijenataToolStripMenuItem_Click);
            // 
            // dodavanjeNovogToolStripMenuItem
            // 
            this.dodavanjeNovogToolStripMenuItem.Name = "dodavanjeNovogToolStripMenuItem";
            this.dodavanjeNovogToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.dodavanjeNovogToolStripMenuItem.Text = "Dodavanje novog";
            this.dodavanjeNovogToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeNovogToolStripMenuItem_Click);
            // 
            // pregledUgovoraToolStripMenuItem
            // 
            this.pregledUgovoraToolStripMenuItem.Name = "pregledUgovoraToolStripMenuItem";
            this.pregledUgovoraToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pregledUgovoraToolStripMenuItem.Text = "Pregled ugovora";
            this.pregledUgovoraToolStripMenuItem.Click += new System.EventHandler(this.pregledUgovoraToolStripMenuItem_Click);
            // 
            // instaliranaOpremaToolStripMenuItem
            // 
            this.instaliranaOpremaToolStripMenuItem.Name = "instaliranaOpremaToolStripMenuItem";
            this.instaliranaOpremaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.instaliranaOpremaToolStripMenuItem.Text = "Instalirana oprema";
            this.instaliranaOpremaToolStripMenuItem.Click += new System.EventHandler(this.instaliranaOpremaToolStripMenuItem_Click);
            // 
            // uplateToolStripMenuItem
            // 
            this.uplateToolStripMenuItem.Name = "uplateToolStripMenuItem";
            this.uplateToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.uplateToolStripMenuItem.Text = "Uplate";
            this.uplateToolStripMenuItem.Click += new System.EventHandler(this.uplateToolStripMenuItem_Click);
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evidencijaToolStripMenuItem});
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            // 
            // evidencijaToolStripMenuItem
            // 
            this.evidencijaToolStripMenuItem.Name = "evidencijaToolStripMenuItem";
            this.evidencijaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.evidencijaToolStripMenuItem.Text = "Evidencija";
            this.evidencijaToolStripMenuItem.Click += new System.EventHandler(this.evidencijaToolStripMenuItem_Click);
            // 
            // računiToolStripMenuItem
            // 
            this.računiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generisanjeToolStripMenuItem,
            this.posebniRačunidodatneUslugeToolStripMenuItem});
            this.računiToolStripMenuItem.Name = "računiToolStripMenuItem";
            this.računiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.računiToolStripMenuItem.Text = "Računi";
            // 
            // generisanjeToolStripMenuItem
            // 
            this.generisanjeToolStripMenuItem.Name = "generisanjeToolStripMenuItem";
            this.generisanjeToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.generisanjeToolStripMenuItem.Text = "Računi za internet usluge";
            this.generisanjeToolStripMenuItem.Click += new System.EventHandler(this.generisanjeToolStripMenuItem_Click);
            // 
            // posebniRačunidodatneUslugeToolStripMenuItem
            // 
            this.posebniRačunidodatneUslugeToolStripMenuItem.Name = "posebniRačunidodatneUslugeToolStripMenuItem";
            this.posebniRačunidodatneUslugeToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.posebniRačunidodatneUslugeToolStripMenuItem.Text = "Posebni računi (dodatne usluge)";
            this.posebniRačunidodatneUslugeToolStripMenuItem.Click += new System.EventHandler(this.posebniRačunidodatneUslugeToolStripMenuItem_Click);
            // 
            // radniNaloziToolStripMenuItem
            // 
            this.radniNaloziToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaNalogaToolStripMenuItem,
            this.dodajNoviToolStripMenuItem});
            this.radniNaloziToolStripMenuItem.Name = "radniNaloziToolStripMenuItem";
            this.radniNaloziToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.radniNaloziToolStripMenuItem.Text = "Radni nalozi";
            // 
            // listaNalogaToolStripMenuItem
            // 
            this.listaNalogaToolStripMenuItem.Name = "listaNalogaToolStripMenuItem";
            this.listaNalogaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.listaNalogaToolStripMenuItem.Text = "Lista naloga";
            this.listaNalogaToolStripMenuItem.Click += new System.EventHandler(this.listaNalogaToolStripMenuItem_Click);
            // 
            // dodajNoviToolStripMenuItem
            // 
            this.dodajNoviToolStripMenuItem.Name = "dodajNoviToolStripMenuItem";
            this.dodajNoviToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.dodajNoviToolStripMenuItem.Text = "Dodaj novi";
            this.dodajNoviToolStripMenuItem.Click += new System.EventHandler(this.dodajNoviToolStripMenuItem_Click);
            // 
            // postavkeToolStripMenuItem
            // 
            this.postavkeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uslugeToolStripMenuItem});
            this.postavkeToolStripMenuItem.Name = "postavkeToolStripMenuItem";
            this.postavkeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.postavkeToolStripMenuItem.Text = "Postavke";
            // 
            // uslugeToolStripMenuItem
            // 
            this.uslugeToolStripMenuItem.Name = "uslugeToolStripMenuItem";
            this.uslugeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.uslugeToolStripMenuItem.Text = "Usluge";
            this.uslugeToolStripMenuItem.Click += new System.EventHandler(this.uslugeToolStripMenuItem_Click);
            // 
            // inventuraToolStripMenuItem
            // 
            this.inventuraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dobavljačiToolStripMenuItem,
            this.opremaIMaterijalToolStripMenuItem,
            this.novaNabavkaToolStripMenuItem,
            this.historijaToolStripMenuItem,
            this.stanjeNaSkladištuToolStripMenuItem});
            this.inventuraToolStripMenuItem.Name = "inventuraToolStripMenuItem";
            this.inventuraToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.inventuraToolStripMenuItem.Text = "Inventura";
            // 
            // dobavljačiToolStripMenuItem
            // 
            this.dobavljačiToolStripMenuItem.Name = "dobavljačiToolStripMenuItem";
            this.dobavljačiToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.dobavljačiToolStripMenuItem.Text = "Dobavljači";
            this.dobavljačiToolStripMenuItem.Click += new System.EventHandler(this.dobavljačiToolStripMenuItem_Click);
            // 
            // opremaIMaterijalToolStripMenuItem
            // 
            this.opremaIMaterijalToolStripMenuItem.Name = "opremaIMaterijalToolStripMenuItem";
            this.opremaIMaterijalToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.opremaIMaterijalToolStripMenuItem.Text = "Oprema i materijal";
            this.opremaIMaterijalToolStripMenuItem.Click += new System.EventHandler(this.opremaIMaterijalToolStripMenuItem_Click);
            // 
            // novaNabavkaToolStripMenuItem
            // 
            this.novaNabavkaToolStripMenuItem.Name = "novaNabavkaToolStripMenuItem";
            this.novaNabavkaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.novaNabavkaToolStripMenuItem.Text = "Nova nabavka";
            this.novaNabavkaToolStripMenuItem.Click += new System.EventHandler(this.novaNabavkaToolStripMenuItem_Click);
            // 
            // historijaToolStripMenuItem
            // 
            this.historijaToolStripMenuItem.Name = "historijaToolStripMenuItem";
            this.historijaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.historijaToolStripMenuItem.Text = "Historija nabavki";
            this.historijaToolStripMenuItem.Click += new System.EventHandler(this.historijaToolStripMenuItem_Click);
            // 
            // stanjeNaSkladištuToolStripMenuItem
            // 
            this.stanjeNaSkladištuToolStripMenuItem.Name = "stanjeNaSkladištuToolStripMenuItem";
            this.stanjeNaSkladištuToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.stanjeNaSkladištuToolStripMenuItem.Text = "Stanje na skladištu";
            this.stanjeNaSkladištuToolStripMenuItem.Click += new System.EventHandler(this.stanjeNaSkladištuToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1159, 680);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Evidencija ISP klijenata";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem klijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeNovogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidencijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledUgovoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaKlijenataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem računiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generisanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radniNaloziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaNalogaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postavkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventuraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobavljačiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opremaIMaterijalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaNabavkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stanjeNaSkladištuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instaliranaOpremaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posebniRačunidodatneUslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uplateToolStripMenuItem;
    }
}