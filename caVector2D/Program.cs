using System;

namespace caVector2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vector2d v1 = new Vector2d();
            Vector2d v2 = new Vector2d();
            
            v1.setX(1.0);
            v1.setY(1.0);
            v2.setX(1.0);
            v2.setY(0.0);
                
            
            Console.WriteLine("o y do vetor v1: " + v1.getY());
            Console.WriteLine("o x do vetor v1: " + v1.getX());
            Console.WriteLine("o y do vetor v2: " + v2.getY());
            Console.WriteLine("o x do vetor v2: " + v2.getX());
            Console.WriteLine("o modulo do vetor v1: " + v1.modulovet()); 
            Console.WriteLine("o produto escalar do vetor v1: " + v1.prodEsc(v2)); 
            Console.WriteLine("o modulo do vetor v2: " + v2.modulovet()); 
            Console.WriteLine("o produto escalar do vetor v2: " + v2.prodEsc(v1)); 
            Console.WriteLine("angulo entre os vetores: " + v1.angVet(v2));
            Console.WriteLine("angulo entre os vetores: " + v2.angVet(v1));
            Console.WriteLine("projeçao de v1 em v2: " + v1.projVet(v2));
        }        
    }
}
