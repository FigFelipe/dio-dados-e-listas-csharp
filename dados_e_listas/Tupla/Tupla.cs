using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados_e_listas.Tuplas
{
    internal class Tupla
    {
        public static void ExemploTupla()
        {
            // Tupla: fornece uma sintaxe concisa para agrupar
            // vários elementos de dados em uma estrutura de dados leve.

            // Exemplo de uso: Representar um dado que possui vários tipos de retorno

            // Declarando uma tupla (RECOMENDADO - legibilidade)
            (int, string, string, decimal) tupla = (1, "Fig", "Felipe", 1.81m);

            // Exibindo o conteúdo completo da tupla
            Console.WriteLine($"Conteúdo tupla: {tupla}");

            // Exibindo cada item da tupla, especificada por item
            Console.WriteLine($"Id: {tupla.Item1}");
            Console.WriteLine($"Nome: {tupla.Item2}");
            Console.WriteLine($"Sobrenome: {tupla.Item3}");
            Console.WriteLine($"Altura: {tupla.Item4}");


            // Outra forma de declarar uma tupla (NÃO RECOMENDADO - legibilidade)
            ValueTuple<int, string, string, decimal> outraTupla = (2, "Maria", "M", 1.6m);

            // Outra forma (NÃO RECOMENDADO - legibilidade)
            var outraTuplaCreate = Tuple.Create(3, "Jose", "J", 1.8m);

            // --------------------------------------------------------------------- //

            // Acessando o método tupla, que retorna uma tupla com 3 valores
            string caminhoArquivo = "C:\\Users\\Felipe\\Documents\\Dev\\DIO\\dio-dados-e-listas-csharp\\dados_e_listas\\Tupla\\Arquivos\\ArquivoTexto.txt";

            // Criado uma tupla com o nome de 'retorno', que armazena a tupla de retorno do método 'LerArquivo'
            (bool, string[], int) retorno = LerArquivo(caminhoArquivo);

            // Exibe a informação da tupla de retorno do método
            Console.WriteLine("\n  --- Tupla Retorno ---");
            Console.WriteLine($"Tupla (raw): {LerArquivo(caminhoArquivo)}");


            Console.WriteLine("\n  --- Conteúdo do Arquivo ---");
            // Se o primeiro parametro da tupla for 'true' (bool sucesso)
            if (retorno.Item1)
            {
                // Leia o arquivo, de conteúdo existente no item 2 (string[]) 
                foreach(string linha in retorno.Item2)
                {
                    Console.WriteLine($"[Tupla.Item2]: {linha}");
                }

                // Retorna a qtd de linhas da tupla, item 3 (int qtdLinhas)
                Console.WriteLine($"[Tupla.Item3] Qtd linhas do arquivo: {retorno.Item3}");
            }
            else
            {
                Console.WriteLine("Não foi possível ler o arquivo.");
            }

        }

        // Exemplo de uso da tupla, qual faz o método ter mais de um retorno
        // Metodo do tipo tupla, nome 'LerArquivo'
        public static (bool sucesso, string[] linhas, int qtdLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch(Exception)
            {
                return (false, new string[0], 0);
            }
        }

        public static void ExemploTernario()
        {
            int numero = 20;
            bool isPar = false;

            // IF Ternario (recomendado somente para retornar 2 resultados)
            isPar = numero % 2 == 0;

            Console.WriteLine($"Ternário --> O número {numero} é '{(isPar? "par" : "ímpar")}'");

            // IF comum
            if(numero % 2 == 0)
            {
                Console.WriteLine($"Comum --> O número '{numero}' é par.");
            }
            else
            {
                Console.WriteLine($"O número '{numero}' é ímpar.");
            }
        }
    }
}
