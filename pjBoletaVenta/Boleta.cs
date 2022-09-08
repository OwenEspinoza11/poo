using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjBoletaVenta
{
    public static class Boleta
    {
        public static int Numero { get; set; }
        public static string? Cliente { get; set; }
        public static string? Direccion { get; set; }
        public static string? Cedula { get; set; }
        public static DateTime Fecha { get; set; }
        public static string? Producto { get; set; }
        public static int Cantidad { get; set; }

        // Métodos para determinar el precio del producto
        public static double DeterminaPrecio()
        {
            switch (Producto)
            {
                case "PS5 + 1 MANDO DS5": return 500;
                case "PS4(1TB) + 1 MANDO DS4": return 619;
                case "MANDO PS5/DS5": return 69;
                case "MANDO PS4/DS4": return 60;
            }
            return 0;
        }

        // Método para determinar el importe
        public static double Calculalmporte()
        {
            return Cantidad * DeterminaPrecio();
        }
    }
}
