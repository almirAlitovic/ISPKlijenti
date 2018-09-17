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

namespace ISPKlijenti_UI.Clients
{
    public partial class IndexForm : Form
    {
        WebAPIHelper klijentiService = new WebAPIHelper("http://localhost:8960/", "api/Klijenti");
        WebAPIHelper klijentiLogService = new WebAPIHelper("http://localhost:8960/", "api/KlijentiLog");

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
            HttpResponseMessage response = klijentiService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                dgvKlijenti.AutoGenerateColumns = false;
                dgvKlijenti.DataSource = response.Content.ReadAsAsync<List<Klijenti>>().Result;
            }
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            HttpResponseMessage response = klijentiService.getActionResponse("SearchByImePrezime", txtImePrezime.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                dgvKlijenti.AutoGenerateColumns = false;
                dgvKlijenti.DataSource = response.Content.ReadAsAsync<List<Klijenti>>().Result;
            }
        }

        private void btnPromjeniStatus_Click(object sender, EventArgs e)
        {
            Klijenti klijent = new Klijenti();

            string klijentId = dgvKlijenti.SelectedRows[0].Cells[0].Value.ToString();

            HttpResponseMessage response = klijentiService.GetResponse(klijentId);
            if (response.IsSuccessStatusCode)
            {
                klijent = response.Content.ReadAsAsync<Klijenti>().Result;

                if (klijent.Aktivan == true)
                {
                    klijent.Aktivan = false;
                }
                else
                {
                    klijent.Aktivan = true;
                }
            }
            UpdateKlijent(klijent);
            AddKlijentLog(klijent);
        }

        private void AddKlijentLog(Klijenti klijent)
        {
            KlijentiLog log = new KlijentiLog();
            log.Ime = klijent.Ime;
            log.Prezime = klijent.Prezime;
            log.KorisnickoIme = klijent.KorisnickoIme;

            if (klijent.Aktivan == true)
            {
                log.IzvrsenaPromjena = "Aktiviran";
            }
            else
            {
                log.IzvrsenaPromjena = "Deaktiviran";
            }

            log.VrijemeIzmjene = DateTime.Now;

            HttpResponseMessage response = klijentiLogService.PostResponse(log);
        }

        private void UpdateKlijent(Klijenti klijent)
        {
            HttpResponseMessage response = klijentiService.PutResponse(klijent.Id, klijent);
            if (response.IsSuccessStatusCode)
            {
                LoadData();
            }
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            Klijenti klijent = new Klijenti();
            HttpResponseMessage response = klijentiService.GetResponse(dgvKlijenti.SelectedRows[0].Cells[0].Value.ToString());
            if (response.IsSuccessStatusCode)
            {
                klijent = response.Content.ReadAsAsync<Klijenti>().Result;
            }


            AddForm f = new AddForm(klijent);
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void IndexForm_Activated(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
