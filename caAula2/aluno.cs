using System;

namespace caAula2
{
    public class Aluno
    {
        private String nome;
        private String numero_matricula;
        private int periodo;
        private Materia[] lista_materias; //array usado para associar um aluno com suas materias    
        private int i; //indice array de lista_materias

        //metodos
        //construto default
        public Aluno()//Construtor default
        {
            nome = null;
            numero_matricula = null;
            periodo = 0;
            lista_materias = new Materia[8];
            i = 0;
        }

        public Aluno(String _nome, String _numero_matricula,int _periodo)
        {
            nome = _nome;
            numero_matricula = _numero_matricula;
            periodo = _periodo;
            lista_materias = new Materia[8];
            i = 0;
        }

        public void associaMateria(Materia m)
        {
            if ( i <= 7)
            {
                lista_materias[i] = m;
                i++;
            }
            else
                Console.WriteLine("O numero máximo de matérias permitidas foi alcançada");
        }

        public void imprimeRelatorio()
        {
            for (int i =0; i < lista_materias.Length; i++)
                Console.WriteLine("Materia " + (i + 1) + ": " + lista_materias[i].getNome());
        }

        public String getNome()
        {
            return nome;
        }

        public void setNome(String _nome)
        {
            nome =_nome;
        }

        public String getMatrícula()
        {
            return numero_matricula;
        }

        public void setMatricula(String _numero_matricula)
        {
            numero_matricula = _numero_matricula;
        }

        public int getPeriodo()
        {
            return periodo;
        }

        public void setPeriodo(int _periodo)
        {
            periodo = _periodo;
        }
    }
}