using ControlsMC;
using LibreriaClases;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LibreriaControles
{
    public partial class SimpleForm : BaseForm
    {
        public DataSet dts;

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

        private string[] _NomColumn = {};
        public string[] NomColumn
        {
            get { return _NomColumn; }
            set
            {
                _NomColumn = value;
            }
        }

        private void btn_actualitzar_Click(object sender, System.EventArgs eA)
        {
            try
            {
                    string query = "select * from " + Taula;
                    DataAccessClass dtb = new DataAccessClass();
                    dtb.UpdateDb(query, dts);
                    btn_actualitzar.ForeColor = Color.LawnGreen;
            } catch (Exception e)
            {
                btn_actualitzar.ForeColor = Color.Red;
                MessageBox.Show("SimpleForm - Error updating DataBase with actual information: " + e.Message);
            }
        }

        private void btn_actualitzar_Leave(object sender, EventArgs e)
        {
            btn_actualitzar.ForeColor = Color.White;
        }

        private void NomColumnes()
        {
            int cont = 0;
            if (!(NomColumn.Length == 0))
            {
                for (int i = 1; (i < dts.Tables[0].Columns.Count); i++)
                {
                        dtg.Columns[i].HeaderText = NomColumn[cont];
                        cont++;
                }
            }
        }

        private void SimpleForm_Load(object sender, EventArgs eA)
        {
            try
            {
                DataAccessClass dtb = new DataAccessClass();
                string query = "select * from " + Taula;
                dts = dtb.GetByQuery(query);

                dtg.DataSource = dts.Tables[0];
                dtg.Columns[0].Visible = false;
                dtg.ForeColor = Color.Black;
                NomColumnes();
                
                foreach (Control txt in this.Controls)
                {
                    if (txt.GetType()==typeof(SWTextBox))
                    {
                        SWTextBox txt1 = (SWTextBox)txt;
                        txt1.DataBindings.Clear();
                        txt1.DataBindings.Add("Text", dts.Tables[0], txt1.CampoBBDD);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("SimpleForm - Error connection with DataBase: " + e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createbtn_Click(object sender, EventArgs eA)
        {
            try
            {
                dts.Tables[0].Rows.Add();
                createbtn.ForeColor = Color.LawnGreen;
            }
            catch (Exception e)
            {
                createbtn.ForeColor = Color.Red;
                MessageBox.Show("SimpleForm - Error creating new row: " + e.Message);
            }
        }

        private void createbtn_Leave(object sender, EventArgs e)
        {
            createbtn.ForeColor = Color.White;
        }
    }
}
