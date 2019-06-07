using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfEmpregados
{
    class EmpregadoCLT : Empregado
    {
        private double salario_mensal;

        public EmpregadoCLT() : base()
        {
            salario_mensal = 0.0;
        }

        public EmpregadoCLT(String _primeiroNome, String _segundoNome, String _cpf, double _salario_mensal) : base(_primeiroNome, _segundoNome, _cpf)
        {
            salario_mensal = _salario_mensal;
        }

        public double Salario_mensal { get => salario_mensal; set => salario_mensal = value; }

        public override double getSalLiquido()
        {
            double salarioLiquido;
            if (salario_mensal >= 4000.0)
                salarioLiquido = (0.725 * salario_mensal);
            else
                salarioLiquido = (0.85 * salario_mensal);

            return salarioLiquido;
        }
    }
}
