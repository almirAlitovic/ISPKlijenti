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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPKlijenti_UI.Suppliers
{
    public partial class AddForm : Form
    {
        WebAPIHelper dobavljaciService = new WebAPIHelper("http://localhost:8960/", "api/Dobavljaci");
        private Dobavljaci dobavljac;

        public AddForm()
        {
            InitializeComponent();
        }

        public AddForm(Dobavljaci dobavljac)
        {
            InitializeComponent();
            this.dobavljac = dobavljac;                    
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            ClearData();
            this.Close();
        }

        private void ClearData()
        {
            txtNaziv.Text = "";
            txtKontaktOsoba.Text = "";
            txtAdresa.Text = "";
            txtEmail.Text = "";
            txtFax.Text = "";
            txtTelefon.Text = "";
            txtWeb.Text = "";
            txtZiroRacuni.Text = "";
            txtNapomena.Text = "";
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (dobavljac == null)
            {
                dobavljac = new Dobavljaci();
            }

            dobavljac.Naziv = txtNaziv.Text;
            dobavljac.Adresa = txtAdresa.Text;
            dobavljac.KontaktOsoba = txtKontaktOsoba.Text;
            dobavljac.Email = txtEmail.Text;
            dobavljac.Telefon = txtTelefon.Text;
            dobavljac.Fax = txtFax.Text;
            dobavljac.Web = txtWeb.Text;
            dobavljac.ZiroRacuni = txtZiroRacuni.Text;
            dobavljac.Napomena = txtNapomena.Text;

            HttpResponseMessage response = new HttpResponseMessage();


            if (dobavljac.Id == 0)
            {
                response = dobavljaciService.PostResponse(dobavljac);
                this.Close();
            }
            else
            {
                response = dobavljaciService.PutResponse(dobavljac.Id, dobavljac);
                this.Close();
            }

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Zapis uspješno pohranjen.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Greška u komunikaciji sa bazom!", "Greška");
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            if (dobavljac != null)
            {
                this.Text = "Uređivanje dobavljača";

                txtNaziv.Text = dobavljac.Naziv;
                txtAdresa.Text = dobavljac.Adresa;
                txtKontaktOsoba.Text = dobavljac.KontaktOsoba;
                txtEmail.Text = dobavljac.Email;
                txtTelefon.Text = dobavljac.Telefon;
                txtFax.Text = dobavljac.Fax;
                txtWeb.Text = dobavljac.Web;
                txtZiroRacuni.Text = dobavljac.ZiroRacuni;
                txtNapomena.Text = dobavljac.Napomena;
            }       
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            Regex rgx = new Regex(@"^[a-zA-Z0-9\s\.]+$");

            if (String.IsNullOrEmpty(txtNaziv.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Global.GetMessage("obavezno_polje"));
            }
            else if (!(rgx.IsMatch(txtNaziv.Text)))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Global.GetMessage("wrong_rgx"));
            }
            else if (txtNaziv.Text.Length < 2)
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Global.GetMessage("naziv_len"));
            }
            else
                errorProvider.SetError(txtNaziv, "");
        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            Regex rgx = new Regex(@"^[a-zA-Z0-9\s\.]+$");
            if (String.IsNullOrEmpty(txtAdresa.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Global.GetMessage("obavezno_polje"));
            }
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

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
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
