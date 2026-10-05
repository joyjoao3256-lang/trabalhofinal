using System;


namespace trabalhofinal
{
    using System;
    
        public class Disciplina
        {
            
            public string nome;
            public string id;
            public int cargaHoraria;
            public string professor;

           
            public Disciplina(string nome, string id, int cargaHoraria, string professor)
            {
                this.nome = nome;
                this.id = id;
                this.cargaHoraria = cargaHoraria;
                this.professor = professor;
            }

            
            public void ExibirDados()
            {
                Console.WriteLine($"id do professor: {id}");
                Console.WriteLine($"Disciplina: {nome}");
                Console.WriteLine($"Carga Horária: {cargaHoraria}h");
                Console.WriteLine($"Professor(a): {professor}");
                Console.WriteLine("-------------------------");
            }
        }
    }

