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
        public string DtName { get; set; } = "Agencies";
        public Dictionary<string, string> SearchStrings { get; set; } = new Dictionary<string, string>();

        public SearchForm()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            try
            {
                if (DtName != null)
                {
                    DoubleBuffered = true;
                    var dac = new DataAccessClass();
                    AutoSizeMode = AutoSizeMode.GrowOnly;
                    ApplyStyle();
                    SetData(dac.GetTable(DtName));
                } else
                {
                    throw new Exception("El nom de la taula no s'ha declarat");
                }
            }
            catch (Exception e)
            {
                _ = MessageBox.Show($@"No s'ha pogut mostrar la taula per cercar. Excepció {e}");
            }
        }

        public void HandleSearch()
        {
            try
            {
                if (SearchStrings != null)
                {
                    _formattedDt = _dt;
                    foreach (var searchString in SearchStrings)
                        if (!string.IsNullOrEmpty(searchString.Value))
                        {
                            _formattedDt = _formattedDt.AsEnumerable()
                                .Where(x => x[searchString.Key].ToString().Contains(searchString.Value))
                                .CopyToDataTable();
                        }

                    dtg.DataSource = _formattedDt;
                } else
                {
                    throw new Exception("No hi ha paraules per filtrar");
                }
            }
            catch (Exception error)
            {
                _ = MessageBox.Show(error.ToString());
                _formattedDt = _dt;
                dtg.DataSource = _formattedDt;
            } finally
            {
                ClearSearch();
            }
        }

        private void SetData(DataSet ds)
        {
            _dt = ds.Tables[0];
            _formattedDt = _dt;
            dtg.DataSource = _formattedDt;
        }

        private void ApplyStyle()
        {
            dtg.ForeColor = Color.Black;
            dtg.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height / 3 * 2);
        }

        public void ClearSearch()
        {
            try
            {
                SearchStrings.Clear();
                _formattedDt = _dt;
                dtg.DataSource = _formattedDt;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void button2_click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control cnt in Controls)
            {
                if (cnt.GetType() == typeof(TextBox)) cnt.Text = "";
            }
            ClearSearch();
        }
    }
}