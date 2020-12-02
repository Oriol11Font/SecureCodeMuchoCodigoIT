using BasicForms;
using System;
using System.Windows.Forms;

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
