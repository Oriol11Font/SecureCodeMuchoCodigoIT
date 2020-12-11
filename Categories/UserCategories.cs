using BasicForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Categories
{
    public partial class UserCategories : BaseForm
    {
        public UserCategories(String username, String imgProfile)
        {
            FormTitle = "Categories dels Usuaris";
            UserName = username;
            profileImg = imgProfile;
            InitializeComponent();
        }

        CategoriesEntities db;
        List<UserCategory> cat;

        private void CarregaDades()
        {
            db = new CategoriesEntities();

            cat = db.UserCategories.ToList();

            dtgCategories.DataSource = cat;
        }
        private void UserCategories_Load(object sender, EventArgs e)
        {
            CarregaDades();
        }
    }
}
