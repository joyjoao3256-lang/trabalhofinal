using TrabalhoFinal.Dominio;

namespace TrabalhoFinal.Servicos
{
    public static class TurmaService
    {
        public static List<turma> turmas { get; set; }
            = new List<turma>()
            {
                new turma(){ Id=1,Serie=1 ,NomeTurma="101", AnoLetivo=2026,Alunos = 35 },
                new turma(){ Id=2,Serie=1 ,NomeTurma="102", AnoLetivo=2026,Alunos = 36 },
                new turma(){ Id=3,Serie=1 ,NomeTurma="103", AnoLetivo=2026,Alunos = 34 },
                new turma(){ Id=4,Serie=1 ,NomeTurma="104", AnoLetivo=2026,Alunos = 32 },
                new turma(){ Id=5,Serie=1 ,NomeTurma="105", AnoLetivo=2026,Alunos = 20 },

            };


        public static void Remover(int id)
        {
            turma t = turmas.Find(turma => turma.Id == id);
            if (t != null)
            {
                turmas.Remove(t);
                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o usuario");
            }
        }
        public static void Editar(int id, int novaSerie, string novaNomeTurma,int novoAnoLetivo, int novoAlunos)
        {
            turma t = turmas.Find(turma => turma.Id == id);
            if (t != null)
            {
                t.Serie = novaSerie;
                t.NomeTurma = novaNomeTurma;
                t.AnoLetivo = novoAnoLetivo;
                t.Alunos = novoAlunos;
                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o usuario");
            }
        }
        public static void Adicionar(int Id, int Serie, string NomeTurma, int AnoLetivo, int Alunos )

        {
            turma turma = new turma();
            turma.Id = turmas.Count > 0 ?
                turmas.Count + 1 : 1;
            turma.Serie = Serie;
            turma.NomeTurma = NomeTurma;
            turma.AnoLetivo = AnoLetivo;
            turmas.Add(turma);
        }
        public static void Listar()
        {
            foreach (turma item in turmas)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.NomeTurma);
                Console.WriteLine("---------------------");
            }
        }

        public static void BuscarPorId(int id)
        {
            foreach (turma turmas in turmas)
            {
                if (turmas.Id == id)
                {
                    Console.WriteLine("ID: " + turmas.Id);
                    Console.WriteLine("Serie: " + turmas.Serie);
                    Console.WriteLine("Turma: " + turmas.NomeTurma);
                    Console.WriteLine("Ano: " + turmas.AnoLetivo);
                    Console.WriteLine("Alunos: " + turmas.Alunos);
                    return;
                }
            }

            Console.WriteLine("Pessoa não encontrada.");
        }
    }
    }
