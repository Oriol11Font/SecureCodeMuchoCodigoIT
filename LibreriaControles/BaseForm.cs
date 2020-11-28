using System;
using System.Reflection;
using System.Windows.Forms;

namespace LibreriaControles
{
    public partial class BaseForm: Form
    {
        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set
            {
                _UserName = value;
            }
        }

        private string _FormTitle;
        public string FormTitle
        {
            get { return _FormTitle; }
            set
            {
                _FormTitle = value;
            }
        }

        public BaseForm()
        {
            InitializeComponent();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Estas segur de tancar la apliació?\nEs pedran tots els canvis no guardats", "ES TANCARA EL PROGRAMA!",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            } 
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            username.Text = "Oriol Font";
        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
