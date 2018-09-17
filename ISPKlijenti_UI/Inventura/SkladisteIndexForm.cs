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
    public partial class SkladisteIndexForm : Form
    {
        WebAPIHelper skladisteService = new WebAPIHelper("http://localhost:8960/", "api/Skladiste");

        public SkladisteIndexForm()
        {
            InitializeComponent();
        }

        private void SkladisteIndexForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            HttpResponseMessage response = skladisteService.getActionResponse("SelectAll");

            if (response.IsSuccessStatusCode)
            {
                dgvSkladiste.AutoGenerateColumns = false;
                dgvSkladiste.DataSource = response.Content.ReadAsAsync<List<isp_Skladiste_SelectAll_Result>>().Result;
            }
        }

        private void btnPromjeniKolicinu_Click(object sender, EventArgs e)
        {
            isp_Skladiste_SelectAll_Result skladiste = new isp_Skladiste_SelectAll_Result();
            int id = Convert.ToInt32(dgvSkladiste.SelectedRows[0].Cells[0].Value);

                SkladisteKolicinaForm f = new SkladisteKolicinaForm(id);
                f.MdiParent = this.MdiParent;
                f.Show();
   
        }

        private void SkladisteIndexForm_Activated(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
