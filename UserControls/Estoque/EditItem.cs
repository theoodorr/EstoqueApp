using EstoqueApp.Models;
using EstoqueApp.Services;

namespace EstoqueApp.UserControls.Estoque
{
    public partial class EditItem : Form
    {
        private ProdutosHandler produtosHandler;
        private Produto selectedProduto;

        public Action Save;
        private Produto SelectedProduto
        {
            get => selectedProduto;
            set
            {
                if (value is not null && value is Produto produto)
                {
                    txtBoxCode.Text = produto.Code;
                    txtBoxName.Text = produto.Name;
                    inputValue.Value = produto.Price;
                    inputQuantidade.Value = produto.Quantity;
                    selectedProduto = produto;
                }
            }
        }
        public EditItem(ProdutosHandler _produtosHandler, Produto _produtoToEdit)
        {
            InitializeComponent();

            produtosHandler = _produtosHandler;
            SelectedProduto = _produtoToEdit;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtBoxName.Text is not null)
            {
                if (SelectedProduto is not null && (decimal.TryParse(inputValue.Value.ToString(), out decimal valor) && valor >= 0))
                {
                    Produto editedProduto = new(txtBoxName.Text);
                    editedProduto.Code = string.IsNullOrWhiteSpace(txtBoxCode.Text) ? 0.ToString() : txtBoxCode.Text;
                    editedProduto.Price = valor;
                    editedProduto.Quantity = (int)inputQuantidade.Value;
                    produtosHandler.UpdateItem(SelectedProduto, editedProduto);
                    Save?.Invoke();
                    this.Close();
                }                
            }
        }
    }
}
