using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfTestMatExp
{
    class NohPilha
    {
        //Atributos
        private char data;
        private NohPilha next; //auto referenciamento

        //Metodos
        public NohPilha() //construtor default
        {
            next = null;
        }

        public NohPilha(char n)
        {
            data = n;
            next = null;
        }

        public NohPilha(char n, NohPilha nextNoh)
        {
            data = n;
            next = nextNoh;
        }

        public char Data { get => data; set => data = value; }
        internal NohPilha Next { get => next; set => next = value; }
    }
}
