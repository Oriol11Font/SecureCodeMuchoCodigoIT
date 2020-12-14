using BasicForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace planets
{
    public partial class MantenimentPlanets : ForaniForm
    {
        public MantenimentPlanets(String username, String imgProfile)
        {
            SqlConnectionStringBuilder UserEntities = new SqlConnectionStringBuilder();

            //Console.WriteLine(builder.WriteLine);
            UserEntities.ConnectionString = $"Data Source={Environment.MachineName}\\SQLEXPRESS;Initial Catalog=SecureCore;Integrated Security=SSPI;User Id=secureCoreApplication;Password=test123456789";
            
            FormTitle = "Manteniment Planetes";
            UserName = username;
            profileImg = imgProfile;
            ids = new int[] {0, 3, 7, 8};
            InitializeComponent();
        }
    }
}
