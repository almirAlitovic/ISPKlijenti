using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPKlijenti_UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dodavanjeNovogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients.AddForm f = new Clients.AddForm();
            f.MdiParent = this;
            f.Show();
        }

        private void evidencijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.IndexForm f = new Employees.IndexForm();
            f.MdiParent = this;
            f.Show();
        }

        private void pregledUgovoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients.UgovoriIndexForm f = new Clients.UgovoriIndexForm();
            f.MdiParent = this;
            f.Show();
        }

        private void listaKlijenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients.IndexForm f = new Clients.IndexForm();
            f.MdiParent = this;
            f.Show();
        }

        private void dodajNoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadniNalog.AddForm f = new RadniNalog.AddForm();
            f.MdiParent = this;
            f.Show();
        }

        private void listaNalogaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadniNalog.IndexForm f = new RadniNalog.IndexForm();
            f.MdiParent = this;
            f.Show();
        }

        private void dobavljačiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers.IndexForm f = new Suppliers.IndexForm();
            f.MdiParent = this;
            f.Show();
        }

        private void uslugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.EditForm f = new Settings.EditForm();
            f.MdiParent = this;
            f.Show();
        }

        private void opremaIMaterijalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventura.OpremaMaterijalForm f = new Inventura.OpremaMaterijalForm();
            f.MdiParent = this;
            f.Show();
        }

        private void stanjeNaSkladištuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventura.SkladisteIndexForm f = new Inventura.SkladisteIndexForm();
            f.MdiParent = this;
            f.Show();
        }

        private void historijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventura.NabavkaForm f = new Inventura.NabavkaForm();
            f.MdiParent = this;
            f.Show();
        }

        private void novaNabavkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventura.NabavkaAddForm f = new Inventura.NabavkaAddForm();
            f.MdiParent = this;
            f.Show();
        }

        private void generisanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bills.IndexForm f = new Bills.IndexForm();
            f.MdiParent = this;
            f.Show();
        }

        private void instaliranaOpremaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients.InstaliranaOpremaForm f = new Clients.InstaliranaOpremaForm();
            f.MdiParent = this;
            f.Show();
        }

        private void posebniRačunidodatneUslugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bills.SpecialBillForm f = new Bills.SpecialBillForm();
            f.MdiParent = this;
            f.Show();
        }

        private void uplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.rptUplate_Form f = new Reports.rptUplate_Form();
            f.Show();
        }
    }
}
