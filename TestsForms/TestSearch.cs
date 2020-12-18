using BasicForms;
using System;

namespace TestsForms
{
    public partial class TestSearch : SearchForm
    {
        public TestSearch(string username, string imatge)
        {
            DtName = "Agencies";
            UserName = username;
            profileImg = imatge;
            InitializeComponent();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            SearchStrings.Add("idAgency", textBox1.Text);
            SearchStrings.Add("CodeAgency", textBox2.Text);
            SearchStrings.Add("DescAgency", textBox3.Text);
            HandleSearch();
        }
    }
}
