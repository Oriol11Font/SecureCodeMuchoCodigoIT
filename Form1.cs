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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            timer1.Enabled = true;
            timer1. Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
          
            if (progressBar1.Value < 10){
                progressBar1.Value++;
            } else {
               
                Form2 f2 = new Form2();
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
                Form2 Form2 = new Form2();
                Form2.Show();
            }
        }
    }
}
