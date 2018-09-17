using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISPKlijenti_API.Models;
using ISPKlijenti_UI.Util;
using System.Net.Http;

namespace ISPKlijenti_UI.Employees
{
    public partial class EditForm : Form
    {
        WebAPIHelper ulogeService = new WebAPIHelper("http://localhost:8960/", "api/Uloge");
        WebAPIHelper zaposleniciUlogeService = new WebAPIHelper("http://localhost:8960/", "api/ZaposleniciUloge");
        WebAPIHelper zaposleniciService = new WebAPIHelper("http://localhost:8960/", "api/Zaposlenici");

        private Zaposlenici zaposlenik;

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(Zaposlenici zaposlenik)
        {
            InitializeComponent();
            this.zaposlenik = zaposlenik;   
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

        private void FillData()
        {
            txtIme.Text = zaposlenik.Ime;
            txtPrezime.Text = zaposlenik.Prezime;
            txtKorisnickoIme.Text = zaposlenik.KorisnickoIme;
            //txtLozinka.Text = "";
            HttpResponseMessage response = zaposleniciUlogeService.getActionResponse("GetUlogeByZaposlenikId", zaposlenik.Id.ToString());
            if (response.IsSuccessStatusCode)
            {
                List<Uloge> uloge = response.Content.ReadAsAsync<List<Uloge>>().Result;

                foreach (var item in uloge)
                {
                    ulogeList.SetItemChecked(item.Id, true);
                }
            }   

        }


        private void UpdateUlogaZaposlenik(int ulogaId, int zaposlenikId)
        {
            ZaposleniciUloge zaposlenikUloga = new ZaposleniciUloge();
            zaposlenikUloga.UlogaId = ulogaId;
            zaposlenikUloga.ZaposlenikId = zaposlenikId;

            HttpResponseMessage response = zaposleniciUlogeService.PutResponse(zaposlenikUloga.Id, zaposlenikUloga);

        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            BindUloge();
            FillData();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (zaposlenik != null)
                {
                    zaposlenik.Ime = txtIme.Text;
                    zaposlenik.Prezime = txtPrezime.Text;
                    zaposlenik.KorisnickoIme = txtKorisnickoIme.Text;
                    if (txtLozinka.Text != "")
                    {
                        zaposlenik.LozinkaHash = UIHelper.GenerateHash(txtLozinka.Text, zaposlenik.LozinkaSalt);
                    }                    
                    List<Uloge> uloge = ulogeList.CheckedItems.Cast<Uloge>().ToList();
                    HttpResponseMessage response = zaposleniciService.PutResponse(zaposlenik.Id, zaposlenik);

                    Close();
                }
            }
        }
    }
}
