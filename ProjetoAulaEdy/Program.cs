using ProjetoAulaEdy.Classes;
using System;
using System.Collections.Generic;

namespace ProjetoAulaEdy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool rodando = true;
            int menu = 0;
            while (rodando)
            {

            menu = getMenu();

            Console.Clear();

            if (menu == 1)
            {

                Usuario user = new Usuario();

                Console.WriteLine("Digite o seu nome:");
                user.Nome = Console.ReadLine();

                Console.WriteLine($" Seu nome é : {user.Nome}");

                Console.WriteLine("Digite o seu cpf:");
                user.Cpf = Console.ReadLine();

                Console.WriteLine($" Seu Cpf é : {user.Cpf}");

                Console.WriteLine("Digite seu email: ");
                user.Email = Console.ReadLine().Trim();

                Console.WriteLine($"seu email é: {user.Email}");


                }
                else
                {
                    rodando = false;
                }
            }


        }

        private static int getMenu()
        {
            int menu = 0;
            bool MenuValido = false;
            while (!MenuValido)
            {

                Console.WriteLine("Digite 1 Para Cadastrar Usuario ou 2 Para Cancelar Operacao: ");

                string? menutemporario = Console.ReadLine().Trim();
                if (!string.IsNullOrEmpty(menutemporario))
                {

                    switch (menutemporario)
                    {
                        case "1":
                            menu = Convert.ToInt32(menutemporario);
                            MenuValido = true;

                            break;

                        case "2":
                            menu = Convert.ToInt32(menutemporario);
                            MenuValido = true;
                            break;
                    }


                }
                Console.Clear();

            }

            return menu;
        }
    }




}
