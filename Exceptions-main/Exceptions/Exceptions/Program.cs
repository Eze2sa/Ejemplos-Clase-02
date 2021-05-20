using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                NivelUno.Uno();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n Error capturado en Main: { ex.Message } \n");
                Console.WriteLine($"Recorrido del Error { ex.StackTrace } \n");
                Console.WriteLine($"Excepción Interna: { ex.InnerException } \n");
            }

            Console.ReadKey();
        }
    }
}
