using BasicForms;
using ControlsMC;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TextBoxControls;
using LibreriaClases;
using System.Data;

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
        readonly DataAccessClass dac = new DataAccessClass();
        DataSet dsrang = new DataSet();
        DataSet dscategoria = new DataSet();
        DataSet dsplaneta = new DataSet();
        DataSet dsespecie = new DataSet();
        string foto = "";
        bool EsNou = false;
        private void MantenimentUsers_Load(object sender, EventArgs e)
        {
            CarregaDades();  
        }

        private void CarregaDades()
        {

            db = new UserEntities();
            usr = db.Users.ToList();

            dtg.DataSource = usr;
            dtg.Columns[0].Visible = false;

            dsrang = dac.GetByQuery("Select * from UserRanks");
            dscategoria = dac.GetByQuery("Select * from UserCategories");
            dsplaneta = dac.GetByQuery("Select * from Planets");
            dsespecie = dac.GetByQuery("Select * from Species");

            comboBox1.DataSource = dsrang.Tables[0];
            comboBox1.ValueMember = "idUserRank";
            comboBox1.DisplayMember = "CodeRank";
            comboBox1.SelectedValue = -1;

            comboBox2.DataSource = dscategoria.Tables[0];
            comboBox2.ValueMember = "idUserCategory";
            comboBox2.DisplayMember = "CodeCategory";
            comboBox2.SelectedValue = -1;

            comboBox3.DataSource = dsplaneta.Tables[0];
            comboBox3.ValueMember = "idPlanet";
            comboBox3.DisplayMember = "CodePlanet";
            comboBox3.SelectedValue = -1;

            comboBox4.DataSource = dsespecie.Tables[0];
            comboBox4.ValueMember = "idSpecie";
            comboBox4.DisplayMember = "CodeSpecie";
            comboBox4.SelectedValue = -1;
        }

        private void TreureBinding()
        {
            foreach (Control txt in Controls)
                if (txt.GetType() == typeof(SWTextBox))
                {
                    var txt1 = (SWTextBox)txt;
                    txt1.DataBindings.Clear();
                    txt1.Text = "";
                }
                else if (txt.GetType() == typeof(TextBox))
                {
                    var txt1 = (TextBox)txt;
                    txt1.DataBindings.Clear();
                    txt1.Text = "";
                }
                else if (txt.GetType() == typeof(ComboBox))
                {
                    var txt1 = (ComboBox)txt;
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
                    txt1.DataBindings.Add("Text", dtg.DataSource, txt1.CampoBBDD, true);
                }
                else if (txt.GetType() == typeof(ComboBox))
                {
                    var txt1 = (ComboBox)txt;
  
                    txt1.Font = new Font("Microsoft Sans Serif", 12);
                                       
                }
                else if (txt.GetType() == typeof(TextBox))
                {
                    var txt1 = (TextBox)txt;
                    txt1.Font = new Font("Microsoft Sans Serif", 12);
                    txt1.DataBindings.Clear();
                    txt1.DataBindings.Add("Text", dtg.DataSource, txt1.Tag.ToString(), true);
                   
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
                    Password = swTextBox4.Text,
                    idUserRank = int.Parse(textBox1.Text),
                    idUserCategory = int.Parse(textBox2.Text),
                    idPlanet = int.Parse(textBox3.Text),
                    idSpecie = int.Parse(textBox4.Text),
                    Photo = swTextBox6.Text
                };
                db.Users.Add(newuser);
            }
            EsNou = false;
            db.SaveChanges();
            CarregaDades();
            FerBiding();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            EsNou = true;
            TreureBinding();
        }

        private void textBoxs_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0) {
                comboBox1.SelectedValue = textBox1.Text;
            }
            if (textBox2.TextLength > 0)
            {
                comboBox2.SelectedValue = textBox2.Text;
            }
            if (textBox3.TextLength > 0)
            {
                comboBox3.SelectedValue = textBox3.Text;
            }
            if (textBox4.TextLength > 0)
            {
                comboBox4.SelectedValue = textBox4.Text;
            }
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedValue.ToString();
            textBox2.Text = comboBox2.SelectedValue.ToString();
            textBox3.Text = comboBox3.SelectedValue.ToString();
            textBox4.Text = comboBox4.SelectedValue.ToString();
        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FerBiding();
            foto = swTextBox6.Text;
            carregarfoto(foto);
        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FerBiding();
            foto = swTextBox6.Text;
            carregarfoto(foto);
        }

        private void carregarfoto(string foto)
        {
            pbox_user.ImageLocation = Application.StartupPath + "\\images\\" + foto;
        }
    }
}
