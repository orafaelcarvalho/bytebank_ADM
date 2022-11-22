using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel, IBonificavel
    {
        public GerenteDeContas(string nome, string cpf, string login, string senha) : base(nome, cpf, 5000, login, senha)
        {
        }
        public double GetBonificacao()
        {
            return this.Salario * 1.1;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}