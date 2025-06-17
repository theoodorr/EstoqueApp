using EstoqueApp.Models;
using EstoqueApp.UserControls.Views;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace EstoqueApp.Services;

public class DataPersistence
{
    private string produtosPath = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
    "EstoqueApp",
    "Produtos");

    public DataPersistence()
    {
        
    }

    public void ExportarProdutosParaJson(List<Produto> produtos)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };

        string json = JsonSerializer.Serialize(produtos, options);

        Directory.CreateDirectory(produtosPath); // cria pastas se não existirem

        string caminhoArquivo = Path.Combine(produtosPath, "Produtos.json");

        File.WriteAllText(caminhoArquivo, json);
    }

    public void ImportarProdutosDeJson(ref List<Produto> produtosRef)
    {
        string filepath = Path.Combine(produtosPath,"Produtos.json");

        if (!File.Exists(filepath))
        {
            Console.WriteLine("Arquivo de produtos não encontrado.");
            return;
        }

        try
        {
            string json = File.ReadAllText(filepath);
            var produtos = JsonSerializer.Deserialize<List<Produto>>(json);

            if (produtos != null)
            {
                produtosRef = produtos;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao importar produtos:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}
