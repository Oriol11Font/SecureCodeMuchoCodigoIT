﻿using System;
using System.Windows.Forms;
using LibreriaClases;
using LibreriaControles;
using TextBoxControls;

namespace InitialFormsLibrary
{
    public partial class Menu : BaseForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void setWelcomeLabel()
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
                default:
                    momentDia = "Bona nit";
                    break;
            }

           // var hora = "\nSón les " + time.Hour + ":" + tiempo.Minute;
            this.welcomeText.Text = $"{momentDia} {this.UserName}";
        }

        private static string getUpperCaseStr(string str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void openShipsForm(object sender, EventArgs e)
        {
            MessageBox.Show("Obert");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var logout = new Login();
            logout.Show();
            Close();
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            //panel3.Size = new Size(443, 385);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            setWelcomeLabel();

            var data = new DataAccessClass();
            var sql = "SELECT * FROM MenuOptions";

            var sqldata = data.GetByQuery(sql);

            for (var i = 0; i < sqldata.Tables[0].Rows.Count; i++)
            {
                var dr = sqldata.Tables[0].Rows[i];

                var menubtn = new exeButton();

                menubtn.ImageLocation = Application.StartupPath + "\\images\\" + dr.ItemArray.GetValue(2);
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