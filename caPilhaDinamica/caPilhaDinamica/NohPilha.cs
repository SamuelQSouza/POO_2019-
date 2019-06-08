using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDinamica
{
    class NohPilha
    {
        //Atributos
        private int data;
        private NohPilha next; //auto referenciamento

        //Metodos
        public NohPilha() //construtor default
        {
            next = null;
        }

        public NohPilha(int n)
        {
            data = n;
            next = null;
        }

        public NohPilha(int n, NohPilha nextNoh)
        {
            data = n;
            next = nextNoh;
        }

        public int Data { get => data; set => data = value; }
        internal NohPilha Next { get => next; set => next = value; }
    }
}
