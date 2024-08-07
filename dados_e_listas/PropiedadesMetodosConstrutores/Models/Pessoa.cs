using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados_e_listas.PropiedadesMetodosConstrutores.Models
{
    internal class Pessoa
    {
        // Atributos
        private string _nome; // 'Private' é acessivel somente pela própria classe
        private int _idade;
        public string Sobrenome { get; set; }
        public string NomeCompleto { get => $"{Nome} {Sobrenome}".ToUpper(); }

        public string Nome 
        {
            // Obtem valor
            get => _nome.ToUpper();

            set // Define valor
            {
                if(value == "") // 'value' é o argumento que recebe o 'Nome'
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;

            } 
        }

        
        public int Idade 
        {
            get => _idade; 
            
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _idade = value;
            }
        }

        // Construtores
        // 1. Todo construtor deve ter o mesmo nome que a sua 'Classe'
        // 2. Não possui um tipo de retorno
        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // Métodos
        public void Apresentar()
        {
            Console.WriteLine($"Nome (get automatico): {Nome} {Sobrenome}, idade (get automatico): {Idade} ano(s).");

            Console.WriteLine($"Nome completo (get): {NomeCompleto}");
        }

    }
}
