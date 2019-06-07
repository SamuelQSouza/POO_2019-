using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfPilhaDinamica
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

        public string pop()
        {
            if (!isEmpty())
            {
                int temp = topo.Data;
                topo = topo.Next;
                return Convert.ToString(temp);
            }
            else
                return "pilha vazia";
        }
        public string print()
        {
            string text = "";
            if (!isEmpty())
            {
                NohPilha temp = topo;
                while (temp != null)
                {
                    text += (Convert.ToString(temp.Data) + " ");
                    temp = temp.Next;
                }
                return text;
            }
            else
                return "pilha vazia";
        }
        public Pilha inverte()
        {
            Pilha a = new Pilha();
            if (!isEmpty())
            {
                NohPilha temp = topo;
                while (temp != null)
                {
                    a.push(temp.Data);
                    temp = temp.Next;
                }
                a.print();
            }
            return a;
        }
        public string Maior()
        {
            if (!isEmpty())
            {
                NohPilha temp = topo;
                int aux1 = temp.Data;
                while (temp != null)
                {
                    if (temp.Data > aux1)
                        aux1 = temp.Data;
                    temp = temp.Next;
                }
            
                return Convert.ToString(aux1);
            }
            else
                return "pilha vazia";
        }
        public String Menor()
        { 
            if (!isEmpty())
            {
                NohPilha temp = topo;
                int aux1 = temp.Data;
                while (temp != null)
                {
                    if (temp.Data < aux1)
                        aux1 = temp.Data;
                    temp = temp.Next;
                }
                return Convert.ToString(aux1);
            }
            else
                return "pilha vazia";

        }
    }
}
