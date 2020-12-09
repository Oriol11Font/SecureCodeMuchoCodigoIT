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

namespace species
{
    public partial class MantenimentSpecies : ForaniForm
    {
        public MantenimentSpecies(String username, String imgProfile)
        {
            FormTitle = "Manteniment Especies";
            UserName = username;
            profileImg = imgProfile;
            InitializeComponent();
        }
    }
}
