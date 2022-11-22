using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        protected FuncionarioAutenticavel(string nome, string cpf, double salario, string login, string senha) : base(nome, cpf, salario)
        {
            this.Login = login;
            this.Senha = senha;
        }        

        public bool Autenticar(string login, string senha)
        {
            return (this.Login == login && this.Senha == senha);
        }
    }
}
