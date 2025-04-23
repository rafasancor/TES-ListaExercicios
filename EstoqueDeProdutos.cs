using System;

class Produto {
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public double ValorTotalEmEstoque() {
        return Preco * Quantidade;
    }
}

class EstoqueDeProdutos {
    static void Main() {
        Produto[] produtos = new Produto[3];

        // Cadastro de 3 produtos
        for (int i = 0; i < 3; i++) {
            produtos[i] = new Produto();

            Console.WriteLine("\nDigite as informações do produto " + (i + 1) + ":");

            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produtos[i].Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n--- Produtos Cadastrados ---");
        double valorTotalEstoque = 0;
        for (int i = 0; i < 3; i++) {
            double totalProduto = produtos[i].ValorTotalEmEstoque();
            valorTotalEstoque += totalProduto;
            Console.WriteLine(produtos[i].Nome + " - Preço: R$" + produtos[i].Preco + " - Quantidade: " + produtos[i].Quantidade + " - Valor Total: R$" + totalProduto);
        }

        Console.WriteLine("\nValor total de todos os produtos em estoque: R$" + valorTotalEstoque);
    }
}
