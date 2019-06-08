using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace caPilhaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha p = new Pilha();
            TextReader leitor = System.Console.In;
            TextWriter escritor = System.Console.Out;
            float aux = 1;
            while (aux != 0)
            {
                Console.WriteLine("Escolha uma opção do menu: \n");
                Console.WriteLine("[1] - Inserir elemento na pilha");
                Console.WriteLine("[2] - Remover elemento na pilha");
                Console.WriteLine("[3] - Imprimir pilha");
                Console.WriteLine("[4] - Imprimir pilha invertida");
                Console.WriteLine("[5] - remover elemento especifico na pilha");
                Console.WriteLine("[6] - Sair");

                string op = leitor.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Write("Digite o elemento a ser inserido:\n");
                        String elemento = leitor.ReadLine();
                        int valor = Convert.ToInt32(elemento);
                        p.push(valor);
                        Console.Clear();
                        break;

                    case "2":
                        Console.Write("Um elemento foi removido");
                        Console.WriteLine("Removeu o " + p.pop());
                        Console.Clear();
                        break;

                    case "3":
                        Console.Write("A pilha é:\n");
                        p.print();
                        break;

                    case "4":
                        Console.Write("A pilha é:\n");
                        p.inverte();
                        break;
                    case "5":
                        String element = leitor.ReadLine();
                        int value = Convert.ToInt32(element);
                        p.popNumber(value);
                        Console.Write("Um elemento foi removido");
                        Console.Clear();
                        break;
                    case "6":
                        aux = 0;
                        break;

                }
            }
        }
    }
}

//NohPilha no1 = new NohPilha(5, null);
//Console.WriteLine("Data: " + no1.Data);
//            no1.Data = 8;
//            Console.WriteLine("Data: " + no1.Data);