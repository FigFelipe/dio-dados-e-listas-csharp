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
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

            decimal valorMonetario = 1502.40m;
          
            // Exibir o valor monetario na moeda de cultura local
            // :C => Currency (moeda)
            // Saída: R$ 82,40
            Console.WriteLine($"{valorMonetario:C}");



        }
    }
}
