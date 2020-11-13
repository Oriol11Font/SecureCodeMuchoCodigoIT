using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LibreriaClases;

namespace LibreriaControles
{
    public sealed partial class SearchForm : BaseForm
    {
        private readonly DataAccessClass _dac = new DataAccessClass();
        private String _searchText;
        private DataTable _dt;
        private DataTable _formattedDt;
        public SearchForm(DataSet ds)
        {
            InitializeComponent();
            SetData(ds);
            ApplyStyle();
            DoubleBuffered = true;
        }

        private void SetData(DataSet ds)
        {
            _dt = ds.Tables[0];
            _formattedDt = _dt;
            dataGrid.DataSource = _dt;
        }

        private void ApplyStyle()
        {
            dataGrid.ForeColor = Color.Black;
        }

        private void HandleSearch()
        {
            _searchText = searchTextBox.Text;
            foreach (DataColumn dtColumn in _dt.Columns)
            {
                listColumns.Items.Add(dtColumn.ColumnName);
            }
        }

        private void HandleTextBoxKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) HandleSearch();   
        }
        
    }
}