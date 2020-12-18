using LibreriaClases;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace TextBoxControls
{
    public partial class MCCodi : UserControl
    {
        private int _ControlID;

        DataAccessClass data = new DataAccessClass();

        DataSet sqldata;

        public MCCodi()
        {
            InitializeComponent();
        }

        public bool Requerit { get; set; }

        public string FormCS { get; set; }

        public string dll { get; set; }

        public string NomTaula { get; set; }

        public string NomId { get; set; }

        public string NomCodi { get; set; }

        public string NomDesc { get; set; }

        public int ControlID
        {
            get =>
                //controltxt.Text = _ControlID.ToString();
                _ControlID;
            set
            {
                _ControlID = value;
                controltxt.Text = _ControlID.ToString();
            }
        }

        private void ValidacioCodi(object sender, EventArgs e)
        {
            //NomTaula="dbo.Sectors";
            var Codi = CodiBox.Text;

            var sql = "Select " + NomId + ", " + NomCodi + ", " + NomDesc + " from " + NomTaula + " where " + NomCodi +
                      "='" + Codi + "'";

            sqldata = data.GetByQuery(sql);

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
                    if (sqldata.Tables[0].Rows.Count > 0)
                    {
                        var dr = sqldata.Tables[0].Rows[0];

                        var CodiTaula = dr.ItemArray.GetValue(1).ToString();

                        CodiBox.BackColor = Color.White;
                        AttentionRequerit.Visible = false;

                        if (Codi == CodiTaula)
                        {
                            DescBox.Text = dr.ItemArray.GetValue(2).ToString();
                            ControlID = int.Parse(dr.ItemArray.GetValue(0).ToString());
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
            }
            else
            {
                if (Codi.Length > 0)
                {
                    if (sqldata.Tables[0].Rows.Count > 0)
                    {
                        var dr = sqldata.Tables[0].Rows[0];
                        var CodiTaula = dr.ItemArray.GetValue(1).ToString();

                        if (Codi == CodiTaula)
                        {
                            DescBox.Text = dr.ItemArray.GetValue(2).ToString();
                            ControlID = int.Parse(dr.ItemArray.GetValue(0).ToString());
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

        private void ObreCS(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                //MessageBox.Show("Has obert la Taula de Cerca! :)");
                /*Sha de mirar*/
                var ensamblat = Assembly.LoadFrom(dll);

                //Declarem les variables
                object dllBD;
                Type tipus;

                //recuperem el tipus de la classe que volem instanciar
                tipus = ensamblat.GetType(FormCS);

                //instanciem l’objecte   
                dllBD = Activator.CreateInstance(tipus);

                //el mostrem assumint que es tracta d’un form 
                // i per això fem un cast amb (Form) 
                ((Form)dllBD).Show();
            }
        }

        private void controltxt_TextChanged(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM " + NomTaula + " WHERE " + NomId + " = " + controltxt.Text;

            if (!(NomTaula == null || NomId == null))
            {
                var data = new DataAccessClass();

                if (!(NomTaula == "" && NomId == ""))
                {
                    var sqldata = data.GetByQuery(sql);

                    if (!(sqldata == null))
                        if (sqldata.Tables[0].Rows.Count > 0)
                        {
                            var dr = sqldata.Tables[0].Rows[0];

                            CodiBox.Text = dr.ItemArray.GetValue(1).ToString();
                            DescBox.Text = dr.ItemArray.GetValue(2).ToString();
                        }
                }
            }
        }
    }
}