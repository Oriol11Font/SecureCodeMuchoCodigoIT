using System;
using System.Windows.Forms;
using InitialFormsLibrary;
using LibreriaClases;
using BasicForms;
using TextBoxControls;
using System.Data;
using System.IO;
using System.Reflection;
using Users;

namespace SecureCoreMain
{
    public partial class Menu : BaseForm
    {
        readonly DataAccessClass data = new DataAccessClass();

        int _accessLevel;

        public Menu(string sql)
        {
            FormTitle = "MENU PRINCIPAL";
            var sqldataUser = data.GetByQuery(sql);
            var drUser = sqldataUser.Tables[0].Rows[0];
            UserName = drUser.ItemArray.GetValue(2).ToString();
            profileImg = drUser.ItemArray.GetValue(7).ToString();
            InitializeComponent();
        }

        private void setWelcomeLabel(String UserName)
        {
            string momentDia;
            var time = new DateTime();

            switch (time.Hour)
            {
                case int n when n >= 8 && n < 13:
                    momentDia = "Bon dia";
                    break;
                case int n when n >= 13 && n < 20:
                    momentDia = "Bona tarda";
                    break;
                case int n when n >= 20 && n < 8:
                    momentDia = "Bona nit";
                    break;
                default:
                    momentDia = "Benvingut";
                    break;
            }

            // var hora = "\nSón les " + time.Hour + ":" + tiempo.Minute;
            this.welcomeText.Text = $"{momentDia} {this.UserName}";
        }

        private void SetUserRank()
        {
            var userCategory = (int)data
                .GetByQuery($@"SELECT idUsercategory FROM Users WHERE UserName = '{UserName}';").Tables[0].Rows[0]
                .ItemArray[0];
            _accessLevel = (int)data
                .GetByQuery($@"SELECT AccessLevel FROM UserCategories WHERE idUserCategory = '{userCategory}';")
                .Tables[0].Rows[0].ItemArray[0];
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            setWelcomeLabel(UserName);

            SetUserRank();

            var sqldata = data.CarregarMenu();

            foreach (DataRow dr in sqldata.Tables[0].Rows)
            {
                // si no té un nivell d'accés igual o superior no podrà veure els botons del menú que requereixin d'un accés superior
                if (_accessLevel >= (int)dr.ItemArray[5])
                {
                    try
                    {
                        var menubtn = new exeButton
                        {
                            ImageLocation1 = Application.StartupPath + "\\images\\" + (string)dr.ItemArray[2] + ".png",
                            ImageLocation2 = Application.StartupPath + "\\images\\" + (string)dr.ItemArray[2] + ".gif",
                            ImageLocation = Application.StartupPath + "\\images\\" + (string)dr.ItemArray[2] + ".png",
                            SizeMode = PictureBoxSizeMode.Zoom,
                            userName = UserName,
                            imgProfile = profileImg,
                            Form = dr.ItemArray[3].ToString(),
                            Classe = dr.ItemArray[4].ToString(),
                            Margin = new Padding(50),
                            Dock = DockStyle.Fill
                        };

                        tblMenu.Controls.Add(menubtn);
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show($@"No s'ha trobat la imatge {dr.ItemArray[2]}");
                    }

                }
            }
        }

        private void LaunchUserReports(object sender, EventArgs e)
        {
            ReportViewer usrReportViewer = new ReportViewer
            {
                UserName = UserName
            };
            usrReportViewer.Show();
        }
    }
}