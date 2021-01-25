using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ControlsMC
{
    public class SwTextBox : TextBox
    {
        public enum TipusDada
        {
            Numero,
            Text,
            Data,
            Codi
        }

        public SwTextBox()
        {
            InitializeComponent();
        }

        public TipusDada Tipus { get; set; }

        public string CampoBbdd { get; set; }

        public bool Foranea { get; set; }

        public bool AllowEmpty { get; set; } = true;

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // SWTextBox
            // 
            Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Enter += SWTextbox_Enter;
            Leave += SWTextbox_Leave;
            Validating += SWTextBox_Validating;
            ResumeLayout(false);
        }

        private void SWTextbox_Leave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void SWTextbox_Enter(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
        }

        private void SWTextBox_Validating(object sender, CancelEventArgs e)
        {
            //Declaració de variables
            var nombre = Name;
            var text = Text;

            if (!AllowEmpty && text.Length == 0)
            {
                MessageBox.Show("Aquest camp és obligatori.");
                e.Cancel = true;
            }

            //
            switch (Tipus)
            {
                case TipusDada.Numero:
                    if (Regex.IsMatch(text, @"^\d+$"))
                    {
                        e.Cancel = false;
                        ForeColor = Color.Black;
                    }
                    else
                    {
                        MessageBox.Show("El valor introduit no és un número, reviseu el camp.");
                        e.Cancel = true;
                        ForeColor = Color.Red;
                    }

                    break;
                case TipusDada.Text:
                    break;
                case TipusDada.Data:
                    if (Regex.IsMatch(text, @"^(0?[1-9]|[12][0-9]|3[01])[- /.](0?[1-9]|1[012])[- /.](18|19|20)\d\d$"))
                    {
                        e.Cancel = false;
                        ForeColor = Color.Black;
                    }
                    else
                    {
                        MessageBox.Show("La data introduida no es correcte, reviseu que el format sigui: dd/mm/yyyy");
                        e.Cancel = true;
                        ForeColor = Color.Red;
                    }

                    break;
                case TipusDada.Codi:
                    //   /*
                    if (Regex.IsMatch(text, @"^([A-Z][A-Z][A-Z][A-Z])[-]([0-9][0-9][0-9])[/][13579][AEIOU]$"))
                    {
                        e.Cancel = false;
                        ForeColor = Color.Black;
                    }
                    else
                    {
                        MessageBox.Show("Comproba la sintaxi del codi.");
                        e.Cancel = true;
                        ForeColor = Color.Red;
                    }

                    break;
            }
        }
    }
}