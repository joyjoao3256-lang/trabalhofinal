using TrabalhoFinal.Dominio;
using TrabalhoFinal.Servicos;
internal class Program
{
    private static void Main(string[] args)
    {
        TurmaService.Listar();

        //Console.WriteLine("Digite o nome do aluno");
        //string nome = Console.ReadLine();
        //Console.WriteLine("Digite o nome da sala do aluno");
        //int sala = Console.ReadLine();
        //DateTime AnoLetivo = DateTime.Now;
        //TurmaService.Adicionar(nome, sala, AnoLetivo);
        TurmaService.Listar();
        Console.WriteLine("Digite o Id do usuario que deseja excluir");
        int id = int.Parse(Console.ReadLine());
        TurmaService.Remover(id);
        TurmaService.Editar(4, 2, "201", 2027, 40);
    }
}