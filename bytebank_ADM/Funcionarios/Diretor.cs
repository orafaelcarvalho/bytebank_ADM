using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel, IAutenticavel
    {
        public Diretor(string cpf, string login, string senha) : base(cpf, 5000, login, senha)
        {
        }
        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }        
        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }
    }
}