using System;
using System.Windows.Forms;

namespace LibreriaControles
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        public string UserName { get; set; }

        public string FormTitle { get; set; }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Estas segur de tancar la apliació?\nEs pedran tots els canvis no guardats",
                "ES TANCARA EL PROGRAMA!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            username.Text = "Oriol Font";
        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}