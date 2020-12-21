using BasicForms;
using ControlsMC;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TextBoxControls;

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
        bool EsNou = false;
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

        private void TreureBinding()
        {
            foreach (Control txt in Controls)
                if (txt.GetType() == typeof(SWTextBox))
                {
                    var txt1 = (SWTextBox)txt;
                    txt1.Font = new Font("Microsoft Sans Serif", 12);
                    txt1.DataBindings.Clear();
                    txt1.Text = "";
                }
                else if (txt.GetType() == typeof(MCCodi))
                {
                    var txt1 = (MCCodi)txt;
                    txt1.Font = new Font("Microsoft Sans Serif", 12);
                    txt1.DataBindings.Clear();
                    txt1.Text = "";
                }
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
                else if (txt.GetType() == typeof(MCCodi))
                {
                    var txt1 = (MCCodi)txt;
                    txt1.Font = new Font("Microsoft Sans Serif", 12);
                    txt1.DataBindings.Clear();
                    txt1.DataBindings.Add("ControlID", usr, txt1.NomId);
                }
                else if (txt.GetType() == typeof(Label))
                {
                    var txt1 = (Label)txt;
                    txt1.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                    txt1.ForeColor = Color.White;
                    txt1.BackColor = Color.Transparent;
                }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_actualitzar_Click(object sender, EventArgs e)
        {

            
            if (EsNou)
            {
                User newuser = new User()
                {
                    CodeUser = swTextBox3.Text,
                    UserName = swTextBox2.Text,
                    Login = swTextBox5.Text,
                    Password = swTextBox4.Text
                };
                db.Users.Add(newuser);
            }
            db.SaveChanges();
            CarregaDades();
            FerBiding();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            EsNou = true;
            TreureBinding();
        }
    }
}
