﻿using System;
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

        public string ImageLocation1 { get; set; }

        public string ImageLocation2 { get; set; }

        public string imgProfile { get; set; }

        public string userName { get; set; }

        private void exeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var ensamblat = Assembly.LoadFrom(Classe);

                //Declarem les variables
                object dllBD;
                Type tipus;

                //recuperem el tipus de la classe que volem instanciar
                tipus = ensamblat.GetType(Form);

                Object[] args = { this.userName, this.imgProfile };

                //instanciem l’objecte   
                dllBD = Activator.CreateInstance(tipus, args);

                //el mostrem assumint que es tracta d’un form 
                // i per això fem un cast amb (Form) 
                ((Form)dllBD).Show();

            } catch (Exception ex)
            {
                MessageBox.Show("Aquest botó no està operatiu");
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