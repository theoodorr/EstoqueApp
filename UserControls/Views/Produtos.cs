using EstoqueApp.Models;
using EstoqueApp.Services;
using EstoqueApp.UserControls.Estoque;

namespace EstoqueApp.UserControls.Views
{
    public partial class Produtos : UserControl
    {
        private ProdutosHandler produtosHandler;
        private Produto selectedProduto;
        private Produto SelectedProduto
        {
            get => selectedProduto;
            set
            {
                if (value is not null && value is Produto produto)
                {
                    selectedProduto = produto;
                    btnEdit.Enabled = true;
                }
            }
        }
        public Produtos(ProdutosHandler _produtosHandler)
        {
            InitializeComponent();

            produtosHandler = _produtosHandler;

            dataGridView.Rows.Clear();
            foreach (Produto produto in produtosHandler.GetProdutos())
            {
                dataGridView.Rows.Add(produto.Code, produto.Name, $"R$ {produto.Price}", produto.Quantity);
            }


        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0 && dataGridView.SelectedCells[1] is not null)
            {
                SelectedProduto = produtosHandler.GetItemByName(dataGridView.SelectedCells[1].Value.ToString()!);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectedProduto is not null)
            {
                EditItem editItem = new(produtosHandler, SelectedProduto);
                editItem.Save = () =>
                {
                    UpgradeGrid();
                };
                editItem.ShowDialog();

                btnEdit.Enabled = false;
                dataGridView.ClearSelection();
            }
        }

        private void UpgradeGrid()
        {
            dataGridView.Rows.Clear();
            foreach (Produto produto in produtosHandler.GetProdutos())
            {
                dataGridView.Rows.Add(produto.Code, produto.Name, $"R$ {produto.Price}", produto.Quantity);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }
}
