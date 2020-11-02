using ProvaClasse.Forms;
using System;
using System.Windows.Forms;
using LibreriaClases;
using System.Data;

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
            var dac = new DataAccessClass();
            var query = "SELECT * FROM Agencies";
            var ds = dac.GetByQuery(query);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = 6;
            dr[1] = "23D";
            dr[2] = "JAJAJA TUS MUERTOS";
            ds.Tables[0].Rows.Add(dr);
            dac.UpdateDb(query, ds);
            var changes = ds.HasChanges();
            MessageBox.Show(changes.ToString());

        }
    }
}