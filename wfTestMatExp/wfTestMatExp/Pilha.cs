using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfTestMatExp
{
    class Pilha
    {
        //Atributos
        private NohPilha topo;

        //Metodos
        public Pilha()
        {
             topo = null;
        }
        public NohPilha Topo { get => topo; }

        public bool isEmpty
        {
            get
            {
                if (topo == null)
                    return true;
                else
                    return false;
            }
        }

        public void push(char n)
        {
            NohPilha novo = new NohPilha(n);
            novo.Next = topo;
            topo = novo;
        }

        public void pop()
        {
                topo = topo.Next;                        
        }       
    }
}
