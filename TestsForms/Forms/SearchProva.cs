using LibreriaControles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProvaClasse.Forms
{
    public partial class SearchProva : SearchForm
    {
        public SearchProva()
        {
            InitializeComponent();
        }

        private void Initialize(object sender, EventArgs e)
        {
            try
            {
                input1.Label.Text = @"Code Agency";
                Init(@"Agencies");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), @"No s'ha pogut iniciar el formulari de cerca", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> SearchStrings = new Dictionary<string, string>();
            SearchStrings.Add("CodeAgency", input1.Inputbox.Text.Trim());
            HandleSearch(SearchStrings);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input1.Inputbox.Text = "";
            ClearSearch();
        }
    }
}