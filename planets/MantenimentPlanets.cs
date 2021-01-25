using BasicForms;
using System;

namespace planets
{
    public partial class MantenimentPlanets : ForaniForm
    {
        public MantenimentPlanets(String username, String imgProfile)
        {
            FormTitle = "Manteniment Planetes";
            UserName = username;
            ProfileImg = imgProfile;
            Ids = new[] { 0, 3, 7, 8 };
            InitializeComponent();
        }

        private void txtBoxSectors_Load(object sender, EventArgs e)
        {

        }
    }
}
