using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP___Download
{
    class ProgramFTP
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            while (input != "exit")
            {
                if (input  == "hola")
                {
                    Console.WriteLine(input);
                } else {
                    Console.WriteLine("Te jodes");
                }

                input = Console.ReadLine();
                
            }
        }
    }
}
