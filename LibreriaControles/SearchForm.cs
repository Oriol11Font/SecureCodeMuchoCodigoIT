using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Windows.Forms;
using LibreriaClases;

namespace LibreriaControles
{
    public sealed partial class SearchForm : BaseForm
    {
        private readonly DataAccessClass _dac = new DataAccessClass();
        public SearchForm()
        {
            InitializeComponent();
            SetData();
            ApplyStyle();
            DoubleBuffered = true;
        }

        private void SetData()
        {
            var ds = _dac.GetTable("Agencies");
            this.dataGrid.DataSource = ds.Tables[0];
        }

        private void ApplyStyle()
        {
            dataGrid.ForeColor = Color.Black;
        }
    }
}