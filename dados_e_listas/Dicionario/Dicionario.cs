using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados_e_listas.Dicionario
{
    internal class Dicionario
    {
        public static void ExemploDicionario()
        {
            // O 'dicionario' é um tipo {chave:valor}

            // Instanciando um novo 'dicionario'
            // Nesse exemplo, a 'chave' é do tipo 'string'
            // e o 'valor' é do tipo 'string'

            // Obs.: Os elemento da {chave} devem ser exclusivos (único, sem repetição)
            // A chave não pode ser duplicada

            // Instanciando um novo 'dicionario' vazio
            Dictionary<string, string> estados = new Dictionary<string, string>();

            // Adicionando um elemento no 'dicionario'
            estados.Add("CE", "Ceará");
            estados.Add("SP", "São Paulo");
            estados.Add("BA", "Bahia");
            estados.Add("RS", "Rio Grande do Sul");

            // Percorrendo os elementos do 'dicionario'
            foreach(KeyValuePair<string, string> kvp in estados)
            {
                Console.WriteLine(kvp);
            }

            // Verificando o dicionario antes de inserir um novo elemento
            // Se nao existir o elemento no dicionario...

            string chave = "BA";

            if(!estados.ContainsKey(chave))
            {
                // ... adicione o estado
                estados.Add(chave, "Bahia");
            }
            else
            {
                Console.WriteLine($"Não foi possível adicionar o elemento '{chave}', pois o mesmo já existe.");
            }

            // Não é possivel adicionar um elemento já existente
            //estados.Add("BA", "Bahia");

            // Removendo elementos do 'dicionario'
            // Basta informar somente a chave
            Console.WriteLine($"\nRemovendo o estado 'RS': {estados.Remove("RS")}");

            // Percorrendo os elementos do 'dicionario' utilizando o 'var'
            foreach(var item in estados)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
