using System;
using System.Reflection;
using System.Windows.Forms;

namespace TextBoxControls
{
    public partial class exeButton : PictureBox
    {
        public exeButton()
        {
            InitializeComponent();
        }

        public string Form { get; set; }

        public string Classe { get; set; }

        private void exeButton_Click(object sender, EventArgs e)
        {
            var ensamblat = Assembly.LoadFrom(Classe);

            //Declarem les variables
            object dllBD;
            Type tipus;

            //recuperem el tipus de la classe que volem instanciar
            tipus = ensamblat.GetType(Form);

            //instanciem l’objecte   
            dllBD = Activator.CreateInstance(tipus);

            //el mostrem assumint que es tracta d’un form 
            // i per això fem un cast amb (Form) 
            ((Form) dllBD).Show();
        }

        private void exeButton_MouseHover(object sender, EventArgs e)
        {
            Margin = new Padding(35);
        }

        private void exeButton_MouseLeave(object sender, EventArgs e)
        {
            Margin = new Padding(50);
        }
    }
}