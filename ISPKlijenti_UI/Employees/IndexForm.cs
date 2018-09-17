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

namespace ISPKlijenti_UI.Employees
{
    public partial class IndexForm : Form
    {
        WebAPIHelper zaposleniciService = new WebAPIHelper("http://localhost:8960/", "api/Zaposlenici");

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
            HttpResponseMessage response = zaposleniciService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                dgvZaposlenici.AutoGenerateColumns = false;
                dgvZaposlenici.DataSource = response.Content.ReadAsAsync<List<Zaposlenici>>().Result;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            HttpResponseMessage response = zaposleniciService.getActionResponse("SearchByImePrezime", txtImePrezime.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                dgvZaposlenici.DataSource = response.Content.ReadAsAsync<List<Zaposlenici>>().Result;
            }
        }

        private void btnDeaktiviraj_Click(object sender, EventArgs e)
        {
            Zaposlenici zaposlenik = new Zaposlenici();

            string zaposlenikId = dgvZaposlenici.SelectedRows[0].Cells[0].Value.ToString();

            HttpResponseMessage response = zaposleniciService.GetResponse(zaposlenikId);
            if (response.IsSuccessStatusCode)
            {
                zaposlenik = response.Content.ReadAsAsync<Zaposlenici>().Result;

                if (zaposlenik.Aktivan == true)
                {
                    zaposlenik.Aktivan = false;
                }
                else
                {
                    zaposlenik.Aktivan = true;
                }
            }
            UpdateZaposlenik(zaposlenik);
            
        }

        private void UpdateZaposlenik(Zaposlenici zaposlenik)
        {
            HttpResponseMessage response = zaposleniciService.PutResponse(zaposlenik.Id, zaposlenik);
            if (response.IsSuccessStatusCode)
            {
                LoadData();
            }
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            Zaposlenici zaposlenik = new Zaposlenici();
            HttpResponseMessage response = zaposleniciService.GetResponse(dgvZaposlenici.SelectedRows[0].Cells[0].Value.ToString());
            if (response.IsSuccessStatusCode)
            {
                zaposlenik = response.Content.ReadAsAsync<Zaposlenici>().Result;
            }


            EditForm f = new EditForm(zaposlenik);
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void IndexForm_Activated(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
