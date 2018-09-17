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
    public partial class rptUplate_Form : Form
    {
        public rptUplate_Form()
        {
            InitializeComponent();
        }

        private void rptUplate_Form_Load(object sender, EventArgs e)
        {
            IspKlijentiDataSet ds = new IspKlijentiDataSet();
            IspKlijentiDataSetTableAdapters.isp_Uplate_SelectAllTableAdapter adapter = new IspKlijentiDataSetTableAdapters.isp_Uplate_SelectAllTableAdapter();
            adapter.Fill(ds.isp_Uplate_SelectAll);
            bindingSource.DataSource = ds.isp_Uplate_SelectAll;

            ReportDataSource rds = new ReportDataSource("Uplate", bindingSource);
            reportViewer.LocalReport.DataSources.Add(rds);

            this.reportViewer.RefreshReport();
        }

    }
}
