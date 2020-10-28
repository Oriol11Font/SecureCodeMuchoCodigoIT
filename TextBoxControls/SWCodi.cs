using System;
using System.Drawing;
using System.Windows.Forms;
namespace TextBoxControls
{
    public partial class SWCodi : UserControl
    {
        private Boolean Requerit;
        private String FormCS;
        private String ClasseCS;
        private String ControlID;
        private String NomTaula;
        private String NomCodi;
        private String NomDesc = "Salesians Sarria";
        private String NomId;

        public SWCodi()
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
        //    NomTaula = taula.NomTaula();
            Requerit = true;
            NomCodi = CodiBox.Text;

            String sql = "Select NomDesc, NomCodi, NomId from " + NomTaula + " where NomCodi=" + NomCodi;

            //portarTaula(sql);
            /*
            if (Requerit)
            {
                if ()
                {
                    CodiBox.BackColor = Color.Red;
                    AttentionRequerit.Visible = true;
                }
                else
                {
                    CodiBox.BackColor = Color.White;
                    AttentionRequerit.Visible = false;

                    if (ControlID == nomCodi)
                    {
                        DescBox.Text = nomDesc;
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

                if (ControlID == nomCodi)
                {
                    DescBox.Text = nomDesc;
                }
                else
                {
                    AttentionRequerit.Visible = true;
                    DescBox.Text = "Unknown data";
                }
            }*/
        }
    }
}
