using System;

namespace PIC
{
    internal class VectorCalculator
    {
        public static void Main()
        {
            Console.WriteLine("Operaciones con Vectores");

            while (true)
            {
                Console.WriteLine("\nMenú:");
                Console.WriteLine("1. Sumar vectores");
                Console.WriteLine("2. Restar vectores");
                Console.WriteLine("3. Calcular producto punto");
                Console.WriteLine("4. Salir");

                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        SumarVectores();
                        break;
                    case "2":
                        RestarVectores();
                        break;
                    case "3":
                        CalcularProductoEscalar();
                        break;
                    case "4":
                        Console.WriteLine("Saliendo del programa.");
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }

        private static void SumarVectores()
        {
            Console.WriteLine("\nSuma de Vectores:");
            Vector vector1 = VectorInput.Usuario("Ingrese el primer vector:");
            Vector vector2 = VectorInput.Usuario("Ingrese el segundo vector:");
            Vector suma = VectorOperations.Add(vector1, vector2);
            Console.WriteLine("Resultado de la suma: " + FormatVector(suma));
        }

        private static void RestarVectores()
        {
            Console.WriteLine("\nResta de Vectores:");
            Vector vector1 = VectorInput.Usuario("Ingrese el primer vector:");
            Vector vector2 = VectorInput.Usuario("Ingrese el segundo vector:");
            Vector resta = VectorOperations.Subtract(vector1, vector2);
            Console.WriteLine("Resultado de la resta: " + FormatVector(resta));
        }

        private static void CalcularProductoEscalar()
        {
            Console.WriteLine("\nProducto Escalar:");
            Vector vector1 = VectorInput.Usuario("Ingrese el primer vector:");
            Vector vector2 = VectorInput.Usuario("Ingrese el segundo vector:");
            double producto = VectorOperations.Product(vector1, vector2);
            Console.WriteLine("Resultado del producto escalar: " + producto);
        }

        private static string FormatVector(Vector vector)
        {
            return $"({vector.X}, {vector.Y}, {vector.Z})";
        }
    }
}
