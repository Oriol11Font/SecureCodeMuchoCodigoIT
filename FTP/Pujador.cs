using BasicForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP
{
    public partial class Pujador : BaseForm
    {
        public Pujador()
        {
            InitializeComponent();
        }

        private void Pujador_Load(object sender, EventArgs e)
        {
            //Set Host, User and Password for the FTP;
            string ftpHost = "192.168.10.1";
            string ftpUser = "g4";
            string ftpPW = "12345aA";

            string ftpFullPath = @"ftp://" + ftpHost;

            try
            {
                //Establish a connection to the server;
                FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(ftpFullPath);
                ftp.Credentials = new NetworkCredential(ftpUser, ftpPW);

                ftp.KeepAlive = true;
                ftp.UseBinary = true;
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hola;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("..\\DLL\\FTP - Download");
        }
    }
}
