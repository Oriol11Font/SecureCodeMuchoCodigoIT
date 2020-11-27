using System;
using System.Data;
using System.Windows.Forms;
using LibreriaClases;
using LibreriaControles;
using ProvaClasse.Forms;

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
            Application.Run(new Splash());
        }

        static void TestingMethod()
        {
            DataAccessClass dac = new DataAccessClass();
            var ds = dac.GetTable("Agencies");
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = 123;
            dr[1] = "45J";
            dr[2] = "Hola";
            ds.Tables[0].Rows.Add(dr);
            dac.UpdateDb(@"SELECT * FROM Agencies", ds);
        }
    }
}