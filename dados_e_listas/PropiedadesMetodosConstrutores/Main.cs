using dados_e_listas.PropiedadesMetodosConstrutores.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados_e_listas.PropiedadesMetodosConstrutores
{
    internal class Main
    {
        public static void ExemploPessoa()
        {
            Pessoa pessoa = new Pessoa(nome: "Felipe", sobrenome: "Figueiredo Bezerra");
                        
            // Instanciando um novo objeto Curso
            Curso curso = new Curso();
            curso.Nome = "Inglês";

            // Instanciando uma nova lista vazia do tipo 'Pessoa'
            curso.listaAlunos = new List<Pessoa>();

            // Adicionando 'aluno' ao 'cursoIngles'
            curso.AdicionarAluno(pessoa);

            // Exibir a quantidade de Alunos no Curso
            Console.WriteLine($"Qtd alunos no curso: {curso.QuantidadeAlunos().ToString()}");

            // Listar os Alunos do Curso
            curso.ListarAlunos();
        }
        
    }
}
