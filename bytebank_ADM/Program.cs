using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

#region

//Funcionario pedro = new Funcionario("123456789", 2000);

//pedro.Nome = "Pedro Carvalho";
//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("987654321");
//roberta.Nome = "Roberta Silva";
//roberta.GetBonificacao();

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);
//Console.WriteLine($"Total de bonificações: {gerenciador.TotalDeBonificacao}");
//Console.WriteLine($"Total de funcionários: {Funcionario.TotalDeFuncionarios}");

//pedro.AumentarSalario();
//roberta.AumentarSalario();
//Console.WriteLine($"NMovo salário Pedro: {pedro.Salario}");
//Console.WriteLine($"NMovo salário Roberta: {roberta.Salario}");

#endregion

CalcularBonificacao();
//UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Diretor rafael = new Diretor("Rafael Souza", "12345", "rafael", "tentaasorte");    
    GerenteDeContas pedro = new GerenteDeContas("Pedro Silva", "43211", "pedro", "vacilao");    
    Auxiliar roberto = new Auxiliar("Roberto Cardoso", "123478");    

    gerenciador.Registrar(rafael);
    gerenciador.Registrar(pedro);    

    Console.WriteLine($"Total de bonificação: {gerenciador.TotalDeBonificacao}");
}

void UsarSistema()
{
    Diretor rafael = new Diretor("Rafael", "12345", "rafael", "tentaasorte");    
    GerenteDeContas pedro = new GerenteDeContas("Pedro Silva", "43211", "pedro", "vacilao");
    Auxiliar roberto = new Auxiliar("Roberto", "123478");    
    ParceiroComercial joao = new ParceiroComercial("joao", "senha");

    SistemaInterno sistemainterno = new SistemaInterno();

    sistemainterno.Logar(rafael, "rafael", "tentaasorte");
    sistemainterno.Logar(pedro, "pedro", "vacilao");
    sistemainterno.Logar(joao, "joao", "senha");
}