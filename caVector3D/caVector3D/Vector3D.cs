using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVector3D
{
    class Vector3D : Vector2D
    {
        private double z;

        public Vector3D()
        {
            x = 0;
            y = 0;
            z = 0;

        }
        public Vector3D(double _x, double _y, double _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        public double Z{get => z; set => z = value;}

        public Vector3D prodVec(Vector3D vec)
        {
            double i = (y * vec.Z) - (z * vec.Y);
            double j = (z * vec.X) - (x * vec.Z);
            double k = (x * vec.Y) - (y * vec.X);
            Vector3D w = new Vector3D(i, j, k);
            return w;
        }
        public override double modulo()
        {
            double x1 = x * x;
            double y1 = y * y;
            double z1 = z * z;
            return Math.Sqrt(x1 + y1 + z1);
        }
    }
}
