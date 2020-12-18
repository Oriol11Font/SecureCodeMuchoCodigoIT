using BasicForms;
using System;

namespace species
{
    public partial class MantenimentSpecies : ForaniForm
    {
        public MantenimentSpecies(String username, String imgProfile)
        {
            FormTitle = "Manteniment Especies";
            UserName = username;
            profileImg = imgProfile;
            InitializeComponent();
        }
    }
}
