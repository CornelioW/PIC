using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class VectorCalculator
    {
        public static void Main()
        {
            Console.WriteLine("Calculadora de Vectores");

            //INGRESO DE VECTORES POR PARTE DEL USUARIO
            Vector vector1 = VectorInput.Usuario("Ingrese el primer vector:");
            Vector vector2 = VectorInput.Usuario("Ingrese el segundo vector:");

            try
            {
                Vector suma = VectorOperations.Add(vector1, vector2);
                Console.WriteLine("Suma: " + FormatVector(suma));

                Vector resta = VectorOperations.Subtract(vector1, vector2);
                Console.WriteLine("Resta: " + FormatVector(resta));

                double producto = VectorOperations.Product(vector1, vector2);
                Console.WriteLine("Producto: " + producto);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private static string FormatVector(Vector vector)
        {
            return $"({vector.X}, {vector.Y}, {vector.Z})";
        }
    }
}
