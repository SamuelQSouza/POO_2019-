using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVector3D
{
    class Vector2D
    {
        protected double x;
        protected double y;

        public Vector2D()
        {
            x = 0;
            y = 0;
        }

        public Vector2D(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        public double X{get => x; set => x = value;}
        public double Y{get => y; set => y = value;}
        public Vector3D prodVec(Vector2D vec)
        {
            double k1 = x * vec.Y;
            double k2 = y * vec.X;
            Vector3D w = new Vector3D(0, 0, k1 - k2);
            return w;

        }
        public virtual double modulo()
        {
            double r1 = x * x;
            double r2 = y * y;
            return Math.Sqrt(r1 + r2);
        }
    }
}
