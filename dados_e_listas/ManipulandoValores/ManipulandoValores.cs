using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;


namespace dados_e_listas.ManipulandoValores
{
    internal class ManipulandoValores
    {


        public static void Exemplo()
        {
            // Concatenação de string
            string a = "Olá";
            string b = " Mundo";
            string c;

            c = a + b;

            Console.WriteLine("Mensagem concatenada: " + c);


            // Interpolação
            // 1. É utilizado a cifra '$' no início do parametro à ser impresso

            Console.WriteLine($"Mensagem interpolada: {c}");
            
        }

        public static void ExemploValoresMonetarios()
        {
            // Definindo a cultura para a região 'en-US'
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

            decimal valorMonetario = 1502.40m;
          
            // Exibir o valor monetario na moeda de cultura local
            // :C => Currency (moeda)
            // Saída: R$ 82,40
            Console.WriteLine($"Valor monetário: {valorMonetario:N2}");

            // Porcetagem
            // .ToString("P") => adiciona automaticamente o sinal '%'
            double porcentagem = .3421;
            Console.WriteLine($"Porcentagem: {porcentagem.ToString("P")}");

            // Sinal customizado
            int numero = 123456;
            Console.WriteLine($"{numero.ToString("##-##-##")}");

            int cep = 12345678;
            Console.WriteLine($"{cep.ToString("#####-###")}");
        }

        public static void ExemploDateTime()
        {
            // DateTime é um tipo 'struct'

            // Representa a data no fuso horario local
            DateTime data = DateTime.Now;

            // Formato padrão
            Console.WriteLine($"Formato padrão: {data}");

            // Formato customizado
            // .ToString()
            // MM --> mes
            // mm --> minuto
            // HH --> formato 24h
            // hh --> formato 12h
            Console.WriteLine($"Formato customizado: {data.ToString("dd/MM/yyyy HH:mm")}");

            // Exibindo somente a data
            // .ToShortDateString()
            Console.WriteLine($"Somente a data: {data.ToShortDateString()}");

            // Exibindo somente a hora
            // .ToShortTimeString()
            Console.WriteLine($"Semente a hora: {data.ToShortTimeString()}");

            // Converter um 'string' para o formato 'DateTime'
            DateTime dataConvertida = DateTime.Parse("01/02/2003 01:02:03");
            Console.WriteLine($"Data convertida do string: {dataConvertida}");

            // Conversão 'string' para 'DateTime com 'TryParse'
            string dataString = "2022-04-17 18:00";

            bool isConvertido = false;

            isConvertido = DateTime.TryParseExact(dataString,
                                     "yyyy-MM-dd HH:mm",
                                      CultureInfo.InvariantCulture, // Independente de cultura, nao tem cultura definida
                                      DateTimeStyles.None,
                                      out data);

            if(isConvertido)
            {
                // Conversão válida
                Console.WriteLine($"TryParseExact: '{data}', é uma data válida.");
            }
            else
            {
                // Conversão inválida --> "01/01/0001 00:00:00"
                Console.WriteLine($"TryParseExact: '{data}', não é uma válida.");

            }

        }
    }
}
