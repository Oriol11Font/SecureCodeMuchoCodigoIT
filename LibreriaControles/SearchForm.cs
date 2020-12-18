using LibreriaClases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BasicForms
{
    public partial class SearchForm : BaseForm
    {
        private DataTable _dt;
        private DataTable _formattedDt;
        protected string DtName { get; set; } = "Agencies";
        protected Dictionary<string, string> SearchStrings { get; set; } = new Dictionary<string, string>();

        protected SearchForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
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
                }
                else
                {
                    throw new Exception(@"El nom de la taula no s'ha declarat");
                }
            }
            catch (Exception e)
            {
                _ = MessageBox.Show($@"No s'ha pogut mostrar la taula per cercar. Excepció {e}");
            }
        }

        protected void HandleSearch()
        {
            try
            {
                errLabel.Visible = false;
                if (SearchStrings != null && SearchStrings.Count > 0)
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
                }
                else
                {
                    throw new Exception("No hi ha paraules per filtrar");
                }
            }
            catch (Exception error)
            {
                if (error is InvalidOperationException)
                {
                    errLabel.Text = @"No hi ha dades que s'assemblin a la teva consulta";
                }
                else
                {
                    errLabel.Text = @"No s'ha pogut filtrar la teva consulta";
                }
                errLabel.Visible = true;
            }
            finally
            {
                SearchStrings.Clear();
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

        protected void ClearSearch()
        {
            try
            {
                errLabel.Visible = false;
                SearchStrings.Clear();
                _formattedDt = _dt;
                dtg.DataSource = _formattedDt;
                ClearControls(null, null);
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void ClearControls(object sender, EventArgs e)
        {
            Controls
                .OfType<TextBox>()
                .ToList()
                .ForEach(textBox =>
                {
                    textBox.Text = @"";
                });
        }

        private void Close(object sender, EventArgs e) => Close();
    }
}