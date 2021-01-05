using System;
using System.Collections.Generic;
using ProjetoEtiquetaProdutos.Entities;

namespace ProjetoEtiquetaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            Console.Write("Digite o numero de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do Produto #{i} : ");

                Console.Write("O produto é Usado, Importado ou Novo? (n/u/i) ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Nome do Produto: ");
                string nome = Console.ReadLine();

                Console.Write("Preço do Produto: ");
                double preço = double.Parse(Console.ReadLine());

                if(ch == 'i')
                {
                    Console.Write("Qual o valor da taxa de importação: ");
                    double taxaDeImportaçao = double.Parse(Console.ReadLine());

                    list.Add(new ProdutoImportado(nome, preço, taxaDeImportaçao));

                }

                else if(ch == 'u')
                {
                    Console.Write("Data de fabricação: ");
                    DateTime dataDeFabricaçao = DateTime.Parse(Console.ReadLine());

                    list.Add(new ProdutosUsados(nome, preço, dataDeFabricaçao));

                }

                else
                {
                    list.Add(new Produto(nome, preço));
                }

            }

            Console.WriteLine();

            Console.WriteLine("ETIQUETA DE PREÇOS DOS PRODUTOS: ");

            foreach(Produto prod in list)
            {
                Console.WriteLine(prod.Etiqueta());

            }

        }
    }
}
