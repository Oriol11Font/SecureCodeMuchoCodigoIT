using BasicForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace planets
{
    public partial class CercaSector : SearchForm
    {
        public CercaSector()
        {
            InitializeComponent();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            SearchStrings.Add("CodeSector", textBox2.Text);
            SearchStrings.Add("DescSector", textBox2.Text);
            SearchStrings.Add("Remarks", textBox2.Text);
            HandleSearch();
        }
    }
}
