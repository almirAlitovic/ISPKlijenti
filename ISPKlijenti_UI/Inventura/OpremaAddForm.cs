using ISPKlijenti_API.Models;
using ISPKlijenti_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPKlijenti_UI.Inventura
{
    public partial class OpremaAddForm : Form
    {
        WebAPIHelper opremaService = new WebAPIHelper("http://localhost:8960/", "api/OpremaMaterijal");
        WebAPIHelper mjerneJediniceService = new WebAPIHelper("http://localhost:8960/", "api/MjerneJedinice");
        public OpremaAddForm()
        {
            InitializeComponent();
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            txtNaziv.Text = "";
            txtCijena.Text = "";
            cbxMjernaJedinica.SelectedIndex = 0;
        }

        private void OpremaAddForm_Load(object sender, EventArgs e)
        {
            BindMjerneJedinice();
        }

        private void BindMjerneJedinice()
        {
            HttpResponseMessage response = mjerneJediniceService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                cbxMjernaJedinica.DataSource = response.Content.ReadAsAsync<List<MjerneJedinice>>().Result;
                cbxMjernaJedinica.ValueMember = "Id";
                cbxMjernaJedinica.DisplayMember = "Oznaka";
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            OpremaMaterijal opMat = new OpremaMaterijal();
            opMat.Naziv = txtNaziv.Text;
            opMat.Cijena = Convert.ToDecimal(txtCijena.Text);
            opMat.MjernaJedinicaId = Convert.ToInt32(cbxMjernaJedinica.SelectedValue);

            HttpResponseMessage response = opremaService.PostResponse(opMat);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Uspješno dodan zapis u bazu podataka");
                this.Close();
            }
        }
    }
}
