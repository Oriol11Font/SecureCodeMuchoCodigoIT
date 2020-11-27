using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxControls
{
    public partial class exeButton : PictureBox
    {
        public exeButton()
        {
            InitializeComponent();
        }

        private String _Form;
        public String Form
        {
            get { return _Form; }
            set
            {
                _Form = value;
            }
        }

        private String _Classe;
        public String Classe
        {
            get { return _Classe; }
            set
            {
                _Classe = value;
            }
        }

        private void exeButton_Click(object sender, EventArgs e)
        {
            Assembly ensamblat = Assembly.LoadFrom(Classe);

            //Declarem les variables
            Object dllBD;
            Type tipus;

            //recuperem el tipus de la classe que volem instanciar
            tipus = ensamblat.GetType(Form);

            //instanciem l’objecte   
            dllBD = Activator.CreateInstance(tipus);

            //el mostrem assumint que es tracta d’un form 
            // i per això fem un cast amb (Form) 
            ((Form)dllBD).Show();
        }
    }
}

