using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVector3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2D v1 = new Vector2D();
            Console.WriteLine("\nPrint Vector no R2: (" + v1.X + "," + v1.Y + ")");
            Vector2D v2 = new Vector2D(1, 2);
            Console.WriteLine("\nPrint Vector no R2: (" + v2.X + "," + v2.Y + ")");
            Vector2D vts1 = new Vector2D(2, 3);
            Vector3D vp1 = v2.prodVec(vts1);
            Console.WriteLine("\nProdutor vetor 2D ao z = 0 resulta: (" + vp1.X + "," + vp1.Y + "," + vp1.Z + ")");
            Console.WriteLine("\nModulo do Vetor: " + v2.modulo());

            Vector3D v3 = new Vector3D();
            Console.WriteLine("\nPrint Vector no R3: (" + v3.X + "," + v3.Y + "," + v3.Z + ")");
            Vector3D v4 = new Vector3D(1, 2, 3);
            Console.WriteLine("\nPrint Vector no R3: (" + v4.X + "," + v4.Y + "," + v4.Z + ")");
            Vector3D vts2 = new Vector3D(1, 1, 2);
            Vector3D vp2 = v4.prodVec(vts2);
            Console.WriteLine("\nPrint Prod.Vectoral no R3: (" + vp2.X + "," + vp2.Y + "," + vp2.Z + ")");
            Console.WriteLine("\nModulo Vetor: " + v4.modulo());
            Console.ReadLine();
        }
    }
}
