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

namespace ISPKlijenti_UI.RadniNalog
{
    public partial class AddForm : Form
    {
        WebAPIHelper klijentiService = new WebAPIHelper("http://localhost:8960/", "api/Klijenti");
        WebAPIHelper uslugeService = new WebAPIHelper("http://localhost:8960/", "api/Usluge");
        WebAPIHelper zaposleniciService = new WebAPIHelper("http://localhost:8960/", "api/Zaposlenici");
        WebAPIHelper zaposleniciUlogeService = new WebAPIHelper("http://localhost:8960/", "api/ZaposleniciUloge");
        WebAPIHelper radniNaloziService = new WebAPIHelper("http://localhost:8960/", "api/RadniNalozi");

        public object radniNalog { get; private set; }

        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            BindUsluge();
            BindTehnicari();
            BindKlijenti();
        }

        private void BindKlijenti()
        {
            HttpResponseMessage response = klijentiService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Klijenti> klijenti = response.Content.ReadAsAsync<List<Klijenti>>().Result;
                klijenti.Insert(0, new Klijenti());
                cbxPostojeciKlijenti.DataSource = klijenti;
                cbxPostojeciKlijenti.DisplayMember = "Ime";
                cbxPostojeciKlijenti.ValueMember = "Id";
            }
        }

        private void BindUsluge()
        {
            HttpResponseMessage response = uslugeService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Usluge> usluge = response.Content.ReadAsAsync<List<Usluge>>().Result;
                usluge.Insert(0, new Usluge());
                cbxUsluga.DataSource = usluge;
                cbxUsluga.DisplayMember = "Naziv";
                cbxUsluga.ValueMember = "Id";
            }
        }

        private void BindTehnicari()
        {
            HttpResponseMessage response = zaposleniciUlogeService.getActionResponse("GetZaposlenikByUlogaId", "4");
            if (response.IsSuccessStatusCode)
            {
                List<Zaposlenici> tehnicari = response.Content.ReadAsAsync<List<Zaposlenici>>().Result;
                tehnicari.Insert(0, new Zaposlenici());
                cbxTehnicar.DataSource = tehnicari;
                cbxTehnicar.DisplayMember = "Ime";
                cbxTehnicar.ValueMember = "Id";
            }
        }

        private void cbxFormat(object sender, ListControlConvertEventArgs e)
        {
            string ime = ((Zaposlenici)e.ListItem).Ime;
            string prezime = ((Zaposlenici)e.ListItem).Prezime;
            e.Value = ime + " " + prezime;
        }

        private void cbxPostojeciFormat(object sender, ListControlConvertEventArgs e)
        {
            string ime = ((Klijenti)e.ListItem).Ime;
            string prezime = ((Klijenti)e.ListItem).Prezime;
            e.Value = ime + " " + prezime;
        }

        //private void cbxPostojeciKlijenti_ValueMemberChanged(object sender, EventArgs e)
        //{
        //    string klijentId = cbxPostojeciKlijenti.ValueMember;
        //    KlijentLoad(klijentId);
        //}

        Klijenti klijent = new Klijenti();
        private void KlijentLoad(string id)
        {
            HttpResponseMessage response = klijentiService.GetResponse(id);
            if (response.IsSuccessStatusCode)
            {
                klijent = response.Content.ReadAsAsync<Klijenti>().Result;
                txtIme.Text = klijent.Ime;
                txtPrezime.Text = klijent.Prezime;
                txtKorisnickoIme.Text = klijent.KorisnickoIme;
                txtEmail.Text = klijent.Email;
                txtAdresa.Text = klijent.Adresa;
                txtTelefon.Text = klijent.Telefon;
            }
        }

        private void cbxPostojeciKlijenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPostojeciKlijenti.SelectedIndex != 0)
            {
                string klijentId = cbxPostojeciKlijenti.SelectedIndex.ToString();
                KlijentLoad(klijentId);
            }
            else
            {
                ClearKlijent();
            }
            
        }

        private void ClearKlijent()
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtKorisnickoIme.Text = "";
            txtEmail.Text = "";
            txtAdresa.Text = "";
            txtTelefon.Text = "";
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            ClearKlijent();
            cbxUsluga.SelectedIndex = 0;
            cbxTehnicar.SelectedIndex = 0;
            cbxPostojeciKlijenti.SelectedIndex = 0;
            txtOpisPosla.Text = "";
            txtIznos.Text = "";
        }


        ISPKlijenti_API.Models.RadniNalozi nalog = new ISPKlijenti_API.Models.RadniNalozi();
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            SacuvajRadniNalog();
        }

        Usluge usluga = new Usluge();
        private void SacuvajRadniNalog()
        {
            if (this.ValidateChildren())
            {

                nalog.KlijentId = Convert.ToInt32(cbxPostojeciKlijenti.SelectedValue);
                nalog.StatusNalogaId = 1;
                nalog.DatumKreiranja = DateTime.Now;
                nalog.Detalji = txtOpisPosla.Text;
                
                if (cbxUsluga.SelectedIndex != 0)
                {
                    nalog.UslugaId = Convert.ToInt32(cbxUsluga.SelectedValue);
                    HttpResponseMessage uslugaResponse = uslugeService.GetResponse(nalog.UslugaId.ToString());
                    usluga = uslugaResponse.Content.ReadAsAsync<Usluge>().Result;
                }
                nalog.ZaposlenikId = Convert.ToInt32(cbxTehnicar.SelectedValue);
                nalog.Adresa = txtAdresa.Text;
                nalog.IznosZaNaplatu = Convert.ToDouble(txtIznos.Text);

                HttpResponseMessage response = radniNaloziService.PostResponse(nalog);

                if (response.IsSuccessStatusCode)
                {
                    ClearKlijent();
                    cbxUsluga.SelectedIndex = 0;
                    cbxTehnicar.SelectedIndex = 0;
                    cbxPostojeciKlijenti.SelectedIndex = 0;
                    txtOpisPosla.Text = "";
                    txtIznos.Text = "";

                    MessageBox.Show("Nalog uspješno kreiran.", "Poruka");
                }

            }
        }

        private void btnStampajSacuvaj_Click(object sender, EventArgs e)
        {
            SacuvajRadniNalog();
            Reports.rptRadniNalog_Form f = new Reports.rptRadniNalog_Form(nalog, klijent ,usluga);
            f.Show();
        }
    }
}
