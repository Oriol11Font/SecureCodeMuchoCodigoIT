using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Controls;
using LibreriaClases;

namespace LibreriaControles
{
    public partial class SimpleForm : BaseForm
    {
        public DataSet dts;

        public SimpleForm()
        {
            InitializeComponent();
        }

        public string Taula { get; set; } = "Agencies";

        public string[] NomColumn { get; set; } = { };

        private void btn_actualitzar_Click(object sender, EventArgs eA)
        {
            try
            {
                var query = "select * from " + Taula;
                var dtb = new DataAccessClass();
                dtb.UpdateDb(query, dts);
                btn_actualitzar.ForeColor = Color.LawnGreen;
                Unsaved = false;
            }
            catch (Exception e)
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
            var cont = 0;
            if (!(NomColumn.Length == 0))
                for (var i = 1; i < dts.Tables[0].Columns.Count; i++)
                {
                    dtg.Columns[i].HeaderText = NomColumn[cont];
                    cont++;
                }
        }

        private void SimpleForm_Load(object sender, EventArgs eA)
        {
            try
            {
                var dtb = new DataAccessClass();
                var query = "select * from " + Taula;
                dts = dtb.GetByQuery(query);

                dtg.DataSource = dts.Tables[0];
                dtg.Columns[0].Visible = false;
                dtg.ForeColor = Color.Black;
                NomColumnes();

                foreach (Control txt in Controls)
                    if (txt.GetType() == typeof(SWTextBox))
                    {
                        var txt1 = (SWTextBox) txt;
                        txt1.DataBindings.Clear();
                        txt1.DataBindings.Add("Text", dts.Tables[0], txt1.CampoBBDD);
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show("SimpleForm - Error connection with DataBase: " + e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createbtn_Click(object sender, EventArgs eA)
        {
            try
            {
                dts.Tables[0].Rows.Add();
                createbtn.ForeColor = Color.LawnGreen;
                Unsaved = true;
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