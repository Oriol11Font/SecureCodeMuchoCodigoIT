using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicForms;

namespace TestsForms
{
    public partial class TestSearch : SearchForm
    {
        public TestSearch()
        {
            InitializeComponent();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            SearchStrings.Add("idAgency", textBox1.Text);
            SearchStrings.Add("CodeAgency", textBox2.Text);
            HandleSearch();
        }
    }
}
