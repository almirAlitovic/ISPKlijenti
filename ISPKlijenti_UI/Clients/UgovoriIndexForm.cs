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

namespace ISPKlijenti_UI.Clients
{
    public partial class UgovoriIndexForm : Form
    {

        WebAPIHelper klijentiService = new WebAPIHelper("http://localhost:8960/", "api/Klijenti");
        WebAPIHelper uslugeService = new WebAPIHelper("http://localhost:8960/", "api/Usluge");
        WebAPIHelper ugovoriService = new WebAPIHelper("http://localhost:8960/", "api/Ugovori");


        public UgovoriIndexForm()
        {
            InitializeComponent();
        }

        private void UgovoriIndexForm_Load(object sender, EventArgs e)
        {
            BindUgovori();            
        }

        private void BindUgovori()
        {
            HttpResponseMessage response = ugovoriService.getActionResponse("GetUgovoriByKlijent", ""); //sredi 
            if (response.IsSuccessStatusCode)
            {
                dgvUgovori.AutoGenerateColumns = false;
                dgvUgovori.DataSource = response.Content.ReadAsAsync<List<isp_Ugovori_Index>>().Result;
            }
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            HttpResponseMessage response = ugovoriService.getActionResponse("GetUgovoriByKlijent", txtImePrezime.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                dgvUgovori.DataSource = response.Content.ReadAsAsync<List<isp_Ugovori_Index>>().Result;
            }
        }


        private void txtBrojUgovora_TextChanged(object sender, EventArgs e)
        {
            HttpResponseMessage response = ugovoriService.getActionResponse("GetUgovoriByBrojUgovora", txtBrojUgovora.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                dgvUgovori.DataSource = response.Content.ReadAsAsync<List<isp_Ugovori_Index>>().Result;
            }
        }
    }
}
