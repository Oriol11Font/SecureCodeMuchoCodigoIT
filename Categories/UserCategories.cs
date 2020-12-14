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
            dtgCategories.Columns[0].Visible = false;
        }
        private void UserCategories_Load(object sender, EventArgs e)
        {
            CarregaDades();

            GenerarBinding();
        }

        private void GenerarBinding()
        {
            CodiCategory.Font = new Font("Microsoft Sans Serif", 12);
            CodiCategory.DataBindings.Clear();
            CodiCategory.DataBindings.Add("Text", cat, CodiCategory.CampoBBDD);

            DescCategory.Font = new Font("Microsoft Sans Serif", 12);
            DescCategory.DataBindings.Clear();
            DescCategory.DataBindings.Add("Text", cat, DescCategory.CampoBBDD);

            LvlCategory.Font = new Font("Microsoft Sans Serif", 12);
            LvlCategory.DataBindings.Clear();
            LvlCategory.DataBindings.Add("Text", cat, LvlCategory.CampoBBDD);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
