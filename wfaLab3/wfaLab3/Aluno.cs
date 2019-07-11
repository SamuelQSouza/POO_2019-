using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_POO
{
    class Aluno
    {
        // atributos
        private String nome;
        private String numero_matricula;
        private int periodo;
        private Materia[] lista_materias; // array usado para associar um aluno com suas materias
        private int i;    // indice do array de lista_materias 

        internal Materia[] Lista_materias { get => lista_materias; set => lista_materias = value; }

        // métodos
        public Aluno() // construtor default
        {
            nome = " ";
            numero_matricula = " ";
            periodo = 0;
            lista_materias = new Materia[8];
            i = 0;
        }

        public Aluno(String _nome, String _numero_matricula, int _periodo) // construtor aridade 3
        {
            nome = _nome;
            numero_matricula = _numero_matricula;
            periodo = _periodo;
            lista_materias = new Materia[8];
            i = 0;
        }

        public String getNome()
        {
            return nome;
        }

        public void setNome(String _nome)
        {
            nome = _nome;
        }

        public void associaMateria(Materia m)
        {
            if (i <= 7)
            {
                lista_materias[i] = m;
                i++;
            }
            else
                Console.WriteLine("O Número máximo de matérias permitias foi alcançado");
        }

        public void imprimeRelatorio()
        {
            for (int i = 0; i < lista_materias.Length; i++)
            {
                Console.WriteLine("Materia " + (i + 1) + ": " + lista_materias[i].Nome);
            }
        }
    }
}
