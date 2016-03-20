using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitoCSharp.Project.Console
{
    class Program
    {
        //INICIALIZADOR DE DICIONARIOS
        static void Main(string[] args)
        {
            var sexo = new Dictionary<string, string>();
            sexo.Add("M", "Masculino");
            sexo.Add("F", "Feminino");
            System.Console.WriteLine(sexo["F"]);


            var cidades = new Dictionary<string, string>();
            cidades.Add("SP", "Sao Paulo");
            cidades.Add("RJ", "Rio de Janeiro");
            cidades.Add("RS", "Rio Grande do Sul");

            foreach (var itemCidades in cidades)
            {
                System.Console.WriteLine(itemCidades.Key + " - " + itemCidades.Value);         
            }


            var paises = new Dictionary<int, string>();
            paises.Add(0, "Brasil");
            paises.Add(1, "Alemanha");
            paises.Add(2, "Espanha");
            paises.Add(3, "Estados Unidos");

            //Dicionario com Classe
            var produtos = new Dictionary<int, ProdutoMOD>();
            produtos.Add(0, new ProdutoMOD() { DataFabricaco = DateTime.Now, DataVencimento = DateTime.Now, Nome = "Produto - 1", Preco = "10,00" });
            produtos.Add(1, new ProdutoMOD() { DataFabricaco = DateTime.Now, DataVencimento = DateTime.Now, Nome = "Produto - 2", Preco = "12,00" });
            produtos.Add(2, new ProdutoMOD() { DataFabricaco = DateTime.Now, DataVencimento = DateTime.Now, Nome = "Produto - 3", Preco = "13,00" });
            foreach (var itemProdutos in produtos)
            {
                System.Console.WriteLine(itemProdutos.Key + " - " + itemProdutos.Value);
            }

            System.Console.ReadKey();
        }
    }
}
