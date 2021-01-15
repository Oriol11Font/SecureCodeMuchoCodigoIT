using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP___Download
{
    class ProgramFTP
    {
        static void Main(string[] args)
        {
            try
            {
                //dirDirectoryDetail
                //dirDirectoryDetail
                //dirDirectoryDetail

                String input = Console.ReadLine();
                while (input != "exit")
                {
                    if (input == "hola")
                    {
                        Console.WriteLine(input);
                    }
                    if (input == "check")
                    {
                        string fileContent = string.Empty;
                        string filePath = string.Empty;

                        string ftpHost = "192.168.10.1";
                        string ftpUser = "g4";
                        string ftpPW = "12345aA";

                        String uploadserverpath = "/home/g4/";
                        String fileName = string.Empty;
                        string finalpath = uploadserverpath + "MuchoCogio.edi";
                        MessageBox.Show(finalpath);

                        //hacer request y postear
                        FtpWebRequest ftpRequest;

                        // Crea el objeto de conexión del servidor FTP
                        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(string.Format("ftp://{0}/{1}", ftpHost, finalpath));

                        request.Method = WebRequestMethods.Ftp.DownloadFile;

                        // Asigna las credenciales
                        request.Credentials = new NetworkCredential(ftpUser, ftpPW);
                        // Asigna las propiedades

                        FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                        Stream responseStream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(responseStream);

                        String result = reader.ReadToEnd();

                        Console.WriteLine(result);

                    }
                    else
                    {
                        Console.WriteLine("Te jodes");
                    }

                    input = Console.ReadLine();
                }
            
                
            } catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }
}
