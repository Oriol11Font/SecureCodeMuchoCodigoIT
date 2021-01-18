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
                        Console.WriteLine("Buscant si existeixen arxius nous dins del servidor...");

                        string fileContent = string.Empty;
                        string filePath = string.Empty;

                        string ftpHost = "192.168.10.1";
                        string ftpUser = "g4";
                        string ftpPW = "12345aA";

                        String uploadserverpath = "/home/g4/";
                        String fileName = string.Empty;
                        string finalpath = uploadserverpath;
                        //MessageBox.Show(finalpath);

                        //INICIANDO
                        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(string.Format("ftp://{0}/{1}", ftpHost, uploadserverpath));
                        request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                        // This example assumes the FTP site uses anonymous logon.
                        request.Credentials = new NetworkCredential(ftpUser, ftpPW);

                        FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                        Stream responseStream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(responseStream);
                        Console.WriteLine(reader.ReadToEnd());

                        Console.WriteLine($"Directory List Complete, status {response.StatusDescription}");
                        Console.WriteLine("Choose File: ");
                        reader.Close();
                        response.Close();

                        seleccionArchivo();
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

        private static void seleccionArchivo()
        {
            String input = Console.ReadLine();

            string fileContent = string.Empty;
            string filePath = string.Empty;

            string ftpHost = "192.168.10.1";
            string ftpUser = "g4";
            string ftpPW = "12345aA";
            string localDestinationFilePath  = "C:\\Users\\oriol\\Descargas";
            String uploadserverpath = "/home/g4/";
            String fileName = string.Empty;
            string finalpath = uploadserverpath + input;

            int bytesRead = 0;
            byte[] buffer = new byte[2048];
            //MessageBox.Show(finalpath);

            //INICIANDO
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(string.Format("ftp://{0}/{1}", ftpHost, finalpath));
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential(ftpUser, ftpPW);

            //FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream reader = request.GetResponse().GetResponseStream();
            FileStream fileStream = new FileStream(localDestinationFilePath, FileMode.Create);

            while (true)
            {
                bytesRead = reader.Read(buffer, 0, buffer.Length);

                if (bytesRead == 0)
                    break;

                fileStream.Write(buffer, 0, bytesRead);
            }

            fileStream.Close();


            /*
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            Console.WriteLine(reader.ReadToEnd());

            Console.WriteLine($"Download Complete, status {response.StatusDescription}");

            reader.Close();
            response.Close();
            */
        }
    }
}
