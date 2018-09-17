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

namespace ISPKlijenti_UI.Settings
{
    public partial class UslugaAddForm : Form
    {
        WebAPIHelper uslugeService = new WebAPIHelper("http://localhost:8960/", "api/Usluge");

        public UslugaAddForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Usluge usluga = new Usluge();

            usluga.Naziv = txtNaziv.Text;
            usluga.Opis = txtOpis.Text;
            usluga.Cijena = Convert.ToDecimal(txtCijena.Text);

            HttpResponseMessage response = uslugeService.PostResponse(usluga);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Usluga uspješno dodana.");
                this.Close();
            }
        }
    }
}
