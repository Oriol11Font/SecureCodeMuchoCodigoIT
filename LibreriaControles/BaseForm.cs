using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaControles
{
    public partial class BaseForm: UserControl
    {
        public bool FontSize { get; private set; }

        public BaseForm()
        {
            InitializeComponent();
            GoFullscreen(true);
        }

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
 
            }
            else
            {

            }
        }

        private void TaulaEsquadres_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
    
        }
    }
}
