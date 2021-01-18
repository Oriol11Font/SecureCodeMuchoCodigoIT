using BasicForms;
using LibreriaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP
{
    public partial class Pujador : BaseForm
    {
        readonly DataAccessClass data = new DataAccessClass();

        public Pujador()
        {
            UserName = "Anonymous";
            profileImg = "Oriol.jpg";
            FormTitle = "Registrar o Pujar comandes";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileContent = string.Empty;
            string filePath = string.Empty;

            string ftpHost = "192.168.10.1";
            string ftpUser = "g4";
            string ftpPW = "12345aA";

            String uploadserverpath = "/home/g4/";
            String fileName = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Text files (*.edi)|*.edi";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    fileName = Path.GetFileName(filePath);

                    labelFile.Text = fileName;
                }

                string finalpath = uploadserverpath + fileName;
                

                //hacer request y postear
                FtpWebRequest ftpRequest;
                
                // Crea el objeto de conexión del servidor FTP
                ftpRequest = (FtpWebRequest)WebRequest.Create(string.Format("ftp://{0}/{1}", ftpHost, finalpath));
                // Asigna las credenciales
                ftpRequest.Credentials = new NetworkCredential(ftpUser, ftpPW);
                // Asigna las propiedades
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                ftpRequest.UsePassive = true;
                ftpRequest.UseBinary = true;
                ftpRequest.KeepAlive = false;
                if (filePath != null)
                {
                    StreamReader sourceStream = new StreamReader(filePath);
                    byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                    sourceStream.Close();
                    ftpRequest.ContentLength = fileContents.Length;

                    FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();

                    Stream requestStream = ftpRequest.GetRequestStream();
                    requestStream.Write(fileContents, 0, fileContents.Length);
                    requestStream.Close();

                    labelStatus.Text = $"File Uploaded, status {response.StatusDescription}";
                } else
                {
                    labelStatus.Text = "File null";
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("..\\DLL\\FTP - Download");
        }
    }
}
