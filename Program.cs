using ProvaClasse.Forms;
using System;
using System.Windows.Forms;
using LibreriaClases;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using LibreriaControles;

namespace ProvaClasse
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var dtb = new DataAccessClass();
            var ds = dtb.GetTable("Agencies");
            Application.Run(new SimpleForm());
        }
    }
}