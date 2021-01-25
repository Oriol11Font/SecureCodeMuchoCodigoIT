using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace FTP___Download
{
    class ProgramFTP
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[BENVINGUT a MuchoCodigoConsole] --- Conectat a la consola correctament, <exit> per sortir de la sessió ---");
                Console.ForegroundColor = ConsoleColor.White;

                string input = "hola";
                while (input != "exit")
                {
                    input = Console.ReadLine();

                    if (input == "hola") { }

                    else if (input == "check")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("[INFORMACIÓN] --- Buscant si existeixen arxius nous dins del servidor... ---");
                        Console.ForegroundColor = ConsoleColor.White;

                        string fileContent = string.Empty;
                        string filePath = string.Empty;

                        string ftpHost = "192.168.10.1";
                        string ftpUser = "g4";
                        string ftpPW = "12345aA";
                        string ftpFolderPath = "/home/g4/";

                        try
                        {
                            FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{ftpHost}/{ftpFolderPath}");
                            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                            // This example assumes the FTP site uses anonymous logon.
                            request.Credentials = new NetworkCredential(ftpUser, ftpPW);

                            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                            Stream responseStream = response.GetResponseStream();
                            StreamReader reader = new StreamReader(responseStream);
                            Console.WriteLine(reader.ReadToEnd());

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"[INFORMACIÓN] --- Directory List Complete, status: {response.StatusDescription} ---");
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine("Choose File: ");
                            reader.Close();
                            response.Close();

                            seleccionArchivo();
                        }
                        catch (Exception err)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("[ERROR] --- Conexió al servidor FTP fallida: " + err + " ---");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                    }
                    else if (input == "path")
                    {
                        Console.WriteLine("GetFolderPath: " + "C:\\Users\\" + Environment.UserName + "\\Descargas");
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[ERROR] --- Comando no reconocido por la consola, pueda que no exista o no este bien escrito ---");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    //input = Console.ReadLine();
                }


            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private static void seleccionArchivo()
        {
            Console.WriteLine("Escribir nombre archivo, incluyendo la extension.");

            string input = Console.ReadLine();

            string fileName = input;
            string ftpHost = "192.168.10.1";
            string ftpUser = "g4";
            string ftpPW = "12345aA";
            string ftpFolder = "/home/g4/";
            string downloadpath = "C:\\Users\\" + Environment.UserName + "\\Downloads\\" + input;
            string finalpath = ftpFolder + fileName;

            try
            {
                // Get the object used to communicate with the server.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{ftpHost}/{finalpath}");
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                // This example assumes the FTP site uses anonymous logon.
                request.Credentials = new NetworkCredential(ftpUser, ftpPW);

                Stream responseStream = request.GetResponse().GetResponseStream();
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                /* Destino: tiene que tener la ruta completa incluyendo el nombre de archivo y extension donde quieres grabar */
                FileStream writeStream = new FileStream(downloadpath, FileMode.Create);
                int Length = 1024;/*el tamaño limitado a bloques de 1024 bytes*/
                Byte[] buffer = new Byte[Length];
                int bytesRead = responseStream.Read(buffer, 0, Length);

                while (bytesRead > 0)
                {
                    writeStream.Write(buffer, 0, bytesRead);
                    bytesRead = responseStream.Read(buffer, 0, Length);
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[INFORMACIÓN] --- Arxiu " + fileName + " generat correctament a: " + downloadpath + " ---");
                Console.ForegroundColor = ConsoleColor.White;

                writeStream.Close();
                response.Close();
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERROR] --- Ha sigut impossible descarregar l'arxiu des del servidor FTP: " + err + " ---");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
    }
}
