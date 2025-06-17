using EstoqueApp.Models;
using EstoqueApp.Services;
using EstoqueApp.UserControls.Views;

namespace EstoqueApp.UserControls.Estoque
{
    public partial class EstoqueNewEntry : UserControl
    {
        public Action GoBack;
        public Action NewEntryAdded;
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
                    txtBoxValor.Text = $"{Configuration.SelectedCurrencyPrefix} {produto.Price}";
                    selectedProduto = produto;
                }
            }
        }
        public EstoqueNewEntry(ProdutosHandler _produtosHandler)
        {
            InitializeComponent();

            produtosHandler = _produtosHandler;

            btnVoltar.Click += (sender, e) =>
            {
                produtosHandler.SaveProdutos();
                GoBack?.Invoke();
            };
            btnNewEntry.Click += (sender, e) =>
            {
                if (SelectedProduto is not null)
                {
                    if (MessageBox.Show("Deseja adicionar o produto ao estoque?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        produtosHandler.AddEntry(SelectedProduto, (int)inputQuantidade.Value);
                        produtosHandler.SaveProdutos();
                        NewEntryAdded?.Invoke();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um produto válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            };

            labelTotal.Text = "";
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
                inputQuantidade.Value = 1;
                UpdateTotalPrice();
            }
            else
            {
                throw new ArgumentException("O item selecionado é inválido.");
            }
        }

        private void UpdateTotalPrice()
        {
            labelTotal.Text = $"Total: {Configuration.SelectedCurrencyPrefix} {SelectedProduto.Price * (int)inputQuantidade.Value}";
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
