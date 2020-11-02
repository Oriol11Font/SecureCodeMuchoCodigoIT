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
    public partial class MCExecuteApp : UserControl
    {
        public MCExecuteApp()
        {
            InitializeComponent();
        }

        private String _From;
        public String Form
        {
            get { return _From; }
            set
            {
                _From = value;
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
    }
}
