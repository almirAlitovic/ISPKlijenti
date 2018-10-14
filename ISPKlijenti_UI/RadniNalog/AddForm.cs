using ISPKlijenti_API.Models;
using ISPKlijenti_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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
                SetReadOnly();
            }
            else
            {
                ClearKlijent();
                SetUsable();
            }
            
        }

        private void SetReadOnly()
        {
            txtIme.ReadOnly = true;
            txtPrezime.ReadOnly = true;
            txtKorisnickoIme.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtAdresa.ReadOnly = true;
            txtTelefon.ReadOnly = true;
        }

        private void SetUsable()
        {
            txtIme.ReadOnly = false;
            txtPrezime.ReadOnly = false;
            txtKorisnickoIme.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtAdresa.ReadOnly = false;
            txtTelefon.ReadOnly = false;
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
                if (nalog.KlijentId == 0)
                {
                    Klijenti k = new Klijenti();
                    k.Ime = txtIme.Text;
                    k.Prezime = txtPrezime.Text;
                    k.KorisnickoIme = txtKorisnickoIme.Text;
                    k.Adresa = txtAdresa.Text;
                    k.Aktivan = true;
                    k.Email = txtEmail.Text;
                    k.Telefon = txtTelefon.Text;

                    HttpResponseMessage klijentResponse = klijentiService.PostResponse(k);
                    if (klijentResponse.IsSuccessStatusCode)
                    {
                        HttpResponseMessage response2 = klijentiService.getActionResponse("GetLastKlijent");
                        klijent = response2.Content.ReadAsAsync<Klijenti>().Result;
                        klijent.Id = klijent.Id;
                    }

                }
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




        #region Validacija

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            Regex rgx = new Regex(@"^[a-zA-Z ]*$");

            if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, Global.GetMessage("prezime_req"));
            }
            else if (!(rgx.IsMatch(txtPrezime.Text)))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, Global.GetMessage("wrong_rgx"));
            }
            else if (txtPrezime.Text.Length < 2)
            {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, Global.GetMessage("prezime_len"));
            }
            else
                errorProvider.SetError(txtPrezime, "");
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            Regex rgx = new Regex(@"^[a-zA-Z0-9]*$");

            if (String.IsNullOrEmpty(txtKorisnickoIme.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtKorisnickoIme, Global.GetMessage("korIme_req"));
            }
            else if (!(rgx.IsMatch(txtKorisnickoIme.Text)))
            {
                e.Cancel = true;
                errorProvider.SetError(txtKorisnickoIme, Global.GetMessage("korIme_rgx"));
            }
            else if (txtKorisnickoIme.Text.Length <= 5)
            {
                e.Cancel = true;
                errorProvider.SetError(txtKorisnickoIme, Global.GetMessage("korIme_len"));
            }
            else
                errorProvider.SetError(txtKorisnickoIme, "");
        }


        private void cbxUsluga_Validating(object sender, CancelEventArgs e)
        {
            if ((int)cbxUsluga.SelectedValue == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(cbxUsluga, Global.GetMessage("odaberi"));
            }
            else
                errorProvider.SetError(cbxUsluga, "");
        }

        #endregion

        private void txtIme_Validating_1(object sender, CancelEventArgs e)
        {
            Regex rgx = new Regex(@"^[a-zA-Z]*$");

            if (String.IsNullOrEmpty(txtIme.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, Global.GetMessage("ime_req"));
            }
            else if (!(rgx.IsMatch(txtIme.Text)))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, Global.GetMessage("wrong_rgx"));
            }
            else if (txtIme.Text.Length < 2)
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, Global.GetMessage("ime_len"));
            }
            else
                errorProvider.SetError(txtIme, "");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, Global.GetMessage("email_req"));
            }
            else if (!IsValidEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, Global.GetMessage("email_rgx"));
            }
            else
            {
                errorProvider.SetError(txtEmail, "");
            }
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            Regex rgx = new Regex(@"^[a-zA-Z0-9\s\.]+$");
            if (rgx.IsMatch(txtAdresa.Text))
            {
                errorProvider.SetError(txtAdresa, "");
            }
            else if (String.IsNullOrEmpty(txtAdresa.Text.Trim()))
            {
                errorProvider.SetError(txtAdresa, "");
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(txtAdresa, Global.GetMessage("adresa_rgx"));
            }
        }


        private void cbxTehnicar_Validating(object sender, CancelEventArgs e)
        {
            if ((int)cbxTehnicar.SelectedValue == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(cbxTehnicar, Global.GetMessage("odaberi"));
            }
            else
                errorProvider.SetError(cbxTehnicar, "");
        }

        private void txtIznos_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int DECIMAL_POINT = 44;
            const int ZERO = 48;
            const int NINE = 57;
            const int NOT_FOUND = -1;

            int keyvalue = (int)e.KeyChar;

            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;
            if ((keyvalue == DECIMAL_POINT) &&
            (txtIznos.Text.IndexOf(".") == NOT_FOUND)) return;
            e.Handled = true;
        }

        private void txtTelefon_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtTelefon.Text == "(+   )       -")
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelefon, Global.GetMessage("telefon_req"));
            }
            else errorProvider.SetError(txtTelefon, "");
        }
    }
}
