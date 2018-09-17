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

namespace ISPKlijenti_UI.Inventura
{
    public partial class SkladisteKolicinaForm : Form
    {
        WebAPIHelper skladisteService = new WebAPIHelper("http://localhost:8960/", "api/Skladiste");

        private Skladiste skladiste;
        private int skladisteId;

        public SkladisteKolicinaForm()
        {
            InitializeComponent();
        }

        public SkladisteKolicinaForm(int id)
        {
            InitializeComponent();
            this.skladisteId = id;
        }

        private void SkladisteKolicinaForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = skladisteService.GetResponse(skladisteId.ToString());
            if (response.IsSuccessStatusCode)
            {
                skladiste = response.Content.ReadAsAsync<Skladiste>().Result;
                numKolicina.Value = Convert.ToDecimal(skladiste.Kolicina);
            }
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            skladiste.Kolicina = Convert.ToInt32(numKolicina.Value);
            HttpResponseMessage response = skladisteService.PutResponse(skladisteId, skladiste);
            if (response.IsSuccessStatusCode)
            {
                this.Close();
            }

        }
    }
}
