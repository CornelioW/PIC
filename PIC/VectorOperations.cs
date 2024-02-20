using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class VectorOperations
    {
        public static Vector Add(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector Subtract(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            double x = v1.X * v2.X;
            double y = v1.Y * v2.Y; 
            double z = v1.Z * v2.Z;

            return new Vector(x, y, z);
        }

    }
}
