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

    public void AddEntry(Produto produto, int quantity)
    {
        var existingProduct = produtos.FirstOrDefault(p => p.Name.Equals(produto.Name, StringComparison.OrdinalIgnoreCase));
        if (existingProduct != null)
        {
            existingProduct.Quantity += quantity;
        }
        else
        {
            produto.Quantity = quantity;
            produtos.Add(produto);
        }
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

    internal void AddOut(Produto produto, int value)
    {
        var existingProduct = produtos.FirstOrDefault(p => p.Name.Equals(produto.Name, StringComparison.OrdinalIgnoreCase));
        if (existingProduct != null)
        {
            if (existingProduct.Quantity <= value)
            {
                produtos.Remove(existingProduct);
            }
            else
            {
                existingProduct.Quantity -= value;
            }
        }
    }

    internal void SaveProdutos()
    {
        // Limpar lixo
        produtos.RemoveAll(p => p.Quantity <= 0);
    }

    internal void UpdateItem(Produto selectedProduto, Produto editedProduto)
    {
        // Atualizar produto existente
        var existingProduct = produtos.FirstOrDefault(p => p.Name.Equals(selectedProduto.Name, StringComparison.OrdinalIgnoreCase));
        if (existingProduct != null)
        {
            existingProduct.Name = editedProduto.Name;
            existingProduct.Code = editedProduto.Code;
            existingProduct.Price = editedProduto.Price;
            existingProduct.Quantity = editedProduto.Quantity;
        }
        else
        {
            // Se não existir, adicionar como novo produto
            produtos.Add(editedProduto);
        }
        SaveProdutos();
    }
}
