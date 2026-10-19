using System;
using System.Collections.Generic;

namespace trabalhofinal.Service
{
    public static class DisciplinaService
    {
        public static List<Disciplina> disciplinas { get; set; }
            = new List<Disciplina>()
            {
                new Disciplina("Matemática", "1", 80, "Carlos"),
                new Disciplina("Português",  "2", 80, "Ana"),
                new Disciplina("História",   "3", 40, "Marcos"),
                new Disciplina("Geografia",  "4", 40, "Juliana"),
                new Disciplina("Física",     "5", 60, "Roberto"),
            };

        public static void Remover(string id)
        {
            Disciplina d = disciplinas.Find(disciplina => disciplina.id == id);
            if (d != null)
            {
                disciplinas.Remove(d);
                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar a disciplina");
            }
        }

        public static void Editar(string id, string novoNome, int novaCargaHoraria, string novoProfessor)
        {
            Disciplina d = disciplinas.Find(disciplina => disciplina.id == id);
            if (d != null)
            {
                d.nome = novoNome;
                d.cargaHoraria = novaCargaHoraria;
                d.professor = novoProfessor;
                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar a disciplina");
            }
        }

        public static void Adicionar(string nome, int cargaHoraria, string professor)
        {
            string novoId = (disciplinas.Count + 1).ToString();
            Disciplina disciplina = new Disciplina(nome, novoId, cargaHoraria, professor);
            disciplinas.Add(disciplina);
        }

        public static void Listar()
        {
            foreach (Disciplina item in disciplinas)
            {
                Console.WriteLine(item.id);
                Console.WriteLine(item.nome);
                Console.WriteLine("---------------------");
            }
        }

        public static void BuscarPorId(string id)
        {
            foreach (Disciplina disciplina in disciplinas)
            {
                if (disciplina.id == id)
                {
                    disciplina.ExibirDados();
                    return;
                }
            }

            Console.WriteLine("Disciplina não encontrada.");
        }
    }
}
