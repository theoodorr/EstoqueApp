using EstoqueApp.Models;
using EstoqueApp.Services;

namespace EstoqueApp.UserControls.Estoque
{
    public partial class EstoqueNewEntry : UserControl
    {
        public Action GoBack;
        private ProdutosHandler produtosHandler;
        private Produto selectedProduto;
        private Produto SelectedProduto
        {
            get => selectedProduto;
            set
            {
                if (value is not null && value is Produto produto)
                {
                    if (produtosHandler.IsNew(produto))
                    {
                        produtosHandler.AddProduto(produto);
                        cmbBoxItems.Items.Add(produto.Name);
                        cmbBoxItems.SelectedItem = produto.Name;
                    }
                    txtBoxValor.Text = $"R$ {produto.Price}";
                    selectedProduto = produto;
                }
            }
        }
        public EstoqueNewEntry(ProdutosHandler _produtosHandler)
        {
            InitializeComponent();

            produtosHandler = _produtosHandler;

            btnVoltar.Click += (sender, e) => { GoBack?.Invoke(); };
        }

        private void EstoqueNewEntry_Load(object sender, EventArgs e)
        {
            cmbBoxItems.Items.Clear();
            foreach (var produto in produtosHandler.GetProdutos())
            {
                cmbBoxItems.Items.Add(produto.Name);
            }
        }

        private void cmbBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbBoxItems.SelectedItem!.ToString()))
            {
                SelectedProduto = produtosHandler.GetItemByName(cmbBoxItems.SelectedItem.ToString()!);
                UpdateTotalPrice();
            }
            else
            {
                throw new ArgumentException("O item selecionado é inválido.");
            }
        }

        private void UpdateTotalPrice()
        {
            labelTotal.Text = $"Total: R$ {SelectedProduto.Price * (int)inputQuantidade.Value}";
        }

        private void inputQuantidade_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedProduto is not null)
            {
                UpdateTotalPrice();
            }
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            NewItem newItemForm = new NewItem();
            newItemForm.OnSave += (produto) =>
            {
                SelectedProduto = produto;
                UpdateTotalPrice();
            };

            newItemForm.ShowDialog();
        }
    }
}
