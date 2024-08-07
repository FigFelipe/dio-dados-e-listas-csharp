using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados_e_listas.PropiedadesMetodosConstrutores.Models
{
    internal class Curso
    {
        // Atributos
        public string Nome { get; set; }
        public List<Pessoa> listaAlunos { get; set; }

        // Metodos
        public void AdicionarAluno(Pessoa aluno)
        {
            listaAlunos.Add(aluno); // Adicionando à lista de objetos 'Alunos' um aluno
        }

        public int QuantidadeAlunos()
        {
            int quantidade = listaAlunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return listaAlunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");

            foreach (var aluno in listaAlunos)
            {
                Console.WriteLine($"{aluno.NomeCompleto}");
            }
        }
    }
}
