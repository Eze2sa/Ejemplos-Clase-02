using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public static class NivelTres
    {
        public static void Tres()
        {
            //try
            //{
                throw new Exception("Error en nivel 3");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error capturado donde ocurrió: { ex } ");
            //}
        }
    }
}
