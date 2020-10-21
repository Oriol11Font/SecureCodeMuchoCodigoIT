using ProvaClasse.Forms;
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
        int intentos = 0;
        public login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 200;

            if (loginBar.Value < 100)
            {

                loginBar.Value += 2;

            }
            else
            {
                //Creamos variables
                String username = txt_username.Text;
                String password = mtxt_password.Text;


                //Varaibles de prueba
                String user = "test";
                String pass = "12345";

                if (username == user && password == pass)
                {
                    Menu Menu = new Menu(user);
                    Menu.Show();
                    this.Close();
                }
                else
                {
                    intentos++;

                    btn_login.Visible = true;
                    usernameLabel.Visible = true;
                    passwordLabel.Visible = true;
                    messageLoginLabel.Visible = false;
                    mtxt_password.Visible = true;
                    txt_username.Visible = true;
                    loginBar.Visible = false;
                    timer1.Enabled = false;
                    
                    

                    if (intentos >= 3)
                    {
                        //Abrir nuevo formulario con mensaje AMENAZADDOR
                        AlertScreen amenaza = new AlertScreen();
                        amenaza.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nom d'usuari o contrassenya incorrecte");
                    }
                }
            }
        }



        private void btn_login_Click(object sender, EventArgs e)
        {
            btn_login.Visible = false;
            usernameLabel.Visible = false;
            passwordLabel.Visible = false;
            messageLoginLabel.Visible = true;
            mtxt_password.Visible = false;
            txt_username.Visible = false;
            loginBar.Visible = true;

            loginBar.Value = 0;

            timer1_Tick_1(sender, e);
        }

        private void mtxt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
            btn_login_Click(null, null);
            }
        }
    }
}
