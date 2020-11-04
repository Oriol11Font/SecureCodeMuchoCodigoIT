using System;
using System.Windows.Forms;

namespace LibreriaControles
{
    public partial class BaseForm: Form
    {
        public bool FontSize { get; set; }

        public BaseForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
