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
            Application.Run(new splash());
        }
        
        // TODO: PROVES DE LA BASE DE DADES. BORRAR QUAN S'ACABI
        private static void DbTest()
        {
            var dtb = new DataAccessClass();
            var query = "Select * From Agencies";
            var ds = dac.GetByQuery(query);
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
            ds.Tables[0].Rows[0].Delete();
            dac.UpdateDb(query, ds);
        }
    }
}