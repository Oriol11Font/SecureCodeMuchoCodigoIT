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
    public partial class McCodi : UserControl
    {
        public McCodi()
        {
            InitializeComponent();
        }

        private Boolean _requerit;
        public Boolean Requerit
        {
            get { return _requerit; }
            set
            {
                _requerit = value;
            }
        }

        private String _fromCs;
        public String FormCs
        {
            get { return _fromCs; }
            set
            {
                _fromCs = value;
            }
        }

<<<<<<< HEAD
        private String _classeCs;
        public String ClasseCs
        {
            get { return _classeCs; }
            set
            {
                _classeCs = value;
=======
        private String _dll;
        public String dll
        {
            get { return _dll; }
            set
            {
                _dll = value;
>>>>>>> b91467d0016be5a888474066fbaa0b16d6fafd67
            }
        }

        private String _nomTaula;
        public String NomTaula
        {
            get { return _nomTaula; }
            set
            {
                _nomTaula = value;
            }
        }

        private String _nomId;
        public String NomId
        {
            get { return _nomId; }
            set
            {
                _nomId = value;
            }
        }

        private String _nomCodi;
        public String NomCodi
        {
            get { return _nomCodi; }
            set
            {
                _nomCodi = value;
            }
        }

        private String _nomDesc;
        public String NomDesc
        {
            get { return _nomDesc; }
            set
            {
                _nomDesc = value;
            }
        }

        private int _controlId;
        public int ControlId
        {
            get { return _controlId; }
            set
            {
                _controlId = value;
            }
        }

        private void ValidacioCodi(object sender, EventArgs e)
        {

            //NomTaula="dbo.Sectors";
            String codi = CodiBox.Text;

            String sql = "Select "+NomId+", "+NomCodi+", "+NomDesc+" from " + NomTaula + " where "+NomCodi+"='" + codi+"'";

            DataAccessClass data = new DataAccessClass();
            DataSet sqldata = data.GetByQuery(sql);

            if (Requerit)
            {
                if (codi.Length == 0)
                {
                    CodiBox.BackColor = Color.Red;
                    AttentionRequerit.Visible = true;
                    DescBox.Text = "Campo Requerido";
                }
                else
                {
                    if (sqldata.Tables[0].Rows.Count > 0)
                    {
                        DataRow dr = sqldata.Tables[0].Rows[0];

                        String codiTaula = dr.ItemArray.GetValue(1).ToString();

                        CodiBox.BackColor = Color.White;
                        AttentionRequerit.Visible = false;

                        if (codi == codiTaula)
                        {
                            DescBox.Text = dr.ItemArray.GetValue(2).ToString();
                            ControlId = Int32.Parse(dr.ItemArray.GetValue(0).ToString());
                            //DescBox.Text = "Salesians de Sarria";
                        }
                    }
                    else
                    {
                        CodiBox.BackColor = Color.White;
                        AttentionRequerit.Visible = true;
                        DescBox.Text = "Unknown data";
                    }
                }
            } else
            {
                if (codi.Length > 0)
                {
                    if (sqldata.Tables[0].Rows.Count > 0)
                    {
                        DataRow dr = sqldata.Tables[0].Rows[0];
                        String codiTaula = dr.ItemArray.GetValue(1).ToString();

                        if (codi == codiTaula)
                        {
                            DescBox.Text = dr.ItemArray.GetValue(2).ToString();
                            ControlId = Int32.Parse(dr.ItemArray.GetValue(0).ToString());
                            //DescBox.Text = "Salesians de Sarria";
                        }
                    }
                    else
                    {
                        DescBox.Text = "Unknown data";
                    }
                }
                else
                {
                    DescBox.Text = "";
                }
            }
        }

        private void ObreCs(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
<<<<<<< HEAD
                MessageBox.Show(@"Has obert la Taula de Cerca! :)");
                Assembly ensamblat = Assembly.LoadFrom(ClasseCs);
=======
                //MessageBox.Show("Has obert la Taula de Cerca! :)");
                /*Sha de mirar*/
                Assembly ensamblat = Assembly.LoadFrom(dll);
>>>>>>> b91467d0016be5a888474066fbaa0b16d6fafd67

                //Declarem les variables
                Object dllBd;
                Type tipus;

                //recuperem el tipus de la classe que volem instanciar
                tipus = ensamblat.GetType(FormCs);

                //instanciem l’objecte   
                dllBd = Activator.CreateInstance(tipus);

                //el mostrem assumint que es tracta d’un form 
                // i per això fem un cast amb (Form) 
                ((Form)dllBd).Show();
            }
        }
    }
}
