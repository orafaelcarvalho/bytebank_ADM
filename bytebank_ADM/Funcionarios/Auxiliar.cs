using bytebank_ADM.Utilitario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario, IBonificavel
    {
        public Auxiliar(string nome, string cpf) : base(nome, cpf, 1500)
        {

        }
        public double GetBonificacao()
        {
            return this.Salario * 0.2;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.35;
        }
    }
}
