using BasicForms;
using LibreriaClases;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace FTP
{
    public partial class Pujador : BaseForm
    {
        readonly DataAccessClass data = new DataAccessClass();

        public Pujador()
        {
            UserName = "Anonymous";
            ProfileImg = "Oriol.jpg";
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

                // Crea el objeto de conexión del servidor FTP
                var ftpRequest = (FtpWebRequest)WebRequest.Create($"ftp://{ftpHost}/{finalpath}");
                // Asigna las credenciales
                ftpRequest.Credentials = new NetworkCredential(ftpUser, ftpPW);
                // Asigna las propiedades
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                ftpRequest.UsePassive = true;
                ftpRequest.UseBinary = true;
                ftpRequest.KeepAlive = false;
                if (filePath.Length > 0)
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
                }
                else
                {
                    labelStatus.Text = "File null";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("..\\DLL\\FTP - Download");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "Text files (*.edi)|*.edi";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    string fileContent = string.Empty;
                    string filePath = string.Empty;
                    string tabla = string.Empty;

                    ordersEntities dbo = new ordersEntities();

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        int cont = 0;

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        //Read the contents of the file into a stream
                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                        }

                        string[] lines = File.ReadAllLines(filePath);

                        int priority = 0;
                        string code = string.Empty;
                        DateTime date = new DateTime();
                        int factory = 0;
                        int agency = 0;
                        int operationalArea = 0;
                        int idord = 0;
                        int planet = 0;
                        int reference = 0;
                        short quantity = 0;
                        DateTime deliveryDate = new DateTime();

                        foreach (string line in lines)
                        {
                            string[] elements = line.Split('|');

                            if (!(elements[0].Equals("LIN")) && cont == 0)
                            {
                                if (elements[0].Equals("ORD"))
                                {
                                    //Numero de la order
                                    code = elements[1];

                                    //Id de la prioridad
                                    priority = data.getid("Priority", "idPriority", "CodePriority", elements[2]);
                                }
                                else if (elements[0].Equals("DTM"))
                                {
                                    //Fecha de la order
                                    date = DateTime.ParseExact(elements[1], "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                                }
                                else if (elements[0].Equals("NADMS"))
                                {
                                    agency = data.getid("Agencies", "idAgency", "CodeAgency", elements[2]);

                                    operationalArea = data.getid("OperationalAreas", "idOperationalArea", "CodeOperationalArea", elements[1]);
                                }
                                else if (elements[0].Equals("NADMR"))
                                {
                                    factory = data.getid("Factories", "idFactory", "codeFactory", elements[1]);
                                }
                                else
                                {
                                    throw new Exception("Tabla de BBDD inexistente");
                                }

                            }
                            else
                            {
                                if (cont == 0)
                                {
                                    var ord = new Order()
                                    {
                                        codeOrder = code,
                                        dateOrder = date,
                                        IdFactory = Convert.ToInt16(factory),
                                        IdPriority = Convert.ToInt16(priority)
                                    };


                                    dbo.Orders.Add(ord);
                                    dbo.SaveChanges();
                                    label5.Text = "Order created";

                                    idord = data.getid("Orders", "idOrder", "codeOrder", code);

                                    var ordInf = new OrderInfo()
                                    {
                                        idOrder = Convert.ToInt16(idord),
                                        idAgency = Convert.ToInt16(agency),
                                        idOperationalArea = Convert.ToInt16(operationalArea)
                                    };

                                    dbo.OrderInfoes.Add(ordInf);
                                    dbo.SaveChanges();
                                    label6.Text = "OrderInfo Created";

                                }

                                if (elements[0].Equals("LIN"))
                                {
                                    planet = data.getid("Planets", "idPlanet", "CodePlanet", elements[1]);
                                    reference = data.getid("References", "idReference", "codeReference", elements[2]);
                                }
                                else if (elements[0].Equals("QTYLIN"))
                                {
                                    quantity = Convert.ToInt16(elements[2]);
                                }
                                else if (elements[0].Equals("DTMLIN"))
                                {
                                    deliveryDate = DateTime.ParseExact(elements[1], "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

                                    var ordDet = new OrdersDetail()
                                    {
                                        idOrder = Convert.ToInt16(idord),
                                        idPlanet = Convert.ToInt16(planet),
                                        idReference = Convert.ToInt16(reference),
                                        Quantity = quantity,
                                        DeliveryDate = deliveryDate
                                    };

                                    dbo.OrdersDetails.Add(ordDet);
                                    dbo.SaveChanges();

                                    label7.Text = "OrderDetails created";
                                }
                                else
                                {
                                    throw new Exception("Tabla de BBDD inexistente");
                                }
                                cont++;
                            }//FIN FOREACH
                        }
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

    }
}








