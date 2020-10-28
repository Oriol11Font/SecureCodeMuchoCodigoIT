using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;


namespace ControlsMC
{
    public class SWTextBox : TextBox
    {
        public SWTextBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWTextBox
            // 
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter += new System.EventHandler(this.SWTextbox_Enter);
            this.Leave += new System.EventHandler(this.SWTextbox_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SWTextBox_Validating);
            this.ResumeLayout(false);

        }

        private void SWTextbox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void SWTextbox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        public enum TipusDada
        {
            Numero,
            Text,
            Data,
            Codi
        }

        private TipusDada _Tipus;
        public TipusDada Tipus
        {
            get { return _Tipus; }
            set
            {
                _Tipus = value;
            }
        }
        private void SWTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Declaració de variables
            String nombre = this.Name;
            String text = this.Text;

            if (!AllowEmpty && text.Length == 0)
            {
                MessageBox.Show("Aquest camp és obligatori.");
                e.Cancel = true;
            }
            switch (this.Tipus)
            {
                case TipusDada.Numero:
                    if (Regex.IsMatch(text, @"^\d+$"))
                    {
                        e.Cancel = false;
                        this.ForeColor = Color.Black;
                    }
                    else
                    {
                        MessageBox.Show("El valor introduit no és un número, reviseu el camp.");
                        e.Cancel = true;
                        this.ForeColor = Color.Red;
                    }
                    break;
                case TipusDada.Text:
                    break;
                case TipusDada.Data:
                    if (Regex.IsMatch(text, @"^(0?[1-9]|[12][0-9]|3[01])[- /.](0?[1-9]|1[012])[- /.](18|19|20)\d\d$"))
                    {
                        e.Cancel = false;
                        this.ForeColor = Color.Black;
                    }
                    else
                    {
                        MessageBox.Show("La data introduida no es correcte, reviseu que el format sigui: dd/mm/yyyy");
                        e.Cancel = true;
                        this.ForeColor = Color.Red;
                    }
                    break;
                case TipusDada.Codi:
                 //   /*
                    if (Regex.IsMatch(text, @"^([A-Z][A-Z][A-Z][A-Z])[-]([0-9][0-9][0-9])[/][13579][AEIOU]$"))
                    {
                        e.Cancel = false;
                        this.ForeColor = Color.Black;
                    }
                    else
                    {
                        MessageBox.Show("Comproba la sintaxi del codi.");
                        e.Cancel = true;
                        this.ForeColor = Color.Red;
                    }
                    break;
                default:
                    break;
            }            
        }

        private String _CampoBBDD;
        public String CampoBBDD
        {
            get { return _CampoBBDD; }
            set
            {
                _CampoBBDD = value;
            }
        }

        private Boolean _foranea;
        public Boolean Foranea
        {
            get { return _foranea; }
            set
            {
                _foranea = value;
            }
        }

        private Boolean _AllowEmpty = true;
        public Boolean AllowEmpty
        {
            get { return _AllowEmpty; }
            set
            {
                _AllowEmpty = value;
            }
        }
    }
}
