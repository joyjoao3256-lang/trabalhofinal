using trabalhofinal.Dominio;

namespace trabalhofinal.Service;

public static class AlunosService
{
    public static List<Alunos> aluno { get; set; }
        = new List<Alunos>()
        {
                new Alunos(){ Id=1,Turma="Primeiro Ano",Nome="Robert", Idade=19, Matricula="Particular" },
                new Alunos(){ Id=2,Turma="Segundo Ano",Nome="Duda", Idade=17, Matricula="Publica" },
                 new Alunos(){ Id=3,Turma="Terceiro Ano",Nome="Augusto", Idade=18, Matricula="Publica" },


         };
    public static void Remover(int id)
    {
        Alunos A = aluno.Find(aluno => aluno.Id == 3);
        if (A != null)
        {
            aluno.Remove(A);
            Listar();
        }
        else
        {
            Console.WriteLine("Sistema não conseguiu encontrar o usuario");
        }
    }
    public static void Editar(int id, string novoTurma, string novoNome, int novoIdade, string novoMatricula)
    {
        Alunos A = aluno.Find(pessoa => pessoa.Id == id);
        if (A != null)
        {

            A.Turma = novoTurma;
            A.Nome = novoNome;
            A.Idade = novoIdade;
            A.Matricula = novoMatricula;
            Listar();
        }
        else
        {
            Console.WriteLine("Sistema não conseguiu encontrar o usuario");
        }
    }
    public static void Adicionar(string Nome
        , string turma, int Idade, string Matricula)
    {
        Alunos aluno = new Alunos();
        aluno.Nome = "Robertin";
        aluno.Turma = "Segundo ano";
        aluno.Matricula = "Particular";
        aluno.Idade = 18;
    }
    public static void Listar()
    {
        foreach (Alunos item in aluno)
        {
            Console.WriteLine(item.Id);
            Console.WriteLine(item.Nome);
            Console.WriteLine("---------------------");
        }
    }
    public static void BuscarPorId(int id)
    {
        Alunos A = aluno.Find(aluno => aluno.Id == id);
        if (A != null)
        {
            aluno.Remove(A);
            Listar();
        }
        else
        {
            Console.WriteLine("Sistema não conseguiu encontrar o usuario");
        }
    }
    // Passo um Id por parametro e o metodo
    // lista as informações detalhadas da pessoa
}

