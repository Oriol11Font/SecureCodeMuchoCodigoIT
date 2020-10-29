using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LibreriaClases;
using System.Text.RegularExpressions;

namespace TextBoxControls
{
    public partial class MCCodi : UserControl
    {
        private String ControlID;
        private String NomTaula;
        private String NomCodi;
        private String NomDesc = "Salesians Sarria";
        private String NomId;

<<<<<<< HEAD
        public MCCodi()
=======

        public MCCodi()

        public SWCodi()
>>>>>>> 6005512f3857fa31f19464371323bc6d064afcc4
        {
            InitializeComponent();
        }

        private Boolean _Requerit;
        public Boolean Requerit
        {
            get { return _Requerit; }
            set
            {
                _Requerit = value;
            }
        }

        private String _FromCS;
        public String FormCS
        {
            get { return _FromCS; }
            set
            {
                _FromCS = value;
            }
        }

        private String _ClasseCS;
        public String ClasseCS
        {
            get { return _ClasseCS; }
            set
            {
                _ClasseCS = value;
            }
        }

        private void ValidacioCodi(object sender, EventArgs e)
        {
<<<<<<< HEAD
            NomTaula="dbo.Sectors";
=======

            NomTaula="dbo.Sectors";
            Requerit = true;
>>>>>>> 6005512f3857fa31f19464371323bc6d064afcc4
            NomCodi = CodiBox.Text;

            //String sql = "Select DescSector, idSector, CodiSector from " + NomTaula + " where CodiSector=" + NomCodi;

            //DataAccessClass data = new DataAccessClass();
            //DataSet sqldata = data.getByQuery(sql);

            //DataRow dr = sqldata.Tables[0].Rows[3];

            //NomId = dr.ItemArray.GetValue(2).ToString();

            NomId = "S1J";

            if (Requerit)
            {
                if (NomId != NomCodi)
                {
                    CodiBox.BackColor = Color.Red;
                    AttentionRequerit.Visible = true;
                    DescBox.Text = "Unknown data";
                }
                else
                {
                    CodiBox.BackColor = Color.White;
                    AttentionRequerit.Visible = false;

                    if (NomId == NomCodi)
                    {
                        //DescBox.Text = dr.ItemArray.GetValue(1).ToString();
                        DescBox.Text = "Salesians de Sarria";
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

                if (NomId == NomCodi)
                {
                    //DescBox.Text = dr.ItemArray.GetValue(1).ToString();
                    DescBox.Text = "Salesians de Sarria";
                }
                else
                {
                    DescBox.Text = "Unknown data";
                }
            }
        }

        private void ObreCS(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Form = FormCS;
                Form formCS = new FormCS();
                //formCs.Text = FormCS;
                FormCS.Show();

                
            }
        }
    }
}
