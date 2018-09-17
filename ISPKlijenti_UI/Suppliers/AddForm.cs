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
    }
}
