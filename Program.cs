using ProvaClasse.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new splash());
=======

            Application.Run(new TestOriol());

>>>>>>> 6005512f3857fa31f19464371323bc6d064afcc4
            Application.Run(new test());
        }
    }
}
