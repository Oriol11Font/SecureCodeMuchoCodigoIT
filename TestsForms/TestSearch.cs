using BasicForms;
using System;
using System.Collections.Generic;

namespace TestsForms
{
    public partial class TestSearch : SearchForm
    {
        public TestSearch()
        {
            FormTitle = @"Cerca";
            DtName = @"Agencies";
            SearchStrings = new Dictionary<string, string>();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchStrings.Add(@"idAgency", "1");
            HandleSearch();
        }
    }
}
