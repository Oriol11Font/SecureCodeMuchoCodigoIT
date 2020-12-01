using System;
using System.Drawing;
using System.Windows.Forms;

namespace SecureCoreMain.Forms
{
    public partial class AlertScreen : Form
    {
        public AlertScreen()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 5;
            }
            else
            {
                timer1.Enabled = false;
                Application.Exit();
            }
        }

        private void AlertScreen_Load(object sender, EventArgs e)
        {
            alert1.Image = Image.FromFile(Application.StartupPath + "\\images\\" + "alertsign.gif");
            alert1.SizeMode = PictureBoxSizeMode.StretchImage;
            alert1.Enabled = true;
            alert2.Image = Image.FromFile(Application.StartupPath + "\\images\\" + "alertsign.gif");
            alert2.SizeMode = PictureBoxSizeMode.StretchImage;
            alert2.Enabled = true;
            alert3.Image = Image.FromFile(Application.StartupPath + "\\images\\" + "alertsign.gif");
            alert3.SizeMode = PictureBoxSizeMode.StretchImage;
            alert3.Enabled = true;
            alert4.Image = Image.FromFile(Application.StartupPath + "\\images\\" + "alertsign.gif");
            alert4.SizeMode = PictureBoxSizeMode.StretchImage;
            alert4.Enabled = true;
        }
    }
}