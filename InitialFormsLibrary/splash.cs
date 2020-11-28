using System;
using System.Windows.Forms;

namespace InitialFormsLibrary
{
    public partial class Splash : Form
    {
        private int _porcentaje;

        public Splash()
        {
            InitializeComponent();
            lbl_progressCarga.Text = $@"{_porcentaje}%";
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
                lbl_progressCarga.Text = $@"{_porcentaje}%";
            }
            else
            {
                var f2 = new Login();
                timer1.Enabled = false;
                f2.Show();
                Hide();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)

            {
                timer1.Stop();
                Hide();
                var form2 = new Login();
                form2.Show();
            }
            else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.Enter)

            {
                timer1.Stop();
            }
        }
    }
}