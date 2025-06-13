using EstoqueApp.Models;
using EstoqueApp.Services;

namespace EstoqueApp.UserControls.Views
{
    public partial class Produtos : UserControl
    {
        private ProdutosHandler produtosHandler;
        public Produtos(ProdutosHandler _produtosHandler)
        {
            InitializeComponent();

            produtosHandler = _produtosHandler;

            dataGridView.Rows.Clear();
            foreach (Produto produto in _produtosHandler.GetProdutos())
            {
                dataGridView.Rows.Add(produto.Code, produto.Name, $"R$ {produto.Price}", produto.Quantity);
            }
            
            
        }

    }
}
