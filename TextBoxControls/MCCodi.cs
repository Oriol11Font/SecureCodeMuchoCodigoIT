using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LibreriaClases;
namespace TextBoxControls
{
    public partial class MCCodi : UserControl
    {
        private Boolean Requerit;
        private String FormCS;
        private String ClasseCS;
        private String ControlID;
        private String NomTaula;
        private String NomCodi;
        private String NomDesc = "Salesians Sarria";
        private String NomId;

<<<<<<< HEAD:TextBoxControls/MCCodi.cs
        public MCCodi()
=======
        public SWCodi()
>>>>>>> 277af653629cc2348d05bb16436ad8f6d0e48ab4:TextBoxControls/SWCodi.cs
        {
            InitializeComponent();
        }

        private void ObreCS(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Form formCs = new Form();
                formCs.Text = FormCS;
                formCs.Show();
            }
        }

        private void ValidacioCodi(object sender, EventArgs e)
        {
<<<<<<< HEAD:TextBoxControls/MCCodi.cs
            NomTaula="dbo.Sectors";
=======
        //    NomTaula = taula.NomTaula();
>>>>>>> 277af653629cc2348d05bb16436ad8f6d0e48ab4:TextBoxControls/SWCodi.cs
            Requerit = true;
            NomCodi = CodiBox.Text;

            String sql = "Select DescSector, idSector from " + NomTaula + " where CodiSector=" + NomCodi;

            DataAccessClass data = new DataAccessClass();
            DataSet sqldata = data.getByQuery(sql);

            DataRow dr = sqldata.Tables[0].Rows[3];

            NomId = dr.ItemArray.GetValue(2).ToString();

            if (Requerit)
            {
                if (NomId != null)
                {
                    CodiBox.BackColor = Color.Red;
                    AttentionRequerit.Visible = true;
                }
                else
                {
                    CodiBox.BackColor = Color.White;
                    AttentionRequerit.Visible = false;

                    if (NomId != null)
                    {
                        DescBox.Text = dr.ItemArray.GetValue(1).ToString();
                    }
                    else
                    {
                        AttentionRequerit.Visible = true;
                        DescBox.Text = "Unknown data";
                    }
                }
            }
            else
            {
                CodiBox.BackColor = Color.White;
                AttentionRequerit.Visible = false;

                if (NomId != null)
                {
                    DescBox.Text = dr.ItemArray.GetValue(1).ToString();
                }
                else
                {
                    AttentionRequerit.Visible = true;
                    DescBox.Text = "Unknown data";
                }
            }
        }
    }
}
