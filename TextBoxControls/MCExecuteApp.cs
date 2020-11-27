using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxControls
{
    public partial class McExecuteApp : UserControl
    {
        public McExecuteApp()
        {
            InitializeComponent();
        }

        private String _from;
        public String Form
        {
            get { return _from; }
            set
            {
                _from = value;
            }
        }

        private String _classe;
        public String Classe
        {
            get { return _classe; }
            set
            {
                _classe = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has obert el formulari " + Form + " i la classe " + Classe);
        }
    }
}
