using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LibreriaClases;

namespace BasicForms
{
    public partial class SearchForm : BaseForm
    {
        private DataTable _dt;
        private DataTable _formattedDt;

        public SearchForm()
        {
            InitializeComponent();
        }

        public void Init(string dtName)
        {
            DoubleBuffered = true;
            var dac = new DataAccessClass();
            try
            {
                ApplyStyle();
                SetData(dac.GetTable(dtName));
            }
            catch (Exception e)
            {
                MessageBox.Show($@"No s'ha pogut mostrar la taula per cercar. Excepció {e}");
            }
        }

        public void HandleSearch(Dictionary<string, string> searchStrings)
        {
            try
            {
                _formattedDt = _dt;
                foreach (var searchString in searchStrings)
                    if (!string.IsNullOrEmpty(searchString.Value))
                    {
                        var dv = new DataView(_formattedDt)
                        {
                            RowFilter = $"{searchString.Key} LIKE '%{searchString.Value}%'"
                        };
                        _formattedDt = dv.ToTable();
                        _formattedDt.Clear();
                        _formattedDt = dv.ToTable();
                    }

                dataGrid.DataSource = _formattedDt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                _formattedDt = _dt;
                dataGrid.DataSource = _formattedDt;
            }
        }

        private void SetData(DataSet ds)
        {
            _dt = ds.Tables[0];
            _formattedDt = _dt;
            dataGrid.DataSource = _formattedDt;
        }

        private void ApplyStyle()
        {
            dataGrid.ForeColor = Color.Black;
            dataGrid.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height / 3 * 2);
        }

        public void ClearSearch()
        {
            try
            {
                _formattedDt = _dt;
                dataGrid.DataSource = _formattedDt;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }
    }
}