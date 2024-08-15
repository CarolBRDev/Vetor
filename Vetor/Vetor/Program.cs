using System;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace Vetor
{
    public class Program
    {
        static string[] nomes = new string[10];
        static int contador = 0;


        static void Main(string[] args)
        {

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
                        IncluirNome(nome, nomes);
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("Digite o valor do index onde quer adicionar o nome: ");
                        int index = int.Parse(Console.ReadLine());
                        IncluirNomeIndex(nomes, nome, index);
                        break;
                    case 3:
                        ReordenarNomes(nomes);
                        break;
                    case 4:
                        ImprimirNomes(nomes);
                        break;
                    case 5:
                        Console.WriteLine("Digite o valor do index do nome que quer remover: ");
                        index = int.Parse(Console.ReadLine());
                        RemoverRegistro(nomes, index);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;

                }

            }
            while (opcao != 6);


        }
        public static bool VetorEstaCheio(string[] nomes)//testar
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                if (string.IsNullOrEmpty(nomes[i]))//se nessa posição tem espaço em branco ou é nulo
                {
                    return false;//a lista nao esta cheia
                }
            }
            return true;
        }

        public static bool EstaDentroDoIntervalo(int index)//testar
        {
            if (index >= 0 && index < nomes.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void IncluirNome(string nome, string[] nomes)//testar
        {           
            if (VetorEstaCheio(nomes))
            {
                Console.WriteLine("O array está cheio. Sem espaço para acrescentar nomes.");
            }
            else
            {
                for (int i = 0; i < nomes.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(nomes[i]))
                    {
                        nomes[i] = nome;
                        return;
                    }
                }
            }                       
                 
        }
        public static void IncluirNomeIndex(string[] nomes, string nome, int index)//testar
        {

            if (EstaDentroDoIntervalo(index))
            {
                if (VetorEstaCheio(nomes))
                {
                    Console.WriteLine("O array está cheio. Sem espaço para acrescentar nomes.");
                }
                else
                {
                    for (int i = 0; i < nomes.Length; i++)
                    {
                        if (string.IsNullOrWhiteSpace(nomes[i]))
                        {
                            nomes[i] = nomes[index];
                            nomes[index] = nome;
                            return;
                        }
                        else
                        {
                            nomes[index] = nome;
                            return;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("O valor digitado está fora do intervalo válido.");
            }


        }   
       
        public static void ReordenarNomes(string[] nomes)//refazer
        {
            for (int i = 0; i < nomes.Length; i++)
            {
               int comparacao = string.Compare(nomes[i], nomes[i+1]);

                if (comparacao >1) { //segundo nome é antes do primeiro na ordem alfabética

                    string provisoria = nomes[i];
                    nomes[i] = nomes[i + 1];
                    nomes[i + 1] = provisoria;
                    return;
                }
            }
            
        }
        public static void ImprimirNomes(string[] nomes)//testar
        {
            //uma maneira de verificar se o array é nulo/vazio
            //bool vetorNull = false;
            //for (int i = 0; i < nomes.Length; i++) {
            //    if (!string.IsNullOrEmpty(nomes[i]))//percorre o vetor vendo se as posicoes estao nulas ou vazias. Se alguma estiver preenchida, ja para o if e continua a logica, imprimindo os nomes em cada posição do array
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        vetorNull = true;
            //    }
                
            if (nomes.All(name => string.IsNullOrEmpty(name)))//se todos os item do vetor nomes estiverem vazios ou nulos - essa função retorna true ou false
            {
                Console.WriteLine("Array vazio");
            }
            else
            {
                for (int i = 0; i < nomes.Length; i++)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
            
            
        }

        public static void RemoverRegistro(string[] nomes, int index)//refazer
        {
            
            if (index >=0 && index <nomes.Length)
            {
                for (int i = index; i < nomes.Length -1; i++)
                {
                    nomes[i] = nomes[i + 1];
                    //precisa definir uma maneira de deixar o ultimo indice que estava ocupado, vazio. Mas nao vai ser sempre o ultimo do array...
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
