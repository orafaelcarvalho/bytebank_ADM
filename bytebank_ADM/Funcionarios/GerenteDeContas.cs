using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : Autenticavel
    {
        public GerenteDeContas(string cpf, string login, string senha) : base(cpf, 5000, login, senha)
        {

        }
        public override double GetBonificacao()
        {
            return this.Salario * 1.1;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public override bool Autenticar(string login, string senha)
        {
            return (this.Login == login && this.Senha == senha);
        }
    }
}