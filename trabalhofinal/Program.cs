// See https://aka.ms/new-console-template for more information
using trabalhofinal.Dominio;
using trabalhofinal.Service;

AlunosService.Listar();
Console.WriteLine("Digite o Id do usuario que deseja excluir");
int id = int.Parse(Console.ReadLine());
AlunosService.Remover(id);
