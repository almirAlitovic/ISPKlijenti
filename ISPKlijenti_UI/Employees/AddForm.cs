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

namespace ISPKlijenti_UI.Employees
{
    public partial class AddForm : Form
    {
        WebAPIHelper ulogeService = new WebAPIHelper("http://localhost:8960/", "api/Uloge");
        WebAPIHelper zaposleniciUlogeService = new WebAPIHelper("http://localhost:8960/", "api/ZaposleniciUloge");
        WebAPIHelper zaposleniciService = new WebAPIHelper("http://localhost:8960/", "api/Zaposlenici");
        private Zaposlenici zaposlenik;

        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            BindUloge();
        }

        private void BindUloge()
        {
            HttpResponseMessage response = ulogeService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                ((ListBox)ulogeList).DataSource = response.Content.ReadAsAsync<List<Uloge>>().Result;
                ((ListBox)ulogeList).DisplayMember = "Naziv";
                ((ListBox)ulogeList).ValueMember = "Id";
                ulogeList.ClearSelected();
            }
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Zaposlenici zaposlenik = new Zaposlenici();

                zaposlenik.Ime = txtIme.Text;
                zaposlenik.Prezime = txtPrezime.Text;
                zaposlenik.KorisnickoIme = txtKorisnickoIme.Text;
                zaposlenik.LozinkaSalt = UIHelper.GenerateSalt();
                zaposlenik.LozinkaHash = UIHelper.GenerateHash(txtLozinka.Text, zaposlenik.LozinkaSalt);
                zaposlenik.Aktivan = true;
                List<Uloge> uloge = ulogeList.CheckedItems.Cast<Uloge>().ToList();

                HttpResponseMessage response = zaposleniciService.PostResponse(zaposlenik);
                if (response.IsSuccessStatusCode)
                {
                    zaposlenik.Id = response.Content.ReadAsAsync<Zaposlenici>().Result.Id;
                }

                foreach (var item in uloge)
                {
                    AddUlogaZaposlenik(item.Id, zaposlenik.Id);
                }

                ClearData();

            }
        }

        private void ClearData()
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtKorisnickoIme.Text = "";
            txtLozinka.Text = "";
            ulogeList.ClearSelected();

            for (int i = 0; i < ulogeList.Items.Count; i++)
            {
                ulogeList.SetItemChecked(i, false);

            }
        }

        private void AddUlogaZaposlenik(int ulogaId, int zaposlenikId)
        {
            ZaposleniciUloge zaposlenikUloga = new ZaposleniciUloge();
            zaposlenikUloga.UlogaId = ulogaId;
            zaposlenikUloga.ZaposlenikId = zaposlenikId;

            HttpResponseMessage response = zaposleniciUlogeService.PostResponse(zaposlenikUloga);

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

        private void txtLozinka_Validating(object sender, CancelEventArgs e)
        {
            Regex rgx = new Regex(@"^[a-zA-Z0-9#$]*$");

            if (String.IsNullOrEmpty(txtLozinka.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinka, Global.GetMessage("lozinka_req"));
            }
            else if (!(rgx.IsMatch(txtLozinka.Text)))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinka, Global.GetMessage("lozinka_rgx"));
            }
            else if (txtLozinka.Text.Length <= 5)
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinka, Global.GetMessage("lozinka_len"));
            }
            else
                errorProvider.SetError(txtLozinka, "");
        }

        private void ulogeList_Validating(object sender, CancelEventArgs e)
        {
            if (ulogeList.CheckedItems.Count == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(ulogeList, Global.GetMessage("uloga_req"));
            }
            else
                errorProvider.SetError(ulogeList, "");
        }

        #endregion
    }
}
