using System;
using System.Data;
using System.Windows.Forms;
using LibreriaClases;
using BasicForms;
using System.Linq;
using System.Collections.Generic;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;

namespace Users
{
    public partial class ReportViewer : BaseForm
    {
        private int _idUser { get; set; }
        private DataAccessClass _dac = new DataAccessClass();
        UserReport rpt;

        UserEntities db;
        List<User> usr;

        public ReportViewer()
        {
            FormTitle = @"User Reports";
            InitializeComponent();
        }

        private void MostrarReport(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Visible = false;
                ReportDocument cryRpt = new ReportDocument();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();

                cryRpt.Load("../Users/UserReport.rpt");
                crConnectionInfo.ServerName = "34.77.100.91";
                crConnectionInfo.IntegratedSecurity = false;
                crConnectionInfo.UserID = "sqlserver";
                crConnectionInfo.Password = "gutinomola";
                crConnectionInfo.DatabaseName = "securecode";
                Tables CrTables = cryRpt.Database.Tables;

                foreach (Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }

                cryRpt.RecordSelectionFormula = "{Comando.idUser} = " + textBox1.Text + "";

                crystalReportViewer1.ReportSource = cryRpt;
                saveButton.Enabled = true;

                int printerId = 0;
                do printerId++;
                while (PrinterSettings.InstalledPrinters[printerId] != "Microsoft Print to PDF");

                cryRpt.ExportToDisk(ExportFormatType.PortableDocFormat, @"C:\Users\pauco\Desktop\Card.pdf");
            } catch
            {
                errorLabel.Text = @"Error mostrant report";
                errorLabel.Visible = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
