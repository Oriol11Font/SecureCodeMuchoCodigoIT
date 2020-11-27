﻿using System;
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

namespace ProvaClasse
{
    public partial class Menu : BaseForm
    {
        public Menu(string user)
        {
            InitializeComponent();
            InitMenu(user);
        }
        
        private void InitMenu(string user)
        {
            DateTime now = DateTime.Now;
            //System.DateTime tiempo = new System.DateTime();
            user = GetUpperCaseStr(user);
            SetWelcomeLabel(now, user);
            this.WindowState = FormWindowState.Maximized;
        }

        private void SetWelcomeLabel(DateTime tiempo, string user)
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
            UserName = user;
        }

        static string GetUpperCaseStr(string str)
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

        private void OpenShipsForm(object sender, EventArgs e)
        {
            MessageBox.Show(@"Obert");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login logout = new Login();
            logout.Show();
            this.Close();
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            //panel3.Size = new Size(443, 385);
        }

        private void welcomeText_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < 5; i++)
           {
                exeButton menubtn = new exeButton();
                menubtn.ImageLocation = Application.StartupPath + "\\images\\" + "settings.png";
                menubtn.SizeMode = PictureBoxSizeMode.Zoom;
                //menubtn.Width = (tblMenu.Width / 5);
                //menubtn.Height = (tblMenu.Height / 3);
                menubtn.Margin = new Padding(50);
                menubtn.Dock = DockStyle.Fill;
                tblMenu.Controls.Add(menubtn);
           }
        }
    }
}

