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
            // DbTest();
        }
        
        // TODO: PROVES DE LA BASE DE DADES. BORRAR QUAN S'ACABI
        private static void DbTest()
        {
            var dac = new DataAccessClass();
            var ds = dac.GetTable("Agencies");
            var dr = ds.Tables[0].Rows[0].ItemArray;
            // MessageBox.Show($@"ID: {dr.GetValue(0)}, CODI: {dr.GetValue(1)}, DESCRIPCIÓ: {dr.GetValue(2)}, LONGITUD: {dr.Length}");
            dr[0] = 6;
            dr[1] = "23D";
            dr[2] = "JAJAJA TUS MUERTOS";
            ds.Tables[0].Rows.Add(dr);
            dac.UpdateDb("SELECT * FROM Agencies", ds);
        }
    }
}