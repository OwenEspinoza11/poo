using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    // La clase donde se guardan las extensiones debe ser estática
    public static class Extensiones
    {
        // El método que extiende debe ser estático
        // El primer parámetro lleva this y representa el tipo que estamos
        // extendiendo
        public static bool EsPar(this int i)
        {
            if(i % 2 == 0)
                return true;
            else
                return false;
        }

        public static double Duplica(this double d)
        {
            return d * 2;
        }
    }
}
