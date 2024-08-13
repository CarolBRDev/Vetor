using System;
using System.Net;

namespace Vetor
{
    public class Program
    {
        static string[] nomes = new string[10];
        static int contador = 0;


        static void Main(string[] args)
        {
            //Crie um programa que receba um vetor de 10 posições,
            //esse programa deve ter um metodo de adicionar novos nomes.
            //esse programa deve ter um metodo de adicionar nomes em indices especificos
            //Esse programa deve ter um metodo de ordenar os nomes em ordem alfabetica
            //esse programa deve ter um metodo para imprimir todos os nomes.
            //criar metodo para remover o registro e rearrumar o espaço (puxa os de tras do que foi removido para frente, a ultima que tem que ficar vaga)

            int opcao;

            do
            {
                Console.WriteLine("Digite a opção desejada:");
            Console.WriteLine("1 - Adicionar nome sequencialmente no array \n 2 - Adicionar nome em uma posição especifica do array. \n 3 - Ordenar nomes alfabeticamente no array \n 4 - Imprimir nomes existentes \n 5 - Remover registro \n 6 - Finalizar programa");

            opcao = int.Parse(Console.ReadLine());

            
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o nome: ");
                        string nome = Console.ReadLine();
                        IncluirNome(nome);
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("Digite o valor do index onde quer adicionar o nome: ");
                        int index = int.Parse(Console.ReadLine());
                        IncluirNomeIndex(nome, index);
                        break;
                    case 3:
                        ReordenarNomes();
                        break;
                    case 4:
                        ImprimirNomes();
                        break;
                    case 5:
                        Console.WriteLine("Digite o valor do index do nome que quer remover: ");
                        index = int.Parse(Console.ReadLine());
                        RemoverRegistro(index);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;

                }

            }
            while (opcao != 6);


        }

        static void IncluirNome(string nome)
        {
             

            if (contador < nomes.Length)
            {

                nomes[contador] = nome;
                contador++;
            }
            else
            {
                Console.WriteLine("O array está cheio. Sem espaço para acrescentar nomes.");
            }
        
        }   


        static void IncluirNomeIndex(string nome, int index)//reavaliar 
        {
            
            if (index >= 0 && index < nomes.Length)
            {
                if (contador < nome.Length)
                {
                    
                    if (nomes[index] != "")
                    {

                        int posicaoVaga;
                        
                        for (int i = 0; i < nomes.Length; i++)
                        {
                            if (nomes[i] == "")
                            {
                                posicaoVaga = i;
                                
                                string copiaNome = nomes[index];
                                nomes[posicaoVaga] = copiaNome;
                                contador++;
                                break; 
                            }

                        }

                           
                        nomes[index] = nome;
                        contador++;

                    }
                    else
                    {
                           
                        nomes[index] = nome;
                        contador++;
                    }

                }
                else 
                {
                    Console.WriteLine("O array está cheio. Sem espaço para acrescentar nomes.");
                }
            }
            else
            {
                Console.WriteLine("O numero digitado está fora do intervalo válido.");
            }
            

        }
       
        static void ReordenarNomes()//em andamento
        {
            for (int i = 0; i < nomes.Length; i++)
            {
               int comparacao = string.Compare(nomes[i], nomes[i+1]);

                if (comparacao >1) { //segundo nome é antes do primeiro na ordem alfabética

                    string provisoria = nomes[i];
                    nomes[i] = nomes[i + 1];
                    nomes[i + 1] = provisoria;
                }
            }
            
        }
        static void ImprimirNomes()//ok
        {
            for (int i = 0; i < nomes.Length; i++) 
            {
                Console.WriteLine(nomes[i]);
            }
        }

        static void RemoverRegistro(int index)//reavaliar
        {
            
            if (index >=0 && index <nomes.Length)
            {
                for (int i = index; i < nomes.Length -1; i++)
                {
                    nomes[i] = nomes[i + 1];
                    //precisa definir uma maneira de deixar o ultimo indice que estava ocupado, vazio. MAs nao vai ser sempre o ultimo do array...
                    contador--;
                   
                }
            }
            else
            {
                Console.WriteLine("O numero digitado está fora do intervalo válido.");
            }
        }
    }
}
