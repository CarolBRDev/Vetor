using System;

namespace Vetor
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que receba um vetor de 10 posições,
            //esse programa deve ter um metodo de adicionar novos nomes.
            //esse programa deve ter um metodo de adicionar nomes em indices especificos
            //Esse programa deve ter um metodo de ordenar os nomes em ordem alfabetica
            //esse programa deve ter um metodo para imprimir todos os nomes.

            string[] nomes = new string[10];

            Console.WriteLine("Digite a opção desejada:");
            Console.WriteLine("1 - Adicionar nome sequencialmente no array \b 2 - Adicionar nome em uma posição especifica do array. \b 3 - Ordenar nomes alfabeticamente no array \b 4 - Imprimir nomes existentes");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;




                


            }

            
        }

        static void IncluirNome()
        {

        }
        static void ImprimirNomes()
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
