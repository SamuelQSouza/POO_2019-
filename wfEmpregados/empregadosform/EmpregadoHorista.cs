using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfEmpregados
{
    class EmpregadoHorista : Empregado
    {
        private double nro_horas;
        private double qte_horas;

        public EmpregadoHorista() : base()
        {
            nro_horas = 0.0;
            qte_horas = 0.0;
        }

        public EmpregadoHorista(String _primeiroNome, String _segundoNome, String _cpf, double _nro_horas, double _qte_horas) : base(_primeiroNome, _segundoNome, _cpf)
        {
            nro_horas = _nro_horas;
            qte_horas = _qte_horas;
        }

        public double Nro_horas { get => nro_horas; set => nro_horas = value; }
        public double Qte_horas { get => qte_horas; set => qte_horas = value; }

        public override double getSalLiquido()
        {
            double salarioLiquido = 0.0;
            salarioLiquido = (nro_horas * qte_horas);
            return salarioLiquido - (salarioLiquido * 0.15);
        }
    }
}
