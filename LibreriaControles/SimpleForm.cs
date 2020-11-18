using LibreriaClases;
using System.Data;
using System.Drawing;

namespace LibreriaControles
{
    public partial class SimpleForm : BaseForm
    {
        private DataSet dts;

        public SimpleForm()
        {
            InitializeComponent();
        }

        private string _Taula = "Agencies";
        public string Taula
        {
            get { return _Taula; }
            set
            {
                _Taula = value;
            }
        }

        private void conn_Click(object sender, System.EventArgs e)
        {
            DataAccessClass dtb = new DataAccessClass();
            string query = "select * from "+Taula;
            dts = dtb.GetByQuery(query);
            dtg.DataSource = dts.Tables[0];
            dtg.ForeColor = Color.Black;
        }
    }
}
