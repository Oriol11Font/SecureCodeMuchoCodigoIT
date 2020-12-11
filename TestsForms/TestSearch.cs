using BasicForms;
using System;

namespace TestsForms
{
    public partial class TestSearch : SearchForm
    {
        public TestSearch()
        {
            FormTitle = "Cerca";
            DtName = "Agencies";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchStrings.Add("idAgency", textBox3.Text);
            SearchStrings.Add("DescAgency", textBox4.Text);
            HandleSearch();
        }
    }
}
