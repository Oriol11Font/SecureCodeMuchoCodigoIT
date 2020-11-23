using System;
using System.Reflection;
using System.Windows.Forms;

namespace LibreriaControles
{
    public partial class BaseForm: Form
    {
        public bool FontSize { get; set; }

        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set
            {
                _UserName = value;
            }
        }

        public BaseForm()
        {
            InitializeComponent();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            userName.Text = UserName;
        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Assembly ensamblat = Assembly.LoadFrom("ProvaClasse.exe");

            //Declarem les variables
            Object dllBD;
            Type tipus;

            //recuperem el tipus de la classe que volem instanciar
            tipus = ensamblat.GetType("login.cs");

            //instanciem l’objecte   
            dllBD = Activator.CreateInstance(tipus);

            //el mostrem assumint que es tracta d’un form 
            // i per això fem un cast amb (Form) 
            ((Form)dllBD).Show();
        }
    }
}
