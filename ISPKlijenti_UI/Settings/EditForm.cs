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
    public partial class EditForm : Form
    {
        WebAPIHelper uslugeService = new WebAPIHelper("http://localhost:8960/", "api/Usluge");
        private Usluge usluga;

        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            LoadUsluge();
        }

        private void LoadUsluge()
        {
            HttpResponseMessage response = uslugeService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                dgvUsluge.AutoGenerateColumns = false;
                dgvUsluge.DataSource = response.Content.ReadAsAsync<List<Usluge>>().Result;
            }
        }

        //private void dgvUsluge_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    HttpResponseMessage response = uslugeService.GetResponse(dgvUsluge.SelectedRows[0].Cells[0].Value.ToString());
        //    if (response.IsSuccessStatusCode)
        //    {
        //        usluga = response.Content.ReadAsAsync<Usluge>().Result;
        //        txtCijena.Text = usluga.Cijena.ToString();
        //        txtOpis.Text = usluga.Opis;
        //    }         
        //}

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (usluga != null)
            {
                if (this.ValidateChildren())
                {
                    usluga.Opis = txtOpis.Text;
                    usluga.Cijena = Convert.ToDecimal(txtCijena.Text.Trim());

                    HttpResponseMessage response = uslugeService.PutResponse(usluga.Id, usluga);

                    LoadUsluge();
                }               
            }
        }

        private void dgvUsluge_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvUsluge.SelectedRows[0].Cells[0].Value);
            if (id > 0)
            {
                HttpResponseMessage response = uslugeService.GetResponse(id.ToString());
                if (response.IsSuccessStatusCode)
                {
                    usluga = response.Content.ReadAsAsync<Usluge>().Result;
                    txtCijena.Text = usluga.Cijena.ToString();
                    txtOpis.Text = usluga.Opis;
                }
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            UslugaAddForm f = new UslugaAddForm();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void EditForm_Activated(object sender, EventArgs e)
        {
            LoadUsluge();
        }
    }
}
