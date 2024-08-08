using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados_e_listas.SerializacaoDeserializacao.Models
{
    internal class Venda
    {
        // Atributos
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }

        // Construtores
        public Venda(int id, string produto, decimal preco)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
        }


    }
}
