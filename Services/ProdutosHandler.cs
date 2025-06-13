using EstoqueApp.Models;

namespace EstoqueApp.Services;

public class ProdutosHandler
{
    private List<Produto> produtos;


    public ProdutosHandler()
    {
        produtos = new()
        {
            new("Maça"){Code = "1", Price = 0.5f, Quantity = 3},
            new("Banana"){Code = "2", Price = 1.0f, Quantity = 5}
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
}
