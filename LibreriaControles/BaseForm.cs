using System;
using System.Reflection;
using System.Windows.Forms;

namespace LibreriaControles
{
    public partial class BaseForm: Form
    {
        public bool FontSize { get; set; }

        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set
            {
                _UserName = value;
            }
        }

        public BaseForm()
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

        private void BaseForm_Load(object sender, EventArgs e)
        {
            userName.Text = "Oriol Font";
        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
