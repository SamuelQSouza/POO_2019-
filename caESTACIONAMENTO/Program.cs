using System;
using System.Collections.Generic;
using System.Linq;

namespace caESTACIONAMENTO
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempo T1 = new Tempo();
            Tempo T2 = new Tempo();
            T1.cadastrar();
            T2.cadastrar();
            T1.print();
            T2.print();
            Tempo T3 = T1.inc(T2);
            Tempo T4 = T2.dec(T1);
            T3.print();
            T4.print();            
            Carro C1 = new Carro();
            C1.solicitar();
            C1.printcarro();
            C1.preco();

            Console.Write("\nd) Cadastro de 5 carros, e print relatorio.\n");
            List<Carro> listaCarros = new List<Carro>();
            for (int k=0; k<5;k++)
            {
               Carro c = new Carro();
                    c.solicitar();
                    listaCarros.Add(c);
            }
            for(int i = 0; i < listaCarros.Count; i++)
                    {
                        Carro temp = (Carro)listaCarros[i]; //casting
                        int j = i + 1;
                        Console.WriteLine("\nCarro " + j + ":\n");
                        temp.printcarro();
                    }
            Console.ReadLine();

        }
   }
}
