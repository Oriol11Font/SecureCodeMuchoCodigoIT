using System;
using System.Drawing;
using System.Windows.Forms;
using LibreriaClases;
using ProvaClasse.Forms;
using Menu = ProvaClasse.Menu;

namespace InitialFormsLibrary
{
    public partial class Login : Form
    {
        private readonly int _intentosDefault = 3;
        private int _intentos;
        private Point _lastLocation;
        private bool _mouseDown;

        public Login()
        {
            InitializeComponent();
        }

        private void Init(object sender, EventArgs e)
        {
            _intentos = _intentosDefault;
        }

        private void topbar_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void topbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                ChangeBorderColor(Color.Red);
                Location = new Point(
                    Location.X - _lastLocation.X + e.X, Location.Y - _lastLocation.Y + e.Y);

                Update();
            }
        }

        private void topbar_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
            ChangeBorderColor(Color.Yellow);
        }

        private void ChangeBorderColor(Color color)
        {
            borderTop.BackColor = color;
            borderRight.BackColor = color;
            borderBottom.BackColor = color;
            borderLeft.BackColor = color;
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
                var username = txt_username.Text.Trim();
                var password = mtxt_password.Text.Trim();

                // validamos usuario
                if (ValidateUser(username, password))
                {
                    var menu = new Menu();
                    menu.UserName = username;
                    menu.Show();
                    Init(null, null);

                    incorrectlbl.Visible = false;
                    btn_login.Visible = true;
                    usernameLabel.Visible = true;
                    passwordLabel.Visible = true;
                    messageLoginLabel.Visible = false;
                    mtxt_password.Visible = true;
                    txt_username.Visible = true;
                    loginBar.Visible = false;
                    timer1.Enabled = false;
                    txt_username.Text = "";
                    mtxt_password.Text = "";
                    validImg.Visible = false;
                }
                else
                {
                    _intentos--;

                    txt_username.Text = "";
                    mtxt_password.Text = "";
                    validImg.Visible = false;
                    incorrectlbl.Visible = true;
                    btn_login.Visible = true;
                    usernameLabel.Visible = true;
                    passwordLabel.Visible = true;
                    messageLoginLabel.Visible = false; // todo
                    incorrectlbl.Text = $@"El usuario y/o la contraseña son incorrectos!
{_intentos} intentos hasta el bloqueo de la aplicación";
                    mtxt_password.Visible = true;
                    txt_username.Visible = true;
                    loginBar.Visible = false;
                    timer1.Enabled = false;

                    if (_intentos == 0)
                    {
                        //Abrir nuevo formulario con mensaje AMENAZADDOR
                        var amenaza = new AlertScreen();
                        amenaza.Show();
                        Close();
                    }
                }
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            username_warning.Visible = false;
            password_warning.Visible = false;
            loginBar.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\" + "lightsaber.png");

            if (txt_username.Text != "" && mtxt_password.Text != "")
            {
                btn_login.Visible = false;
                usernameLabel.Visible = false;
                passwordLabel.Visible = false;
                incorrectlbl.Visible = false;
                messageLoginLabel.Text = "Estamos validando sus datos!\r\nEsto puede tardar unos minutos...\r\n";
                messageLoginLabel.Visible = true;
                mtxt_password.Visible = false;
                txt_username.Visible = false;
                loginBar.Visible = true;
                validImg.Visible = true;
                validImg.Image = Image.FromFile(Application.StartupPath + "\\images\\" + "loginvalidation.gif");
                validImg.SizeMode = PictureBoxSizeMode.StretchImage;
                validImg.Enabled = true;

                loginBar.Value = 0;

                timer1_Tick_1(sender, e);
            }
            else
            {
                if (txt_username.Text == "" && !username_warning.Visible) username_warning.Visible = true;
                if (mtxt_password.Text == "" && !password_warning.Visible) password_warning.Visible = true;
            }
        }

        private void mtxt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btn_login_Click(null, null);
        }

        private static bool ValidateUser(string username, string password)
        {
            var dac = new DataAccessClass();
            var login = false;
            try
            {
                var dt = dac.GetByQuery("SELECT * FROM Users WHERE UserName = '" + username + "';").Tables[0];

                login = dt.Rows.Count == 1 && (string) dt.Rows[0].ItemArray[2] == username &&
                        (string) dt.Rows[0].ItemArray[4] == password;
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Error: {e}");
            }

            return login;
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closebtn_MouseHover(object sender, EventArgs e)
        {
            closebtn.ForeColor = Color.White;
        }

        private void closebtn_MouseLeave(object sender, EventArgs e)
        {
            closebtn.ForeColor = Color.Red;
        }

        private void minimizebtn_MouseHover(object sender, EventArgs e)
        {
            minimizebtn.ForeColor = Color.White;
        }

        private void minimizebtn_MouseLeave(object sender, EventArgs e)
        {
            minimizebtn.ForeColor = Color.Yellow;
        }

        private void validImg_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            label1.Anchor = AnchorStyles.Top;
            label1.Location = new Point(panel7.Bounds.Width / 5, label1.Location.Y);
        }
    }
}