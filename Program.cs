using ProvaClasse.Forms;
using System;
using System.Windows.Forms;
using LibreriaClases;
using System.Data;
using System.Diagnostics.Eventing.Reader;

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
            // Application.Run(new login());
            DbTest();
        }
        
        // TODO: PROVES DE LA BASE DE DADES. BORRAR QUAN S'ACABI
        private static void DbTest()
        {
            var dac = new DataAccessClass();
            var ds = dac.GetTable("Agencies");
            DataRow dr = ds.Tables[0].NewRow();
            DataRow dr2 = ds.Tables[0].NewRow();
            dr[0] = 6;
            dr[1] = "23D";
            dr[2] = "PRUEBA HAJJAJAJAJJA";
            ds.Tables[0].Rows.Add(dr);
            dr2[0] = 123;
            dr2[1] = "45J";
            dr2[2] = "AAAAAAAAAAAAAAAAAAAA";
            ds.Tables[0].Rows.Add(dr2);
            dac.UpdateDb(ds);
        }
    }
}