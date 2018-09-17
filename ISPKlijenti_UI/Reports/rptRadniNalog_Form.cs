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
    public partial class rptRadniNalog_Form : Form
    {
        public rptRadniNalog_Form(ISPKlijenti_API.Models.RadniNalozi radniNalog, Klijenti klijent, Usluge usluga)
        {
            InitializeComponent();
            RadniNaloziBindingSource.DataSource = radniNalog;
            KlijentBindingSource.DataSource = klijent;
        }

        private void rptRadniNalog_Form_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("RadniNalog", RadniNaloziBindingSource);
            reportViewer.LocalReport.DataSources.Add(rds);

            ReportDataSource rds2 = new ReportDataSource("Klijent", KlijentBindingSource);
            reportViewer.LocalReport.DataSources.Add(rds2);

            ReportDataSource rds3 = new ReportDataSource("Usluga", uslugeBindingSource);
            reportViewer.LocalReport.DataSources.Add(rds3);

            this.reportViewer.RefreshReport();
        }

        private void reportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
