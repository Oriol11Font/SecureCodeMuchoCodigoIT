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

namespace ProvaClasse
{
    public partial class Splash : Form
    {
        int _porcentaje = 0;
        public Splash()
        {
            InitializeComponent();
            lbl_progressCarga.Text = _porcentaje + "%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 200;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (splashBar1.Value < 100)
            {

                splashBar1.Value += 10;
                _porcentaje += 10;
                lbl_progressCarga.Text = _porcentaje + "%";

            }
            else {
               
                Login f2 = new Login();
                timer1.Enabled = false;
                f2.Show();
                this.Hide();
            }

            
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)

            {

                timer1.Stop();
                this.Hide();
                Login form2 = new Login();
                form2.Show();
            } else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.Enter)

            {
                timer1.Stop();   
            }
        }
    }
}
