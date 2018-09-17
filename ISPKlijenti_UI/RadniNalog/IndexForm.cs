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
    public partial class IndexForm : Form
    {
        WebAPIHelper radniNaloziService = new WebAPIHelper("http://localhost:8960/", "api/RadniNalozi");
        WebAPIHelper klijentiService = new WebAPIHelper("http://localhost:8960/", "api/Klijenti");
        WebAPIHelper uslugeService = new WebAPIHelper("http://localhost:8960/", "api/Usluge");
        WebAPIHelper zaposleniciService = new WebAPIHelper("http://localhost:8960/", "api/Zaposlenici");
        public IndexForm()
        {
            InitializeComponent();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            LoadData("");
        }

        private void LoadData(string klijent)
        {
            HttpResponseMessage response = radniNaloziService.getActionResponse("GetRadniNaloziIndex", klijent);
            if (response.IsSuccessStatusCode)
            {
                dgvRadniNalozi.AutoGenerateColumns = false;
                dgvRadniNalozi.DataSource = response.Content.ReadAsAsync<List<isp_RadniNalozi_Index>>().Result;
            }
        }

        private void btnStampaj_Click(object sender, EventArgs e)
        {
            RadniNalozi radniNalog = new RadniNalozi();

            HttpResponseMessage response = radniNaloziService.GetResponse(dgvRadniNalozi.SelectedRows[0].Cells[0].Value.ToString());
            if (response.IsSuccessStatusCode)
            {
                radniNalog = response.Content.ReadAsAsync<RadniNalozi>().Result;

                radniNalog.Klijenti = GetKlijent(radniNalog.KlijentId);
                radniNalog.Usluge = GetUsluga(radniNalog.UslugaId);

                Reports.rptRadniNalog_Form frm = new Reports.rptRadniNalog_Form(radniNalog, radniNalog.Klijenti, radniNalog.Usluge);
                frm.Show();
            }
        }

        private Klijenti GetKlijent(int klijentId)
        {
            HttpResponseMessage response = klijentiService.GetResponse(klijentId.ToString());
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<Klijenti>().Result;
            }
            return null;
        }

        private Usluge GetUsluga(int uslugaId)
        {
            HttpResponseMessage response = uslugeService.GetResponse(uslugaId.ToString());
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<Usluge>().Result;
            }
            return null;
        }

        private void dgvRadniNalozi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvRadniNalozi.Columns[7].Index && e.RowIndex >= 0)
            {
                StatusForm frm = new StatusForm(dgvRadniNalozi.SelectedRows[0].Cells[0].Value.ToString());
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void IndexForm_Activated(object sender, EventArgs e)
        {
            LoadData("");
        }

        private void txtKlijent_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtKlijent.Text);
        }
    }
}
