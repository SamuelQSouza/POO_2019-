using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_POO
{
    class Materia
    {
        // Atributos
        private String nome;
        private String codigo;

        // Métodos
        public Materia()
        {
            nome = " ";
            codigo = " ";
        }

        public Materia(String _nome, String _codigo)
        {
            nome = _nome;
            codigo = _codigo;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }
}
