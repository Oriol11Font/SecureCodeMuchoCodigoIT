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
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            cryRpt.RecordSelectionFormula = "{Comando.idUser} = " + textBox1.Text + "";


            int printerId = 0;
            do printerId++;
            while (PrinterSettings.InstalledPrinters[printerId] != "Microsoft Print to PDF");

            cryRpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"C:\Users\pauco\Desktop\Card.pdf");
        }
    }
}
