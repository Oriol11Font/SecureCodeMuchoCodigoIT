using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LibreriaClases;
using System.Text.RegularExpressions;
using System.Reflection;
using LibreriaControles;

namespace TextBoxControls
{
    public partial class MCCodi : UserControl
    {
        private String ControlID;

        public MCCodi()
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

        private String _NomTaula;
        public String NomTaula
        {
            get { return _NomTaula; }
            set
            {
                _NomTaula = value;
            }
        }

        private String _NomId;
        public String NomId
        {
            get { return _NomId; }
            set
            {
                _NomId = value;
            }
        }

        private String _NomCodi;
        public String NomCodi
        {
            get { return _NomCodi; }
            set
            {
                _NomCodi = value;
            }
        }

        private String _NomDesc;
        public String NomDesc
        {
            get { return _NomDesc; }
            set
            {
                _NomDesc = value;
            }
        }

        private void ValidacioCodi(object sender, EventArgs e)
        {

            //NomTaula="dbo.Sectors";
            String Codi = CodiBox.Text;

            String sql = "Select "+NomId+", "+NomCodi+", "+NomDesc+"from " + NomTaula + " where CodiSector='" + Codi+"'";

            //FALTA CONECTAR LA BASE DE DATOS PARA COGER LA INFORMACION

            //DataAccessClass data = new DataAccessClass();
            //DataSet sqldata = data.getByQuery(sql);

            //DataRow dr = sqldata.Tables[0].Rows[3];

            //String CodiTaula = dr.ItemArray.GetValue(2).ToString();

            String CodiTaula = "S1J";

            if (Requerit)
            {
                if (Codi.Length == 0)
                {
                    CodiBox.BackColor = Color.Red;
                    AttentionRequerit.Visible = true;
                    DescBox.Text = "Campo Requerido";
                }
                else
                {
                    CodiBox.BackColor = Color.White;
                    AttentionRequerit.Visible = false;

                    if (Codi == CodiTaula)
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

                if (Codi == CodiTaula)
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
                MessageBox.Show("Has obert la Taula de Cerca! :)");
            }
        }
    }
}
