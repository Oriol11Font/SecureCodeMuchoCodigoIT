using LibreriaClases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LibreriaControles
{
    public partial class SearchForm : BaseForm
    {
        private DataTable _dt;
        private DataTable _formattedDt;

        public SearchForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        public void Init(string DtName)
        {
            DataAccessClass dac = new DataAccessClass();
            try
            {
                ApplyStyle();
                SetData(dac.GetTable(DtName));
            }
            catch (Exception e)
            {
                MessageBox.Show($@"No s'ha pogut mostrar la taula per cercar. Excepció {e}");
            }
        }

        public void HandleSearch(Dictionary<string, string> SearchStrings)
        {
            try
            {
                _formattedDt = _dt;
                foreach (var searchString in SearchStrings)
                {
                    if (!string.IsNullOrEmpty(searchString.Value))
                    {
                        var val = searchString.Value.ToString();
                        DataView dv = new DataView(_formattedDt);
                        dv.RowFilter = $"{searchString.Key} LIKE '%{searchString.Value}%'";
                        _formattedDt = dv.ToTable();
                        var lol = _formattedDt.Rows.Count;
                        _formattedDt.Clear();
                        _formattedDt = dv.ToTable();
                    }
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
            dataGrid.Size = new Size(Screen.PrimaryScreen.Bounds.Width, (Screen.PrimaryScreen.Bounds.Height / 3) * 2);
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