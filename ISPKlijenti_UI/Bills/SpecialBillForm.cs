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

namespace ISPKlijenti_UI.Bills
{
    public partial class SpecialBillForm : Form
    {
        WebAPIHelper posebniRacuniService = new WebAPIHelper("http://localhost:8960/", "api/PosebniRacuni");

        public SpecialBillForm()
        {
            InitializeComponent();
        }

        private void SpecialBillForm_Load(object sender, EventArgs e)
        {
            LoadPosebniRacuni();
        }

        private void LoadPosebniRacuni()
        {
            HttpResponseMessage response = posebniRacuniService.getActionResponse("GetPosebniRacuniIndex");
            if (response.IsSuccessStatusCode)
            {
                dgvPosebniRacuni.AutoGenerateColumns = false;
                dgvPosebniRacuni.DataSource = response.Content.ReadAsAsync<List<isp_PosebniRacuni_SelectAll_Result>>().Result;
            }
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            SpecialBillAddForm f = new SpecialBillAddForm();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btnStampaj_Click(object sender, EventArgs e)
        {
            isp_PosebniRacuni_SelectById_Result racun = new isp_PosebniRacuni_SelectById_Result();
            HttpResponseMessage response = posebniRacuniService.getActionResponse("GetPosebniRacuniById", dgvPosebniRacuni.SelectedRows[0].Cells[0].Value.ToString());
            if (response.IsSuccessStatusCode)
            {
                racun = response.Content.ReadAsAsync<isp_PosebniRacuni_SelectById_Result>().Result;

                Reports.rptPosebniRacun_Form frm = new Reports.rptPosebniRacun_Form(racun);
                frm.Show();
            }
        }
    }
}
