using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoFinal.Views
{
    public class MenuView
    {
        public static void IniciarSistema()
        {
            Console.WriteLine("Bem vindo a Beleza Certa");
            Console.WriteLine("Você deseja mexer em qual Menu");
            Console.WriteLine("1 - Pessoa");
            Console.WriteLine("2 - Estabelecimento");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                PessoaMenu();
            }
            else if (opcao == 2) ;
        }
        public static void PessoaMenu()
        {
            Console.WriteLine("Você deseja fazer qual operação");
            Console.WriteLine("1 - Listar");
            Console.WriteLine("2 - Excluir");
            Console.WriteLine("3 - Editar");
            Console.WriteLine("4 - Adicionar");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                
                IniciarSistema();
            }
        }
    }
}