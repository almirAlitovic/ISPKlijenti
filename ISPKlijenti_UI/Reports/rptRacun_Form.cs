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
    public partial class rptRacun_Form : Form
    {
        public rptRacun_Form(ISPKlijenti_API.Models.isp_Racuni_SelectById_Result racun)
        {
            InitializeComponent();
            isp_Racuni_SelectById_ResultBindingSource.DataSource = racun;
        }

        private void rtpRacun_Form_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("Racuni", isp_Racuni_SelectById_ResultBindingSource);
            reportViewer.LocalReport.DataSources.Add(rds);

            this.reportViewer.RefreshReport();
        }
    }
}
