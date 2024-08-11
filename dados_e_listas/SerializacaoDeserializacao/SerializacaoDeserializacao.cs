using dados_e_listas.SerializacaoDeserializacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace dados_e_listas.SerializacaoDeserializacao
{
    internal class SerializacaoDeserializacao
    {
        // Transforma o objeto em um fluxo de bytes para seu armazenamento ou transmissão

        // JSON - JavaScript Notation Object
        // É um formato texto que segue a sintaxe do JavaScript,
        // amplamente utilizado para transmitir dados entre aplicações

        // Exemplo:
        // .NET --> JSON <-- Java
        //
        //{
        //    "Id":1,
        //    "Produto":"P1",
        //    "Preco":10.50
        //}

        public static void ExemploSerializacao()
        {
            Venda v1 = new Venda(1, "Material de escritório", 25.00m);
            Venda v2 = new Venda(2, "Licença de software", 110.00m);

            List<Venda> listaVendas = new List<Venda>();

            listaVendas.Add(v1);
            listaVendas.Add(v2);

            // Serializar o objeto 'v1' do tipo Venda
            string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

            // Visualizar o objeto serializado (JSON) 
            Console.WriteLine(serializado);

            // Escrever o conteudo .JSON para arquivo
            // --> Note que o nome do arquivo está no final do caminho informado
            // --> vendas.json

            //string folderArquivo = "C:\\Users\\Felipe\\Documents\\Dev\\DIO\\dio-dados-e-listas-csharp\\dados_e_listas\\SerializacaoDeserializacao\\Arquivos\\vendas.json";

            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            //Console.WriteLine(workingDirectory);
            //Console.WriteLine(projectDirectory);

            string pastaArquivo = projectDirectory + "\\SerializacaoDeserializacao\\Arquivos\\vendas.json";

            //Console.WriteLine(pastaArquivo);

            File.WriteAllText(pastaArquivo, serializado); // Escreve o conteúdo .json para o arquivo 'vendas.json'
        }
    }
}
