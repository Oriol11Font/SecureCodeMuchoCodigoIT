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
        
        public splash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            timer1.Enabled = true;
            timer1. Interval = 200;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
          
            if (progressBar1.Value < 102){
                progressBar1.Value = progressBar1.Value+3;
            } else {
               
                login f2 = new login();
                timer1.Enabled = false;
                f2.Show();
                this.Hide();
            }
            
        }

        private void SplashScreen_KeyDon(object sender, KeyEventArgs e)
        {
           

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)

            {

                timer1.Stop();
                this.Hide();
                login Form2 = new login();
                Form2.Show();
            }

            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.Enter)

            {

                timer1.Stop();
                
            }
        }
    }
}
