using LibreriaClases;
using LibreriaControles;
using ProvaClasse.Forms;
using System;
using System.Data;
using System.Windows.Forms;

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
            Application.Run(new newsplash());
        }
    }
}