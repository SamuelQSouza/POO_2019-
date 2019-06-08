using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDinamica
{
    class Pilha
    {
        //Atributos
        NohPilha topo;

        //Metodos
        public Pilha()
        {
            topo = null;
        }

        public bool isEmpty()
        {
            if (topo == null)
                return true;
            else
                return false;
        }

        public void push(int n)
        {
            //Primeira coisa: criar um objeto da classe NohPilha
            NohPilha novo = new NohPilha(n);
            //Segunda coisa: encadear esse novo noh na Pilha
            novo.Next = topo;
            topo = novo;
        }//Fim do metodo push

        public int pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Pilha Vazia - Impossivel Retirar!!");
                return 0;
            }
            else
            {
                int temp = topo.Data;
                topo = topo.Next;
                return temp;
            }
        }

        public void print()
        {
            if (isEmpty())
                Console.WriteLine("Pilha Vazia");
            else
            {
                Console.WriteLine("Status atual da Pilha:");
                NohPilha temp = topo;

                while (temp != null)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Next;
                } 
            }
        }
        //public int maior() { }
        public void inverte()
        {
            if (isEmpty())
                Console.WriteLine("Pilha Vazia");
            else
            {
                NohPilha temp = topo;
                Pilha a = new Pilha();
                while (temp != null)
                {
                    a.push(temp.Data);
                    temp = temp.Next;
                }
                a.print();
            }
        }
        
        public void maior()
        {
            if (isEmpty())
                Console.WriteLine("Pilha Vazia");
            else
            {
                Console.WriteLine("maior elemento da Pilha:");
                NohPilha temp = topo;
                int aux1 = 0;
                while (temp != null)
                {
                    if (temp.Data > aux1)
                    {
                        aux1 =temp.Data;
                    }
                temp = temp.Next;
                }
                Console.WriteLine(aux1);
            }
        }
        public void menor()
        {
            if (isEmpty())
                Console.WriteLine("Pilha Vazia");
            else
            {
                Console.WriteLine("maior elemento da Pilha:");
                NohPilha temp = topo;
                int aux1= temp.Data;
                while (temp != null)
                {
                    if (temp.Data < aux1)
                    {
                        aux1 = temp.Data;
                    }
                    temp = temp.Next;
                }
                Console.WriteLine(aux1);
            }
        }
    }
}
