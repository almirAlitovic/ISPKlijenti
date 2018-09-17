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

namespace ISPKlijenti_UI.Bills
{
    public partial class SpecialBillAddForm : Form
    {
        WebAPIHelper naciniPlacanjaService = new WebAPIHelper("http://localhost:8960/", "api/NaciniPlacanja");
        WebAPIHelper posebniRacuniService = new WebAPIHelper("http://localhost:8960/", "api/PosebniRacuni");


        public SpecialBillAddForm()
        {
            InitializeComponent();
        }

        private void SpecialBillAddForm_Load(object sender, EventArgs e)
        {
            BindNacinPlacanja();
        }

        private void BindNacinPlacanja()
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

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                PosebniRacuni racun = new PosebniRacuni();
                racun.Cijena = Convert.ToDecimal(txtCijena.Text);
                racun.IznosBezPDV = Convert.ToDecimal(txtIznosBezPDV.Text);
                racun.IznosSaPDV = Convert.ToDecimal(txtIznosSaPDV.Text);
                racun.Klijent = txtKlijent.Text;
                racun.Usluga = txtUsluga.Text;
                racun.Kolicina = (int)numKolicina.Value;
                racun.VrijemeIsporuke = DateTime.Now;
                racun.Placeno = checkPlaceno.Checked;
                racun.NacinPlacanjaId = Convert.ToInt32(cbxNacinPlacanja.SelectedValue);

                HttpResponseMessage response = posebniRacuniService.PostResponse(racun);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Uspješno pohranjen račun.");
                    this.Close();
                }
            }
            
        }

        private void txtCijena_TextChanged(object sender, EventArgs e)
        {
            if (txtCijena.Text != "")
            {
                txtIznosBezPDV.Text = txtCijena.Text;
                double iznosBezPDV = Convert.ToDouble(txtCijena.Text);
                double iznosSaPDV = iznosBezPDV * 1.17;
                txtIznosSaPDV.Text = iznosSaPDV.ToString();
            }
        }

        private void txtCijena_KeyPress(object sender, KeyPressEventArgs e)
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
            (txtCijena.Text.IndexOf(".") == NOT_FOUND)) return;
            e.Handled = true;
        }

    }
}
