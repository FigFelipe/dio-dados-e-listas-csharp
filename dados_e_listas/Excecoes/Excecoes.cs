using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados_e_listas.Exceptions
{
    internal class Excecoes
    {
        public static void ExemploExcecoes()
        {
            try
            {
                // Caminho completo do arquivo no projeto
                string filePath = "C:\\Users\\Felipe\\Documents\\Dev\\DIO\\dio-dados-e-listas-csharp\\dados_e_listas\\Excecoes\\Arquivos\\ArquivoTexto.txt";

                // Cada linha do arquivo pode ser retornada em um array de string
                string[] linhas = File.ReadAllLines(filePath);

                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }

            // NET 8.0 --> não é possível utilizar um catch genérico e outros específicos em conjunto
            // OU utiliza-se somente o catch genérico
            // OU utiliza-se vários catch em específico

            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Ocorreu uma exceção genérica: {ex.Message}");
            //}
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Diretório não encontrado. {ex.Message}");
            }
            finally // Executado independente de ter exceção ou não
            {
                Console.WriteLine("Chegou até aqui");
            }

        }

    }
}
