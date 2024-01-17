using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class VectorInput
    {
        public static Vector Usuario(string prompt)
        {
            double x = InputValidator.GetDoubleInput(prompt + " Componente X: ");
            double y = InputValidator.GetDoubleInput(prompt + " Componente Y: ");
            double z = InputValidator.GetDoubleInput(prompt + " Componente Z: ");

            return new Vector(x, y, z);
        }

     }
}

   
