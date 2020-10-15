using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaClasse
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //Creamos variables
            String username = txt_username.Text;
            String password = mtxt_password.Text;


            //Varaibles de prueba
            String user = "test";
            String pass = "12345";

            if (username == user && password == pass)
            {
                Menu Form3 = new Menu(user);
                Form3.Show();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Nom d'usuari o contrassenya incorrecte");
            }
        }
    }
}
