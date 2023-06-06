using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    public class Estagiario : Funcionario
    {
        public Estagiario(double salario, string cpf) : base(salario, cpf)
        {
        }

        public override void AumentarSalario()
        {
            //qualquer código
        }

        protected internal override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}