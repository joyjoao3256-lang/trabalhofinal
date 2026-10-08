using TrabalhoFinal.Dominio;

namespace TrabalhoFinal.Servicos
{
    public static class TurmaService
    {
        public static List<turma> turma { get; set; }
            = new List<turma>()
            {
                new turma(){ Id=1,Serie=1 ,NomeTurma="101", AnoLetivo=2026,Alunos = 35 }
                ,,
            };

        public static void Listar()
        {
            foreach (turma item in turma)
            {
                Console.WriteLine(item.Serie);
            }
        }


    }
}
