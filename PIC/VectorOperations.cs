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
            double x = v1.Y * v2.Z + v1.Z * v2.Y;
            double y = v1.Z * v2.X + v1.X * v2.Z;
            double z = v1.X * v2.Y + v1.Y * v2.X;

            return new Vector(x, y, z);
        }

    }
}
