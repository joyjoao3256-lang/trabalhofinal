using System;
using trabalhofinal;
using TrabalhoFinal.Servicos;

ProfessoresService.Listar();

Console.WriteLine("Digite o nome do professor que deseja cadastrar:");
string nome = Console.ReadLine() ?? "";

Console.WriteLine("Digite o email do professor:");
string email = Console.ReadLine() ?? "";

Console.WriteLine("Digite a data de nascimento (dd/MM/yyyy):");
string entradaData = Console.ReadLine() ?? "";

if (DateTime.TryParseExact(
    entradaData,
    "dd/MM/yyyy",
    System.Globalization.CultureInfo.GetCultureInfo("pt-BR"),
    System.Globalization.DateTimeStyles.None,
    out DateTime dataNascimento)
    && dataNascimento <= DateTime.Today)
{
    ProfessoresService.Adicionar(nome, email, dataNascimento);

    Console.WriteLine("Professor cadastrado com sucesso!");
}
else
{
    Console.WriteLine("Data inválida. Digite uma data válida no formato dd/MM/yyyy.");
}

Console.WriteLine("\nLista atualizada de professores:");
ProfessoresService.Listar();

Console.WriteLine("\nPressione qualquer tecla para sair.");
Console.ReadKey();
