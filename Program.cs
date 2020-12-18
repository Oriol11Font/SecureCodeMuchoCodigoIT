using System;
using System.Windows.Forms;
using TestsForms;

namespace SecureCoreMain
{
    internal static class Program
    {
        /// <summary>
        ///     Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new newsplash());
        }
    }
}