using BasicForms;
using System;

namespace TestsForms
{
    public partial class TestSimple : SimpleForm
    {
        public TestSimple(String username, String imgProfile)
        {
            FormTitle = "ForaniForm TEST";
            UserName = username;
            profileImg = imgProfile;
            InitializeComponent();
        }
    }
}
