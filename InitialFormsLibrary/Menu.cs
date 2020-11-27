using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using LibreriaControles;
using TextBoxControls;
using LibreriaClases;

namespace ProvaClasse
{
    public partial class Menu : BaseForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private String _user;
        public String user
        {
            get { return _user; }
            set
            {
                _user = value;
            }
        }

        private void setWelcomeLabel(DateTime tiempo, string user)
        {
            string welcomeText, momentDia;

            welcomeText = this.welcomeText.Text;

            switch ((int)tiempo.Hour)
            {
                case int n when (n >= 8 && n < 13):
                    momentDia = "Bon dia";
                    break;
                case int n when (n >= 13 && n < 20):
                    momentDia = "Bona tarda";
                    break;
                default:
                    momentDia = "Bona nit";
                    break;
            }

            String hora = "\nSon les " + tiempo.Hour + ":" + tiempo.Minute;
            this.welcomeText.Text = $"{momentDia} {user} {hora}";
        }

        static string getUpperCaseStr(string str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void openShipsForm(object sender, EventArgs e)
        {
            MessageBox.Show("Obert");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login logout = new login();
            logout.Show();
            this.Close();
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            //panel3.Size = new Size(443, 385);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            //System.DateTime tiempo = new System.DateTime();
            user = getUpperCaseStr(user);
            setWelcomeLabel(now, user);
            this.WindowState = FormWindowState.Maximized;
            UserName = user;

            

            DataAccessClass data = new DataAccessClass();
            String sql = "SELECT * FROM MenuOptions";

            DataSet sqldata = data.GetByQuery(sql);

            for (int i = 0; i < sqldata.Tables[0].Rows.Count; i++)
            {
                

                DataRow dr = sqldata.Tables[0].Rows[i];

                exeButton menubtn = new exeButton();

                menubtn.ImageLocation = Application.StartupPath + "\\images\\" + dr.ItemArray.GetValue(2).ToString(); ;
                menubtn.SizeMode = PictureBoxSizeMode.Zoom;

                menubtn.Form = dr.ItemArray.GetValue(3).ToString();
                menubtn.Classe = dr.ItemArray.GetValue(4).ToString();
                menubtn.Margin = new Padding(50);
                menubtn.Dock = DockStyle.Fill;

                tblMenu.Controls.Add(menubtn);
            }
        }
    }
}

