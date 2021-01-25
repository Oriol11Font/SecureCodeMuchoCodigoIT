using BasicForms;
using LibreriaClases;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using TextBoxControls;

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
            ProfileImg = drUser.ItemArray.GetValue(7).ToString();
            InitializeComponent();
        }

        private void setWelcomeLabel()
        {
            string momentDia;
            var hour = DateTime.Now.Hour;
            switch (hour)
            {
                case int n when n >= 0 && n < 12:
                    momentDia = "Bon dia";
                    break;
                case int n when n >= 12 && n < 20:
                    momentDia = "Bona tarda";
                    break;
                case int n when n >= 20 || n < 0:
                    momentDia = "Bona nit";
                    break;
                default:
                    momentDia = "Benvingut";
                    break;
            }

            welcomeText.Text = $"{momentDia} {this.UserName}";
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
            setWelcomeLabel();

            SetUserRank();

            var sqldata = data.GetTable("MenuOptions");

            foreach (DataRow dr in sqldata.Tables[0].Rows)
            {
                // si no té un nivell d'accés igual o superior no podrà veure els botons del menú que requereixin d'un accés superior
                if (_accessLevel >= int.Parse(dr.ItemArray.GetValue(5).ToString()))
                {
                    try
                    {
                        var menubtn = new ExeButton
                        {
                            ImageLocation1 = $@"..\\TextBoxControls\\Resources\\{dr.ItemArray[2]}.png",
                            ImageLocation2 = $@"..\\TextBoxControls\\Resources\\{dr.ItemArray[2]}.gif",
                            ImageLocation = $@"..\\TextBoxControls\\Resources\\{dr.ItemArray[2]}.png",

                            SizeMode = PictureBoxSizeMode.Zoom,
                            UserName = UserName,
                            ImgProfile = ProfileImg,
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
    }
}