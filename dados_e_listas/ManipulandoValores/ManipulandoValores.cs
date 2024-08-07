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
    }
}
