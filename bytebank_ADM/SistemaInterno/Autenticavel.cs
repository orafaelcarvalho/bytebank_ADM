using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public abstract class Autenticavel : Funcionario
    {
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public abstract bool Autenticar(string login, string senha);
        public Autenticavel(string cpf, double salario, string login, string senha) : base(cpf, salario)
        {
            this.Login = login;
            this.Senha = senha;
        }
    }
}
