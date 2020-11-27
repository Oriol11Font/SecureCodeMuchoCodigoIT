using LibreriaClases;
using System.Data;
using System.Drawing;

namespace LibreriaControles
{
    public partial class SimpleForm : BaseForm
    {
        private DataSet _dts;

        public SimpleForm()
        {
            InitializeComponent();
        }

        private string _taula = "Agencies";

        public string Taula
        {
            get { return _taula; }
            set => _taula = value;
        }

        private void conn_Click(object sender, System.EventArgs e)
        {
            DataAccessClass dtb = new DataAccessClass();
            string query = "select * from " + Taula;
            _dts = dtb.GetByQuery(query);
            dtg.DataSource = _dts.Tables[0];
            dtg.ForeColor = Color.Black;
        }
    }
}