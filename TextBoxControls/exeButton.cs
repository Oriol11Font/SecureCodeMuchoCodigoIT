using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxControls
{
    public partial class exeButton : PictureBox
    {
        public exeButton()
        {
            InitializeComponent();
        }

        private String _Form;
        public String Form
        {
            get { return _Form; }
            set
            {
                _Form = value;
            }
        }

        private String _Classe;
        public String Classe
        {
            get { return _Classe; }
            set
            {
                _Classe = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has obert el formulari " + Form + " i la classe " + Classe);
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            //btnimgexe.Text = Text;
            //button1.BackgroundImage = TextBoxControls.Properties.Resources.bg_image;
            //this.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}

