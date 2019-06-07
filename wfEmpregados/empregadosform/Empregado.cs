using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfEmpregados
{
    class Empregado
    {
        private String primeiroNome;
        private String segundoNome;
        private String cpf;

        protected string PrimeiroNome { get => primeiroNome; set => primeiroNome = value; }
        protected string SegundoNome { get => segundoNome; set => segundoNome = value; }
        protected string Cpf { get => cpf; set => cpf = value; }

        public Empregado()
        {
            primeiroNome = null;
            segundoNome = null;
            cpf = null;
        }

        public Empregado(String _primeiroNome, String _segundoNome, String _cpf)
        {
            primeiroNome = _primeiroNome;
            segundoNome = _segundoNome;
            cpf = _cpf;
        }

        public virtual double getSalLiquido()
        {
            double salarioLiquido = 0.0;
            return salarioLiquido;
        }
        public string getcpf() { return cpf; }
    }
}
