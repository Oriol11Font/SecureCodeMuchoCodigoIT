using BasicForms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using LibreriaClases;
using System;
using System.Windows.Forms;

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
            ProfileImg = imgProfile;
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
            }
            catch
            {
                errorLabel.Text = @"Error mostrant report";
                errorLabel.Visible = true;
            }

        }

        private void SaveReport(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                InitialDirectory = @"C:\",
                Title = @"Selecciona la ubicació on desar el report",
                CheckFileExists = false,
                CheckPathExists = true,
                DefaultExt = "pdf",
                Filter = @"Pdf Files|*.pdf",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cryRpt.ExportToDisk(ExportFormatType.PortableDocFormat, saveFileDialog1.FileName);
            }
        }

        private void BackButton(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) MostrarReport(null, null);
        }
    }
}
