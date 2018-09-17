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
    public partial class UgovoriAddForm : Form
    {
        WebAPIHelper klijentiService = new WebAPIHelper("http://localhost:8960/", "api/Klijenti");
        WebAPIHelper uslugeService = new WebAPIHelper("http://localhost:8960/", "api/Usluge");
        WebAPIHelper ugovoriService = new WebAPIHelper("http://localhost:8960/", "api/Ugovori");
        WebAPIHelper klijentiLogService = new WebAPIHelper("http://localhost:8960/", "api/KlijentiLog");


        public UgovoriAddForm()
        {
            InitializeComponent();
        }

        private void UgovoriForm_Load(object sender, EventArgs e)
        {
            BindKlijenti();
            BindUgovori();
            BindUsluge();
        }

        private void BindUsluge()
        {
            HttpResponseMessage response = uslugeService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Usluge> usluge = response.Content.ReadAsAsync<List<Usluge>>().Result;
                usluge.Insert(0, new Usluge());
                cbxUsluge.DataSource = usluge;
                cbxUsluge.DisplayMember = "Naziv";
                cbxUsluge.ValueMember = "Id";
            }

        }

        private void BindUgovori()
        {
            HttpResponseMessage response = ugovoriService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                dgvUgovori.AutoGenerateColumns = false;
                dgvUgovori.DataSource = response.Content.ReadAsAsync<List<Ugovori>>().Result;
            }
        }

        private void BindKlijenti()
        {
            if (txtImePrezime.Text == "")
            {
                HttpResponseMessage response = klijentiService.GetResponse();
                if (response.IsSuccessStatusCode)
                {
                    dgvKlijenti.AutoGenerateColumns = false;
                    dgvKlijenti.DataSource = response.Content.ReadAsAsync<List<Klijenti>>().Result;
                }
            }
            else
            {
                HttpResponseMessage response = klijentiService.getActionResponse("SearchByImePrezime", txtImePrezime.Text);
                if (response.IsSuccessStatusCode)
                {
                    dgvKlijenti.AutoGenerateColumns = false;
                    dgvKlijenti.DataSource = response.Content.ReadAsAsync<List<Klijenti>>().Result;
                }
            }
            
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            BindKlijenti();
        }

        private void btnDodijeli_Click(object sender, EventArgs e)
        {
            Ugovori ugovor = new Ugovori();

            ugovor.KlijentId = Convert.ToInt32(dgvKlijenti.SelectedRows[0].Cells[0].Value);
            ugovor.DatumPotpisivanja = DateTime.Now;
            ugovor.BrojUgovora = Convert.ToInt32(txtBrojUgovora.Text.Trim());
            ugovor.UslugaId = Convert.ToInt32(cbxUsluge.SelectedValue);

            HttpResponseMessage response = ugovoriService.PostResponse(ugovor);

           // AddKlijentLog(ugovor.KlijentId);
            BindUgovori();           
        }

        private void AddKlijentLog(int klijentId)
        {
            Klijenti klijent = new Klijenti();
            HttpResponseMessage response = klijentiService.GetResponse(klijentId.ToString());
            if (response.IsSuccessStatusCode)
            {
                klijent = response.Content.ReadAsAsync<Klijenti>().Result;
            }

            KlijentiLog log = new KlijentiLog();
            log.Ime = klijent.Ime;
            log.Prezime = klijent.Prezime;
            log.KorisnickoIme = klijent.KorisnickoIme;
            log.VrijemeIzmjene = DateTime.Now;

            HttpResponseMessage uslugaResponse = uslugeService.GetResponse(cbxUsluge.SelectedValue.ToString());
            if (uslugaResponse.IsSuccessStatusCode)
            {
                Usluge usluga = response.Content.ReadAsAsync<Usluge>().Result;
                log.IzvrsenaPromjena = "Promjena na paket: " + usluga.Naziv;
            }
            

            HttpResponseMessage logResponse = klijentiLogService.PostResponse(log);
        }
    }
}
