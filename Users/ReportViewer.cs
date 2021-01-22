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
        private DataAccessClass _dac = new DataAccessClass();
        private ReportDocument cryRpt;

        public ReportViewer(String username, String imgProfile)
        {
            FormTitle = "User Report";
            UserName = username;
            profileImg = imgProfile;
            InitializeComponent();
        }

        private void MostrarReport(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Visible = false;
                cryRpt = new ReportDocument();
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

                cryRpt.RecordSelectionFormula = "{Comando.CodeUser} = '" + textBox1.Text + "'";

                crystalReportViewer1.ReportSource = cryRpt;
                saveButton.Enabled = true;
            } catch
            {
                errorLabel.Text = @"Error mostrant report";
                errorLabel.Visible = true;
            }
            
        }

        private void SaveReport(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = @"Selecciona la ubicació on desar el report";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = @"Pdf Files|*.pdf";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cryRpt.ExportToDisk(ExportFormatType.PortableDocFormat, saveFileDialog1.FileName);
            }
        }

        private void BackButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
