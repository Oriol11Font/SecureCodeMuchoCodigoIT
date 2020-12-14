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

namespace planets
{
    public partial class MantenimentPlanets : ForaniForm
    {
        public MantenimentPlanets(String username, String imgProfile)
        {
            FormTitle = "Manteniment Planetes";
            UserName = username;
            profileImg = imgProfile;
            ids = new int[] {0, 3, 7, 8};
            InitializeComponent();
        }
    }
}
