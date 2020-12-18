using System;
using System.Windows.Forms;

namespace BasicForms
{
    public partial class BaseForm : Form
    {
        public string UserName { get; set; }

        public string FormTitle { get; set; } = "Form Title";

        public string profileImg { get; set; }

        public bool Unsaved { get; set; }

        public BaseForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (Unsaved)
            {
                var result = MessageBox.Show(@"Estàs segur/a de tancar l'aplicació?
Es perdran tots els canvis no guardats",
                    @"Advertència",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            appImg.ImageLocation = Application.StartupPath + "\\images\\" + "logo_app.png";
            username.Text = UserName;
            TitleForm.Text = FormTitle;
            profileimg.ImageLocation = Application.StartupPath + "\\images\\" + profileImg;
        }
    }
}