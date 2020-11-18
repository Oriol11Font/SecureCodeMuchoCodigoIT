using LibreriaClases;
using System.Data;
using System.Drawing;

namespace LibreriaControles
{
    public partial class SimpleForm : BaseForm
    {
        private readonly DataAccessClass dtb = new DataAccessClass();
        private DataTable _dt;

        public SimpleForm()
        {
            InitializeComponent();

            DataSet ds = dtb.GetTable("Agencies");
            SetData(ds);
            ApplyStyle();
            DoubleBuffered = true;
        }

        private void SetData(DataSet ds)
        {
            _dt = ds.Tables[0];
            dataGridView1.DataSource = _dt;
        }

        private void ApplyStyle()
        {
            dataGridView1.ForeColor = Color.Black;
        }
    }
}
