using ISPKlijenti_API.Models;
using ISPKlijenti_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPKlijenti_UI.Clients
{
    public partial class InstaliranaOpremaForm : Form
    {
        WebAPIHelper instaliranaOpremaService = new WebAPIHelper("http://localhost:8960/", "api/InstaliranaOprema");

        public InstaliranaOpremaForm()
        {
            InitializeComponent();
        }

        private void InstaliranaOpremaForm_Load(object sender, EventArgs e)
        {
            LoadInstaliranaOprema();
        }

        private void LoadInstaliranaOprema()
        {
            HttpResponseMessage response = instaliranaOpremaService.getActionResponse("GetInstaliranaOpremaByKlijent", txtKlijent.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                dgvInstaliranaOprema.AutoGenerateColumns = false;
                dgvInstaliranaOprema.DataSource = response.Content.ReadAsAsync<List<isp_InstaliranaOprema_SelectyByKlijent_Result>>().Result;
            }
        }

        private void txtKlijent_TextChanged(object sender, EventArgs e)
        {
            LoadInstaliranaOprema();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            InstaliranaOpremaAddForm f = new InstaliranaOpremaAddForm();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void InstaliranaOpremaForm_Activated(object sender, EventArgs e)
        {
            LoadInstaliranaOprema();
        }


        private void dgvInstaliranaOprema_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InstaliranaOprema oprema = new InstaliranaOprema();

            string instaliranoId = dgvInstaliranaOprema.SelectedRows[0].Cells[0].Value.ToString();

            HttpResponseMessage response = instaliranaOpremaService.GetResponse(instaliranoId);
            if (response.IsSuccessStatusCode)
            {
                oprema = response.Content.ReadAsAsync<InstaliranaOprema>().Result;

                if (oprema.Slika != null)
                {
                    var ms = new MemoryStream(oprema.Slika);
                    Image image = Image.FromStream(ms);
                    pictureBox.Image = image;
                }              
            }
        }
    }
}
