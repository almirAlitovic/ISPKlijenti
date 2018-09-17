using ISPKlijenti_API.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPKlijenti_UI.Reports
{
    public partial class rptPosebniRacun_Form : Form
    {
        public rptPosebniRacun_Form(isp_PosebniRacuni_SelectById_Result racun)
        {
            InitializeComponent();
            bindingSource.DataSource = racun;
        }

        private void rptPosebniRacun_Form_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("PosebniRacun", bindingSource);
            reportViewer.LocalReport.DataSources.Add(rds);

            this.reportViewer.RefreshReport();
        }
    }
}
