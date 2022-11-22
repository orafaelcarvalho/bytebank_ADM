using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Parceria
{
    public class ParceiroComercial
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public ParceiroComercial(string login, string senha)
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
