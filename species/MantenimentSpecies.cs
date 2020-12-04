using BasicForms;
using System;

namespace species
{
    public partial class MantenimentSpecies : SimpleForm
    {
        public MantenimentSpecies(String username, String imgProfile)
        {
            FormTitle = "ForaniForm TEST";
            UserName = username;
            profileImg = imgProfile;
            InitializeComponent();
        }
    }
}
