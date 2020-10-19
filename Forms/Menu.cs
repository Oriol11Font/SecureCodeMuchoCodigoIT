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

namespace ProvaClasse
{
    public partial class Menu : Form
    {
        public Menu(string user)
        {
            InitializeComponent();
            initMenu(user);
        }
        
        private void initMenu(string user)
        {
            DateTime now = DateTime.Now;
            System.DateTime tiempo = new System.DateTime();
            user = getUpperCaseStr(user);
            setWelcomeLabel(now, user);
            this.WindowState = FormWindowState.Maximized;
            usernameMenu.Text = user;
        }

        private void setWelcomeLabel(DateTime tiempo, string user)
        {
            string welcomeText, momentDia;

            welcomeText = welcomeLabel.Text;

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

            welcomeLabel.Text = $"{momentDia} {user}";
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
        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}

