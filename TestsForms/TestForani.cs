using BasicForms;
using System;

namespace TestsForms
{
    public partial class TestForani : ForaniForm
    {
        public TestForani(String username, String imgProfile)
        {
            FormTitle = "ForaniForm TEST";
            UserName = username;
            profileImg = imgProfile;
            InitializeComponent();
        }
    }
}
