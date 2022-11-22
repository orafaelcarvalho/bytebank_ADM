using bytebank_ADM.Utilitario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            this.Nome = nome;
            TotalDeFuncionarios++;
            //Console.WriteLine("Criando funcionário");
        }
        public abstract void AumentarSalario();
    }
}