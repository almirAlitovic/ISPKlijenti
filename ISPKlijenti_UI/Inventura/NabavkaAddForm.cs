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

namespace ISPKlijenti_UI.Inventura
{
    public partial class NabavkaAddForm : Form
    {
        WebAPIHelper nabavkeService = new WebAPIHelper("http://localhost:8960/", "api/Nabavka");
        WebAPIHelper opremaService = new WebAPIHelper("http://localhost:8960/", "api/OpremaMaterijal");
        WebAPIHelper skladisteService = new WebAPIHelper("http://localhost:8960/", "api/Skladiste");



        public NabavkaAddForm()
        {
            InitializeComponent();
        }

        private void NabavkaAddForm_Load(object sender, EventArgs e)
        {
            BindOprema();
        }

        private void BindOprema()
        {
            HttpResponseMessage response = opremaService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<OpremaMaterijal> opremaMaterijali = response.Content.ReadAsAsync<List<OpremaMaterijal>>().Result;
                opremaMaterijali.Insert(0, new OpremaMaterijal());
                cbxArtikal.DataSource = opremaMaterijali;
                cbxArtikal.ValueMember = "Id";
                cbxArtikal.DisplayMember = "Naziv";
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                int opremaId = Convert.ToInt32(cbxArtikal.SelectedValue);

                Nabavka nabavka = new Nabavka();
                nabavka.OpremaMaterijalId = opremaId;
                nabavka.Kolicina = Convert.ToInt32(numKolicina.Value);
                nabavka.NabavnaCijena = Convert.ToDecimal(txtCijena.Text);
                nabavka.DatumPrijema = DateTime.Now;
                nabavka.ZaposlenikId = Global.logiraniZaposlenik.Id;


                HttpResponseMessage postResponse = nabavkeService.PostResponse(nabavka);


                Skladiste skladiste;

                HttpResponseMessage skladisteResponse;

                HttpResponseMessage response = skladisteService.getActionResponse("GetSkladisteByOpremaId", opremaId.ToString());
                if (response.IsSuccessStatusCode)
                {

                    skladiste = response.Content.ReadAsAsync<Skladiste>().Result;
                    skladiste.OpremaMaterijalId = opremaId;
                    skladiste.Kolicina += Convert.ToInt32(numKolicina.Value);
                    if (txtLokacija.Text != "")
                    {
                        skladiste.Lokacija = txtLokacija.Text;
                    }

                    skladisteResponse = skladisteService.PutResponse(skladiste.Id, skladiste);                  
                    ClearData();             
                }
                else
                {
                    skladiste = new Skladiste();
                    skladiste.OpremaMaterijalId = opremaId;
                    skladiste.Kolicina = Convert.ToInt32(numKolicina.Value);
                    if (txtLokacija.Text != "")
                    {
                        skladiste.Lokacija = txtLokacija.Text;
                    }
                    skladisteResponse = skladisteService.PostResponse(skladiste);
                    ClearData();
                }
            }     

        }

        private void ClearData()
        {
            cbxArtikal.SelectedIndex = 0;
            numKolicina.Value = 0;
            txtCijena.Text = "";
            txtLokacija.Text = "";
        }

        private void cbxArtikal_SelectedIndexChanged(object sender, EventArgs e)
        {
            HttpResponseMessage response = skladisteService.getActionResponse("GetSkladisteByOpremaId", cbxArtikal.SelectedValue.ToString());
            if (response.IsSuccessStatusCode)
            {
                txtLokacija.Text = response.Content.ReadAsAsync<Skladiste>().Result.Lokacija;
            }
            else
            {
                txtLokacija.Text = "";
            }
        }
    }
}
