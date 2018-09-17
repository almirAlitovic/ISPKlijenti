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

namespace ISPKlijenti_UI.RadniNalog
{
    
    public partial class StatusForm : Form
    {
        WebAPIHelper radniNaloziService = new WebAPIHelper("http://localhost:8960/", "api/RadniNalozi");
        WebAPIHelper statusiNalogaService = new WebAPIHelper("http://localhost:8960/", "api/StatusiNaloga");
        private string radniNalogId;

        public StatusForm()
        {
            InitializeComponent();
        }

        public StatusForm(string radniNalogId)
        {
            InitializeComponent();
            this.radniNalogId = radniNalogId;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatusForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = statusiNalogaService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                cbxStatusNaloga.DataSource = response.Content.ReadAsAsync<List<StatusiNaloga>>().Result;
                cbxStatusNaloga.DisplayMember = "Naziv";
                cbxStatusNaloga.ValueMember = "Id";
            }
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            RadniNalozi radniNalog = new RadniNalozi();

            HttpResponseMessage response = radniNaloziService.GetResponse(radniNalogId);

            if (response.IsSuccessStatusCode)
            {
                radniNalog = response.Content.ReadAsAsync<RadniNalozi>().Result;
                radniNalog.StatusNalogaId = Convert.ToInt32(cbxStatusNaloga.SelectedValue);

                HttpResponseMessage putResponse = radniNaloziService.PutResponse(Convert.ToInt32(radniNalogId), radniNalog);
            }
            else
            {
                MessageBox.Show("Dosšlo je do greške u komunikaciji.", "Greška!");
            }
            this.Close();

        }
    }
}
