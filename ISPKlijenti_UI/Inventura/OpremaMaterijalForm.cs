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
    public partial class OpremaMaterijalForm : Form
    {
        WebAPIHelper opremaService = new WebAPIHelper("http://localhost:8960/", "api/OpremaMaterijal");
        WebAPIHelper mjerneJediniceService = new WebAPIHelper("http://localhost:8960/", "api/MjerneJedinice");

        private OpremaMaterijal opremaMaterijal;

        public OpremaMaterijalForm()
        {
            InitializeComponent();
        }

        private void OpremaMaterijalForm_Load(object sender, EventArgs e)
        {
            LoadData();
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

        private void LoadData()
        {
            HttpResponseMessage response = opremaService.getActionResponse("SelectAll");

            if (response.IsSuccessStatusCode)
            {
                dgvOpremaMaterijal.AutoGenerateColumns = false;
                dgvOpremaMaterijal.DataSource = response.Content.ReadAsAsync<List<isp_Oprema_SelectAll_Result>>().Result;
            }
        }

        private void dgvOpremaMaterijal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvOpremaMaterijal.SelectedRows[0].Cells[0].Value);
            if (id > 0)
            {
                HttpResponseMessage response = opremaService.GetResponse(id.ToString());
                if (response.IsSuccessStatusCode)
                {
                    opremaMaterijal = response.Content.ReadAsAsync<OpremaMaterijal>().Result;
                    txtCijena.Text = opremaMaterijal.Cijena.ToString();
                    txtNaziv.Text = opremaMaterijal.Naziv;
                    cbxMjernaJedinica.SelectedValue = opremaMaterijal.MjernaJedinicaId;
                }
            }
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (opremaMaterijal != null)
            {
                if (this.ValidateChildren())
                {
                    opremaMaterijal.Naziv = txtNaziv.Text;
                    opremaMaterijal.Cijena = Convert.ToDecimal(txtCijena.Text.Trim());
                    opremaMaterijal.MjernaJedinicaId = Convert.ToInt32(cbxMjernaJedinica.SelectedValue);

                    HttpResponseMessage response = opremaService.PutResponse(opremaMaterijal.Id, opremaMaterijal);

                    LoadData();
                }
            }
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            txtCijena.Text = "";
            txtNaziv.Text = "";
            cbxMjernaJedinica.SelectedValue = 0;
            opremaMaterijal = null;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            OpremaAddForm f = new OpremaAddForm();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void OpremaMaterijalForm_Activated(object sender, EventArgs e)
        {
            LoadData();
            BindMjerneJedinice();
        }
    }
}
