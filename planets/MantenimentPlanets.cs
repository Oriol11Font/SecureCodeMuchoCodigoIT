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
            profileImg = imgProfile;
            ids = new int[] { 0, 3, 7, 8 };
            InitializeComponent();
        }
    }
}
