using System;
using System.Collections.Generic;

namespace RateioCustoFrete
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, (double preco, int quantidade)> produtos = new Dictionary<string, (double, int)>();

            // Solicita os produtos, preços e quantidades até que o usuário decida parar
            while (true)
            {
                Console.WriteLine("Digite o nome do produto (ou digite 'fim' para finalizar):");
                string nomeProduto = Console.ReadLine();

                // Verifica se o usuário digitou 'fim' para encerrar a entrada de produtos
                if (nomeProduto.ToLower() == "fim")
                    break;

                Console.WriteLine("Digite o preço do produto:");
                double precoProduto;

                // Verifica se o preço é válido
                while (!double.TryParse(Console.ReadLine(), out precoProduto))
                {
                    Console.WriteLine("Preço inválido! Por favor, insira um valor numérico válido:");
                }

                Console.WriteLine("Digite a quantidade do produto:");
                int quantidadeProduto;

                // Verifica se a quantidade é válida
                while (!int.TryParse(Console.ReadLine(), out quantidadeProduto))
                {
                    Console.WriteLine("Quantidade inválida! Por favor, insira um valor numérico válido:");
                }

                // Adiciona o produto, seu preço e sua quantidade ao dicionário
                produtos.Add(nomeProduto, (precoProduto, quantidadeProduto));
            }

            // Solicita o custo total do frete
            Console.WriteLine("Digite o custo total do frete:");
            double custoFrete = Convert.ToDouble(Console.ReadLine());

            // Solicita o valor total cobrado em impostos
            Console.WriteLine("Digite o valor total cobrado em impostos:");
            double valorImpostos = Convert.ToDouble(Console.ReadLine());

            // Calcula o preço total dos produtos
            double precoTotal = 0;
            foreach (var produto in produtos)
            {
                precoTotal += produto.Value.preco * produto.Value.quantidade;
            }

            Console.WriteLine($"######## RELATÓRIO ########");
            Console.WriteLine();

            // Exibe os detalhes para cada produto
            foreach (var produto in produtos)
            {
                double percentual = (produto.Value.preco * produto.Value.quantidade / precoTotal) * 100;
                double custoFreteProduto = (custoFrete * percentual) / 100;
                double custoImpostosProduto = (valorImpostos * percentual) / 100;
                double custoTotalProduto = produto.Value.preco + (custoFreteProduto / produto.Value.quantidade) + (custoImpostosProduto / produto.Value.quantidade);

                Console.WriteLine($"DETALHES DO PRODUTO '{produto.Key}':");
                Console.WriteLine($"- Preço: R$ {produto.Value.preco:F2}");
                Console.WriteLine($"- Quantidade: {produto.Value.quantidade}");
                Console.WriteLine($"- Custo de Frete por unidade: R$ {custoFreteProduto / produto.Value.quantidade:F2}");
                Console.WriteLine($"- Custo de Impostos por unidade: R$ {custoImpostosProduto / produto.Value.quantidade:F2}");
                Console.WriteLine($"- Custo Total por unidade (incluindo frete e impostos): R$ {custoTotalProduto:F2}");
                Console.WriteLine($"------------------------------------------------");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
