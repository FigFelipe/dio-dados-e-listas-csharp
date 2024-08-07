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
            Pessoa p1 = new Pessoa();

            p1.Nome = "Felipe";
            p1.Sobrenome = "Bezerra";
            p1.Idade = 0;

            p1.Apresentar();
            
        }

        
    }
}
