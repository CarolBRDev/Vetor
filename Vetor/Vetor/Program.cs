using System;
using System.Net;

namespace Vetor
{
    public class Program
    {
        static string[] nomes = new string[10];
        static int contador = 0;
        static int i = 0; //pra ficar acessivel a todos os metodos? - PosicaoVaga()

        static void Main(string[] args)
        {
            //Crie um programa que receba um vetor de 10 posições,
            //esse programa deve ter um metodo de adicionar novos nomes.
            //esse programa deve ter um metodo de adicionar nomes em indices especificos
            //Esse programa deve ter um metodo de ordenar os nomes em ordem alfabetica
            //esse programa deve ter um metodo para imprimir todos os nomes.

            //verificar se cabe mais um nome antes de adicionar

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

        static void IncluirNome(string nome, int contador)
        {
            //verificar se o array tem espaço
            //se tiver: adicionar o nome no index disponivel usando o contador
            //se não tiver: avisar que o array esta cheio 

            if (contador < nome.Length)
            {

                nomes[contador] = nome;
                contador++;
            }
            else
            {
                Console.WriteLine("O array está cheio. Sem espaço para acrescentar nomes.");
            }
        
        }   


        static void IncluirNomeIndex(string nome, int index)
        {
            //verificar se o array tem espaço
            //se tiver: verificar se a posição escolhioda esta vazia - se tiver: remanejar o nomes para espaço livre, depois adicionar o nome no index solicitado - perguntar em program o index? - 
            //se não tiver: avisar que o array esta cheio 

            if (contador < nome.Length) //se tiver espaço
            {           
                //verificar se a posição escolhida esta vazia
                if (nomes[index] != "") //se não estiver vazia
                {
                    //encontrar uma posição vazia



                    //remanejar nome na posição desejada para posição vazia


                    //adicionar novo nome na posição desejada    
                    nomes[index] = nome;
                    contador++;

                }
                else//se estiver vazia
                {
                    //adicionar novo nome na posição desejada    
                    nomes[index] = nome;
                    contador++;
                }

                    
               
            }
            else //se não tiver espaço
            {
                Console.WriteLine("O array está cheio. Sem espaço para acrescentar nomes.");
            }

        }

        static int PosicaoVazia()
        {
        for (i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == "")
            {
                return i;
            }
        }

        static void ReordenarNomes()
        {

        }
        static void ImprimirNomes()
        {
            for (int i = 0; i < contador; i++) // usar contador pq o comprimento do Vetor nao mudara, estando cheio ou nao
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
