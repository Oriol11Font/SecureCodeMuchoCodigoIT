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
    public partial class splash : Form
    {
        int porcentaje = 0;
        public splash()
        {
            InitializeComponent();
            lbl_progressCarga.Text = porcentaje + "%";
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
                porcentaje += 10;
                lbl_progressCarga.Text = porcentaje + "%";

            }
            else {
               
                login f2 = new login();
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
                login Form2 = new login();
                Form2.Show();
            } else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.Enter)

            {
                timer1.Stop();   
            }
        }
    }
}
