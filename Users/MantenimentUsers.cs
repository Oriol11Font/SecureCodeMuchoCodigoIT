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

namespace Users
{
    public partial class MantenimentUsers : BaseForm
    {
        public MantenimentUsers(String username, String imgProfile)
        {
            FormTitle = "Manteniment Usuaris";
            UserName = username;
            profileImg = imgProfile;
            InitializeComponent();
        }

        UserEntities db;
        List<User> usr; 
        private void MantenimentUsers_Load(object sender, EventArgs e)
        {
            CarregaDades();
        }

        private void CarregaDades()
        {

            db = new UserEntities();
            usr = db.Users.ToList();
            dtg.DataSource = usr;
        }
    }
}
