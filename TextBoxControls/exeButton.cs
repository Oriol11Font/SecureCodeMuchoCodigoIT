using System;
using System.Reflection;
using System.Windows.Forms;

namespace TextBoxControls
{
    public partial class ExeButton : PictureBox
    {
        public ExeButton()
        {
            InitializeComponent();
        }

        public string Form { get; set; }

        public string Classe { get; set; }

        public string ImageLocation1 { get; set; }

        public string ImageLocation2 { get; set; }

        public string ImgProfile { get; set; }

        public string UserName { get; set; }

        private void exeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var ensamblat = Assembly.LoadFrom(Classe);

                //recuperem el tipus de la classe que volem instanciar
                var tipus = ensamblat.GetType(Form);

                object[] args = { UserName, ImgProfile };

                //instanciem l’objecte   
                var dllBD = Activator.CreateInstance(tipus, args);

                //el mostrem assumint que es tracta d’un form 
                // i per això fem un cast amb (Form) 
                ((Form)dllBD).Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Aquest botó no està operatiu " + ex);
            }

        }

        private void exeButton_MouseHover(object sender, EventArgs e)
        {
            Margin = new Padding(35);
            ImageLocation = ImageLocation2;
        }

        private void exeButton_MouseLeave(object sender, EventArgs e)
        {
            Margin = new Padding(50);
            ImageLocation = ImageLocation1;
        }
    }
}