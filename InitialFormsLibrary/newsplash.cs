using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using InitialFormsLibrary;

namespace ProvaClasse
{
    public partial class newsplash : Form
    {
        int porcentaje = 0;

        public newsplash()
        {
            InitializeComponent();
            lbl_progressCarga.Text = porcentaje + "%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            splashimg.Image = Image.FromFile(Application.StartupPath + "\\images\\" + "bqsplash.gif");
            splashimg.SizeMode = PictureBoxSizeMode.StretchImage;
            splashimg.Enabled = true;
            timer1.Enabled = true;
            timer1.Interval = 200;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (splashBar1.Value < 100)
            {
                splashBar1.Value += 6;
                porcentaje += 6;
                lbl_progressCarga.Text = porcentaje + "%";
            }
            else
            {
                this.Hide();
                timer1.Enabled = false;

                var f2 = new Login();
                f2.Show();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)

            {
                timer1.Stop();
                this.Hide();
                var Form2 = new Login();
                Form2.Show();
            }
            else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.Enter)

            {
                timer1.Stop();
            }
        }
    }
}