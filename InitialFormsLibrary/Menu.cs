﻿using System;
using System.Windows.Forms;
using InitialFormsLibrary;
using LibreriaClases;
using BasicForms;
using TextBoxControls;
using System.Data;

namespace SecureCoreMain
{
    public partial class Menu : BaseForm
    {
        DataAccessClass data = new DataAccessClass();

        public Menu(String sql)
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
                default:
                    momentDia = "Bona nit";
                    break;
            }

           // var hora = "\nSón les " + time.Hour + ":" + tiempo.Minute;
            this.welcomeText.Text = $"{momentDia} {this.UserName}";
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            setWelcomeLabel(UserName);

            var sql = "SELECT * FROM MenuOptions";
            var sqldata = data.GetByQuery(sql);

            for (var i = 0; i < sqldata.Tables[0].Rows.Count; i++)
            {
                var dr = sqldata.Tables[0].Rows[i];

                var menubtn = new exeButton();

                menubtn.ImageLocation1 = Application.StartupPath + "\\images\\" + dr.ItemArray.GetValue(2) + ".png";
                menubtn.ImageLocation2 = Application.StartupPath + "\\images\\" + dr.ItemArray.GetValue(2) + ".gif";
                menubtn.ImageLocation = Application.StartupPath + "\\images\\" + dr.ItemArray.GetValue(2) + ".png";
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