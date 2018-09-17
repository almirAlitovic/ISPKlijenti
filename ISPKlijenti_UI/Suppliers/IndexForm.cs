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

namespace ISPKlijenti_UI.Suppliers
{
    public partial class IndexForm : Form
    {
        WebAPIHelper dobavljaciService = new WebAPIHelper("http://localhost:8960/", "api/Dobavljaci");
        public IndexForm()
        {
            InitializeComponent();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            HttpResponseMessage response = dobavljaciService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                dgvDobavljaci.AutoGenerateColumns = false;
                dgvDobavljaci.DataSource = response.Content.ReadAsAsync<List<Dobavljaci>>().Result;
            }
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            HttpResponseMessage response = dobavljaciService.getActionResponse("GetDobavljaciByNaziv", txtNaziv.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                dgvDobavljaci.AutoGenerateColumns = false;
                dgvDobavljaci.DataSource = response.Content.ReadAsAsync<List<isp_Dobavljaci_SelectByNaziv_Result>>().Result;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            Dobavljaci dobavljac = new Dobavljaci();

            HttpResponseMessage response = dobavljaciService.GetResponse(dgvDobavljaci.SelectedRows[0].Cells[0].Value.ToString());
            if (response.IsSuccessStatusCode)
            {
                dobavljac = response.Content.ReadAsAsync<Dobavljaci>().Result;

                AddForm f = new AddForm(dobavljac);
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            else
            {
                MessageBox.Show("Niste selektovali dobavljača.");
            }       
        }

        private void IndexForm_Activated(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
