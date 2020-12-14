﻿using BasicForms;
using ControlsMC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Users
{
    public partial class MantenimentUsers : BaseForm
    {
        public MantenimentUsers(String username, String imgProfile)
        {
            FormTitle = "Manteniment Usuaris";
            UserName = username;
            profileImg = imgProfile;
            InitializeComponent();
        }

        UserEntities db;
        List<User> usr; 
        private void MantenimentUsers_Load(object sender, EventArgs e)
        {
            CarregaDades();
            FerBiding();
            
        }

        private void CarregaDades()
        {

            db = new UserEntities();
            usr = db.Users.ToList();
            dtg.DataSource = usr;
            dtg.Columns[0].Visible = false;
        }
        private void FerBiding()
        {
            foreach (Control txt in Controls)
                if (txt.GetType() == typeof(SWTextBox))
                {
                    var txt1 = (SWTextBox)txt;
                    txt1.Font = new Font("Microsoft Sans Serif", 12);
                    txt1.DataBindings.Clear();
                    txt1.DataBindings.Add("Text", usr, txt1.CampoBBDD);
                }
                else if (txt.GetType() == typeof(Label))
                {
                    var txt1 = (Label)txt;
                    txt1.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                    txt1.ForeColor = Color.White;
                    txt1.BackColor = Color.Transparent;
                }    
        }
    }
}
