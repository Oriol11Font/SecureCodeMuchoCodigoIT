﻿using BasicForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Categories
{
    public partial class UserCategories : BaseForm
    {
        public UserCategories(String username, String imgProfile)
        {
            FormTitle = "Categories dels Usuaris";
            UserName = username;
            profileImg = imgProfile;
            InitializeComponent();
        }

        CaregoriesEntities db;
        List<UserCategory> cat;

        private void CarregaDades()
        {
            db = new CaregoriesEntities();

            cat = db.UserCategories.ToList();

            dtgCategories.DataSource = cat;
            dtgCategories.Columns[0].Visible = false;
        }
        private void UserCategories_Load(object sender, EventArgs e)
        {
            CarregaDades();

            GenerarBinding();
        }

        private void GenerarBinding()
        {
            CodiCategory.Font = new Font("Microsoft Sans Serif", 12);
            CodiCategory.DataBindings.Clear();
            CodiCategory.DataBindings.Add("Text", dtgCategories.DataSource, CodiCategory.CampoBBDD, true);

            DescCategory.Font = new Font("Microsoft Sans Serif", 12);
            DescCategory.DataBindings.Clear();
            DescCategory.DataBindings.Add("Text", dtgCategories.DataSource, DescCategory.CampoBBDD, true);

            LvlCategory.Font = new Font("Microsoft Sans Serif", 12);
            LvlCategory.DataBindings.Clear();
            LvlCategory.DataBindings.Add("Text", dtgCategories.DataSource, LvlCategory.CampoBBDD, true);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_actualitzar_Click(object sender, EventArgs e)
        {
            try
            {
                //cat = (from c in db.UserCategories
                //   select c).ToList();

                db.SaveChanges();
                CarregaDades();
                GenerarBinding();

                btn_actualitzar.ForeColor = Color.LawnGreen;
            }
            catch (Exception ex)
            {
                btn_actualitzar.ForeColor = Color.Red;
                MessageBox.Show("SimpleForm - Error creating new row: " + ex.Message);
            }

            

            //GenerarBinding();
        }
    }
}
