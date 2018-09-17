namespace ISPKlijenti_UI.Reports
{
    partial class rptRadniNalog_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RadniNaloziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KlijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uslugeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RadniNaloziBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KlijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RadniNaloziBindingSource
            // 
            this.RadniNaloziBindingSource.DataSource = typeof(ISPKlijenti_API.Models.RadniNalozi);
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RadniNalog";
            reportDataSource1.Value = this.RadniNaloziBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "ISPKlijenti_UI.Reports.rptRadniNalog.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(879, 581);
            this.reportViewer.TabIndex = 0;
            this.reportViewer.Load += new System.EventHandler(this.reportViewer_Load);
            // 
            // rptRadniNalog_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 581);
            this.Controls.Add(this.reportViewer);
            this.Name = "rptRadniNalog_Form";
            this.Text = "Radni nalog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptRadniNalog_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RadniNaloziBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KlijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource RadniNaloziBindingSource;
        private System.Windows.Forms.BindingSource KlijentBindingSource;
        private System.Windows.Forms.BindingSource uslugeBindingSource;
    }
}