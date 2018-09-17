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

namespace ISPKlijenti_UI.Clients
{
    public partial class AddForm : Form
    {
        WebAPIHelper klijentiService = new WebAPIHelper("http://localhost:8960/", "api/Klijenti");
        WebAPIHelper uslugeService = new WebAPIHelper("http://localhost:8960/", "api/Usluge");
        WebAPIHelper ugovoriService = new WebAPIHelper("http://localhost:8960/", "api/Ugovori");



        private Klijenti klijent { get; set; }
        public AddForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        public AddForm(Klijenti klijent)
        {
            InitializeComponent();
            this.klijent = klijent;
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            txtAdresa.Text = "";
            txtEmail.Text = "";
            txtIme.Text = "";
            txtKorisnickoIme.Text = "";
            txtPrezime.Text = "";
            txtTelefon.Text = "";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (klijent == null)
                {
                    klijent = new Klijenti();
                }
                klijent.Ime = txtIme.Text;
                klijent.Prezime = txtPrezime.Text;
                klijent.KorisnickoIme = txtKorisnickoIme.Text;
                klijent.Adresa = txtAdresa.Text;
                klijent.Aktivan = true;
                klijent.Email = txtEmail.Text;
                klijent.Telefon = txtTelefon.Text;

                HttpResponseMessage response = new HttpResponseMessage();


                if (klijent.Id == 0)
                {
                    response = klijentiService.PostResponse(klijent);
                }
                else
                {
                    response = klijentiService.PutResponse(klijent.Id, klijent);
                    this.Close();
                } 

                if (response.IsSuccessStatusCode)
                {
                    ClearData();
                }
            }
                
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            if (klijent != null)
            {
                lblBrojUgovora.Visible = true;
                txtBrojUgovora.Visible = true;
                this.Text = "Izmjena podataka postojećeg klijenta";
                FillData();
                btnDodaj.Text = "Snimi";
            }
        }

        private void FillData()
        {
            txtIme.Text = klijent.Ime;
            txtPrezime.Text = klijent.Prezime;
            txtKorisnickoIme.Text = klijent.KorisnickoIme;
            txtEmail.Text = klijent.Email;
            txtAdresa.Text = klijent.Adresa;
            txtTelefon.Text = klijent.Telefon;

            HttpResponseMessage response = ugovoriService.getActionResponse("GetUgovoriByKlijentId", klijent.Id.ToString());
            if (response.IsSuccessStatusCode)
            {
                txtBrojUgovora.Text = response.Content.ReadAsAsync<isp_Ugovori_Index>().Result.BrojUgovora.ToString();
            }
        }

        private void btnUgovori_Click(object sender, EventArgs e)
        {
            UgovoriAddForm frm = new UgovoriAddForm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        #region Validacija
        private void txtIme_Validating(object sender, CancelEventArgs e)
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

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (txtTelefon.Text == "(+   )       -")
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelefon, Global.GetMessage("telefon_req"));
            }
            else errorProvider.SetError(txtTelefon, "");
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

        #endregion

    }
}
