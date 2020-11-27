using LibreriaClases;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace LibreriaControles
{
    public partial class BaseForm: Form
    {
        public bool FontSize { get; set; }

        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set
            {
                _UserName = value;
            }
        }

        public BaseForm()
        {
            InitializeComponent();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Estas segur de tancar la apliació?\nEs pedran tots els canvis no guardats", "ES TANCARA EL PROGRAMA!",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            } 
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            DataAccessClass data = new DataAccessClass();
            String sql = "SELECT * FROM Users WHERE CodeUser = '" + UserName + "'";

            DataSet sqldata = data.GetByQuery(sql);

            DataRow dr = sqldata.Tables[0].Rows[0];

            userName.Text = dr.ItemArray.GetValue(2).ToString();
            userimg.ImageLocation = Application.StartupPath + "\\images\\" + dr.ItemArray.GetValue(7).ToString();
        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
