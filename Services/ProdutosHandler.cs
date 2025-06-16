using EstoqueApp.Models;
using System.Xml.Linq;

namespace EstoqueApp.Services;

public class ProdutosHandler
{
    private List<Produto> produtos;


    public ProdutosHandler()
    {
        produtos = new()
        {
            new("Maça"){Code = "1", Price = 0.5m, Quantity = 3},
            new("Banana"){Code = "2", Price = 1.0m, Quantity = 5}
        };
    }

    public void AddProduto(Produto produto)
    {
        produtos.Add(produto);
    }

    public List<Produto> GetProdutos()
    {
        return produtos;
    }

    public Produto GetItemByName(string name)
    {
        return produtos.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
               ?? throw new ArgumentException($"Produto com nome '{name}' não encontrado.");
    }

    internal bool IsNew(Produto produto)
    {
        var find = produtos.FirstOrDefault(p => p.Name.Equals(produto.Name, StringComparison.OrdinalIgnoreCase));
        return find is null;
    }
}
