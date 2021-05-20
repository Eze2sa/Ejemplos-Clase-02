using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public static class NivelDos
    {
        public static void Dos()
        {
            try
            {
                NivelTres.Tres();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error capturado en nivel 2: { ex } \n");
                throw new Exception("Error en Nivel 2", ex);
            }
        }
    }
}

