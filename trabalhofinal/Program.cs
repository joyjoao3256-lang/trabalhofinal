
using TrabalhoFinal.Dominio;
using TrabalhoFinal.Servicos;
PessoaService.Listar();

Console.WriteLine("Digite o nome da pessoa que deseja cadsatrar?");
string nome = Console.ReadLine();
Console.WriteLine("Digite o nome da pessoa que deseja cadsatrar?");
string email = Console.ReadLine();
DateTime data_Nacimento = DateTime.Now;
PessoaService.Adicionar(nome, email, data_Nacimento);
PessoaService.Listar();