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
    public partial class NabavkaForm : Form
    {
        WebAPIHelper nabavkeService = new WebAPIHelper("http://localhost:8960/", "api/Nabavka");

        public NabavkaForm()
        {
            InitializeComponent();
        }

        private void NabavkaForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            HttpResponseMessage response = nabavkeService.getActionResponse("GetNabavkaById");
            if (response.IsSuccessStatusCode)
            {
                dgvNabavke.AutoGenerateColumns = false;
                dgvNabavke.DataSource = response.Content.ReadAsAsync<List<isp_Nabavka_SelectById_Result>>().Result;
            }
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            string datum1 = datumOd.Value.ToString("yyyy-MM-dd");
            string datum2 = datumDo.Value.ToString("yyyy-MM-dd");

            HttpResponseMessage response = nabavkeService.getActionResponse2("GetNabavkaByDatum", datum1, datum2);
            if (response.IsSuccessStatusCode)
            {
                dgvNabavke.AutoGenerateColumns = false;
                dgvNabavke.DataSource = response.Content.ReadAsAsync<List<isp_Nabavka_SelectById_Result>>().Result;
            }
        }
    }
}
