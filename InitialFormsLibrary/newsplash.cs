﻿using InitialFormsLibrary;
using System;
using System.Windows.Forms;


namespace SecureCoreMain
{
    public partial class newsplash : Form
    {
        public newsplash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            }
            else
            {
                Hide();
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
                Hide();
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