using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class InputValidator
    {
        public static double GetDoubleInput(string prompt)
        {
            double result;
            Console.Write(prompt);

            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Entrada inválida. Inténtelo de nuevo.");
                Console.Write(prompt);
            }

            return result;
        }
    }
}
