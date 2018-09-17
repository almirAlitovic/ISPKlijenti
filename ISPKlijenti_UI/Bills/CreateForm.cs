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

namespace ISPKlijenti_UI.Bills
{
    public partial class CreateForm : Form
    {
        WebAPIHelper racuniService = new WebAPIHelper("http://localhost:8960/", "api/Racuni");
        WebAPIHelper mjeseciService = new WebAPIHelper("http://localhost:8960/", "api/Mjeseci");
        WebAPIHelper uslugeService = new WebAPIHelper("http://localhost:8960/", "api/Usluge");
        WebAPIHelper klijentiService = new WebAPIHelper("http://localhost:8960/", "api/Klijenti");
        WebAPIHelper naciniPlacanjaService = new WebAPIHelper("http://localhost:8960/", "api/NaciniPlacanja");
        WebAPIHelper uplateService = new WebAPIHelper("http://localhost:8960/", "api/Uplate");



        public CreateForm()
        {
            InitializeComponent();
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            BindMjeseci();
            BindUsluge();
            BindKlijenti();
            BindNaciniPlacanja();
        }

        private void BindNaciniPlacanja()
        {
            HttpResponseMessage response = naciniPlacanjaService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<NaciniPlacanja> naciniPlacanja = new List<NaciniPlacanja>();
                naciniPlacanja = response.Content.ReadAsAsync<List<NaciniPlacanja>>().Result;
                naciniPlacanja.Insert(0, new NaciniPlacanja());
                cbxNacinPlacanja.DataSource = naciniPlacanja;
                cbxNacinPlacanja.DisplayMember = "Naziv";
                cbxNacinPlacanja.ValueMember = "Id";
            }
        }

        private void BindUsluge()
        {
            HttpResponseMessage response = uslugeService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Usluge> usluge = new List<Usluge>();
                usluge = response.Content.ReadAsAsync<List<Usluge>>().Result;
                usluge.Insert(0, new Usluge());
                cbxUsluga.DataSource = usluge;
                cbxUsluga.DisplayMember = "Naziv";
                cbxUsluga.ValueMember = "Id";
            }
        }

        private void BindKlijenti()
        {
            HttpResponseMessage response = klijentiService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Klijenti> klijenti = new List<Klijenti>();
                klijenti = response.Content.ReadAsAsync<List<Klijenti>>().Result;
                klijenti.Insert(0, new Klijenti());
                cbxKlijent.DataSource = klijenti;
                cbxKlijent.DisplayMember = "Ime";
                cbxKlijent.ValueMember = "Id";
            }
        }

        private void BindMjeseci()
        {
            HttpResponseMessage response = mjeseciService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Mjeseci> mjeseci = new List<Mjeseci>();
                mjeseci = response.Content.ReadAsAsync<List<Mjeseci>>().Result;
                mjeseci.Insert(0, new Mjeseci());
                cbxMjesec.DataSource = mjeseci;
                cbxMjesec.DisplayMember = "Naziv";
                cbxMjesec.ValueMember = "Id";
            }
        }

        private void cbxKlijent_Format(object sender, ListControlConvertEventArgs e)
        {
            string ime = ((Klijenti)e.ListItem).Ime;
            string prezime = ((Klijenti)e.ListItem).Prezime;
            e.Value = ime + " " + prezime;
        }

        private void cbxUsluga_SelectedIndexChanged(object sender, EventArgs e)
        {
            HttpResponseMessage response = uslugeService.GetResponse(cbxUsluga.SelectedValue.ToString());
            if (response.IsSuccessStatusCode)
            {
                Usluge usluga = new Usluge();
                usluga = response.Content.ReadAsAsync<Usluge>().Result;
                txtCijena.Text = usluga.Cijena.ToString();
                PopuniIznose();
            }
        }

        private void numKolicina_ValueChanged(object sender, EventArgs e)
        {
            PopuniIznose();
        }

        private void PopuniIznose()
        {
            decimal iznosBezPDV = Convert.ToDecimal(txtCijena.Text) * (numKolicina.Value);
            decimal iznosSaPDV = iznosBezPDV * (decimal)1.17;

            txtIznosBezPDV.Text = iznosBezPDV.ToString();
            txtIznosSaPDV.Text = iznosSaPDV.ToString();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Racuni racun = new Racuni();
                racun.KlijentId = Convert.ToInt32(cbxKlijent.SelectedValue);
                racun.UslugaId = Convert.ToInt32(cbxUsluga.SelectedValue);
                racun.MjesecId = Convert.ToInt32(cbxMjesec.SelectedValue);
                racun.Kolicina = (int)numKolicina.Value;
                racun.IznosBezPDV = Convert.ToDecimal(txtIznosBezPDV.Text);
                racun.IznosSaPDV = Convert.ToDecimal(txtIznosSaPDV.Text);
                racun.VrijemeIsporuke = DateTime.Now;
                racun.NacinPlacanjaId = Convert.ToInt32(cbxNacinPlacanja.SelectedValue);
                racun.Placeno = checkPlaceno.Checked;

                if (racun.Placeno == true)
                {
                    Uplate uplata = new Uplate();
                    uplata.Iznos = racun.IznosSaPDV;
                    uplata.KlijentId = racun.KlijentId;
                    uplata.UslugaId = racun.UslugaId;
                    HttpResponseMessage uplateResponse = uplateService.PostResponse(uplata);
                }

                HttpResponseMessage response = racuniService.PostResponse(racun);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Račun uspješno generisan.");
                    this.Close();
                }
            }          

        }
    }
}
