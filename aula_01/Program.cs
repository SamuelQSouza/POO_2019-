using System;

namespace aula01
{
    class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("ta ok!?");
        Retangulo r1 = new Retangulo(); //criando um objeto da classe retangulo
        Console.WriteLine(r1.basis);
        Console.WriteLine(r1.altura);

        Retangulo r2 = new Retangulo(15.0,25.0); //criando um objeto da classe retangulo
        Console.WriteLine(r2.basis);
        Console.WriteLine(r2.altura);

        Console.WriteLine(r1.Area());
        Console.WriteLine(r2.Area());

        Console.WriteLine(r1.Perimetro());
        Console.WriteLine(r2.Perimetro());
        }
    }
}
