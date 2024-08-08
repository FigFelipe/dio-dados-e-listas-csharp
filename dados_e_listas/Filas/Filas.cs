using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados_e_listas.Colecoes
{
    internal class Filas
    {
        public static void ExemploFila()
        {
            // Instanciando uma nova 'queue' do tipo 'int' com o nome de 'fila'
            Queue<int> fila = new Queue<int>();

            // Adicionando elementos na fila
            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(4);
            fila.Enqueue(8);

            // Percorrendo a fila
            foreach(var item in fila)
            {
                Console.WriteLine(item);
            }

            // Remover o PRIMEIRO elemento da fila
            // .Dequeue()
            // Pois é respeitada a regra FIFO (First In - First Out)
            Console.WriteLine($"\nRemovendo o primeiro elemento da fila: {fila.Dequeue()}");

            // Adicionando elementos na fila
            // Pela FIFO, o elemento é posicionado automaticamente no final da fila
            fila.Enqueue(25);

            // Percorrendo a fila novamente
            foreach (var item in fila)
            {
                Console.WriteLine(item);
            }
        }
    }
}
