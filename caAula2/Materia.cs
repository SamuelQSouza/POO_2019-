using System;

namespace caAula2
{
    public class Materia
    {
        private String nome;
        private String codigo;

        public Materia()
        {
            nome = null;
            codigo = null;
        }

        public Materia(String _nome, String _codigo)
        {
            nome = _nome;
            codigo = _codigo;
        }

        public String getNome()
        {
            return nome;
        }

        public void setNome(String _nome)
        {
            nome = _nome;
        }

        public String getCodigo()
        {
            return codigo;
        }

        public void setCodigo(String _codigo)
        {
            codigo = _codigo;
        }


    }
}