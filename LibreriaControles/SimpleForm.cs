using LibreriaClases;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

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

        private string[] _NomColumn;
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
                MessageBox.Show("Error updating DataBase with actual information " + e.Message);
            }
        }

        private void btn_actualitzar_Leave(object sender, EventArgs e)
        {
            btn_actualitzar.ForeColor = Color.White;
        }

        private void NomColumnes()
        {
            int cont = 0;
            if (!(NomColumn is null))
            {
                for (int i = 1; i < dts.Tables[0].Columns.Count; i++)
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

            }
            catch (Exception e)
            {
                MessageBox.Show("Error connection with DataBase " + e.Message);
            }
        }

        /*private void dtgStart ()
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

            }
            catch (Exception e)
            {
                MessageBox.Show("Error connection with DataBase " + e.Message);
            }
        }*/
    }
}
