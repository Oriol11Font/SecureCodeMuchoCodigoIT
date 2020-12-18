using BasicForms;

namespace InitialFormsLibrary
{
    public partial class MenuOptions : SimpleForm
    {
        public MenuOptions(string username, string imgProfile)
        {
            FormTitle = @"Opcions de menú";
            UserName = username;
            profileImg = imgProfile;
            Taula = "MenuOptions";
            InitializeComponent();
        }
    }
}