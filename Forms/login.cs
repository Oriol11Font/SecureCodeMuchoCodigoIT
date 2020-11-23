using ProvaClasse.Forms;
using System;
using System.Windows.Forms;
using LibreriaClases;

namespace ProvaClasse
{
    public partial class login : Form
    {
        int _intentos = 0;
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

                loginBar.Value += 10;

            }
            else
            {
                //Creamos variables
                var username = txt_username.Text.Trim();
                var password = mtxt_password.Text.Trim();

                // TODO: ARREGLAR FUNCION LOGEAR USUARIOS; ME DA PALO SEGUIR MAS; ME DUELE LA CABEZA
                if (ValidateUser(username, password))
                {
                    Menu Menu = new Menu(username);
                    Menu.Show();
                    this.Close();
                }
                else
                {
                    _intentos++;

                    btn_login.Visible = true;
                    usernameLabel.Visible = true;
                    passwordLabel.Visible = true;
                    messageLoginLabel.Visible = false; // todo
                    messageLoginLabel.Text = @"El usuario y/o la contraseña son incorrectos! Inténtelo de nuevo";
                    mtxt_password.Visible = true;
                    txt_username.Visible = true;
                    loginBar.Visible = false;
                    timer1.Enabled = false;

                    if (_intentos >= 3)
                    {
                        //Abrir nuevo formulario con mensaje AMENAZADDOR
                        AlertScreen amenaza = new AlertScreen();
                        amenaza.Show();
                        this.Close();
                    }
                }
            }
        }

        private void ToggleVisibility()
        {
            btn_login.Visible = true;
            usernameLabel.Visible = true;
            passwordLabel.Visible = true;
            messageLoginLabel.Visible = false;
            mtxt_password.Visible = true;
            txt_username.Visible = true;
            loginBar.Visible = true;
            timer1.Enabled = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            btn_login.Visible = false;
            usernameLabel.Visible = false;
            passwordLabel.Visible = false;
            messageLoginLabel.Text = "Estamos validando sus datos!\r\nEsto puede tardar...\r\n";
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

        private static bool ValidateUser(string username, string password)
        {
            var dac = new DataAccessClass();
            var login = false;
            try
            {
                var dt = dac.GetByQuery("SELECT * FROM Users WHERE UserName = '"+username+"';").Tables[0];

                login = (dt.Rows.Count == 1) && ((string) dt.Rows[0].ItemArray[2] == username && (string) dt.Rows[0].ItemArray[4] == password);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e}");
            }

            return login;
        }
    }
}