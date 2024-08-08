using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados_e_listas.Stacks
{
    internal class Pilha
    {
        public static void ExemploPilha()
        {
            // Obedece ao padrão LIFO (Last In - First Out)
            // Onde: O ultimo á entrar --> é o primeiro à sair

            // Declarando uma nova 'pilha'
            Stack<int> pilha = new Stack<int>();

            // Adicionando elementos na 'pilha'
            pilha.Push(4);
            pilha.Push(6);
            pilha.Push(8);
            pilha.Push(25);

            // Percorrendo os elementos da 'pilha'
            foreach (int item in pilha)
            {
                Console.WriteLine(item);
            }

            // Removendo um elemento da pilha
            // Pela LIFO, é possível remover somente o elemento no topo
            Console.WriteLine($"\nRemovendo o elemento do topo da pilha: {pilha.Pop()}");

            // Percorrendo os elementos da 'pilha'
            foreach (int item in pilha)
            {
                Console.WriteLine(item);
            }


        }
    }
}
