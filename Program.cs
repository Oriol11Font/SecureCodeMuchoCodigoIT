<<<<<<< HEAD
﻿using System;
using System.Data;
using System.Windows.Forms;
using LibreriaClases;
using LibreriaControles;
using ProvaClasse.Forms;
=======
﻿using LibreriaControles;
using ProvaClasse.Forms;
using System;
using System.Windows.Forms;
>>>>>>> b91467d0016be5a888474066fbaa0b16d6fafd67

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
<<<<<<< HEAD
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
=======
            Application.Run(new TestOriol());
>>>>>>> b91467d0016be5a888474066fbaa0b16d6fafd67
        }
    }
}