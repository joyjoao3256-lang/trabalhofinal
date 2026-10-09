using System;
using System.Collections.Generic;
using System.Linq;
using trabalhofinal;

namespace trabalhofinal.Service
{
    public static class ProfessoresService
    {
        public static List<Professores> Professor { get; set; }
            = new List<Professores>()
            {
                new Professores() { Id = 1, Idade = 50, Nome = "Paulo", Materias = "historia", Email = "paulo@gmail.com" },
                new Professores() { Id = 2, Idade = 55, Nome = "Marta", Materias = "ingles", Email = "Marta@gmail.com" },
                new Professores() { Id = 3, Idade = 60, Nome = "Geraldo", Materias = "matematica", Email = "Geraldo@gmail.com" }
            };

        public static void Remover(int id)
        {
            Professores p = Professor.Find(pessoa => pessoa.Id == id);

            if (p != null)
            {
                Professor.Remove(p);
                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o professor.");
            }
        }

        public static void Editar(int id, int novoIdade, string novoNome,
            string novoMaterias, string novoEmail)
        {
            Professores p = Professor.Find(pessoa => pessoa.Id == id);

            if (p != null)
            {
                p.Idade = novoIdade;
                p.Nome = novoNome;
                p.Materias = novoMaterias;
                p.Email = novoEmail;

                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o professor.");
            }
        }

        public static void Adicionar(string nome, string email, DateTime data_nascimento)
        {
            int idade = DateTime.Today.Year - data_nascimento.Year;

            if (data_nascimento.Date > DateTime.Today.AddYears(-idade))
            {
                idade--;
            }

            Professores novoProfessor = new Professores();

            novoProfessor.Id = Professor.Count > 0
                ? Professor.Max(p => p.Id) + 1
                : 1;

            novoProfessor.Nome = nome;
            novoProfessor.Email = email;
            novoProfessor.Idade = idade;

            Professor.Add(novoProfessor);

            Listar();
        }

        public static void Listar()
        {
            foreach (Professores item in Professor)
            {
                Console.WriteLine("ID: " + item.Id);
                Console.WriteLine("Nome: " + item.Nome);
                Console.WriteLine("Idade: " + item.Idade);
                Console.WriteLine("Matéria: " + item.Materias);
                Console.WriteLine("Email: " + item.Email);
                Console.WriteLine("---------------------");
            }
        }

        public static void BuscarPorId(int id)
        {
            Professores p = Professor.Find(pessoa => pessoa.Id == id);

            if (p != null)
            {
                Console.WriteLine("ID: " + p.Id);
                Console.WriteLine("Nome: " + p.Nome);
                Console.WriteLine("Idade: " + p.Idade);
                Console.WriteLine("Matéria: " + p.Materias);
                Console.WriteLine("Email: " + p.Email);
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o professor.");
            }
        }
    }
}