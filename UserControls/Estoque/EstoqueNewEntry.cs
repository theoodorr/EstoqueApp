using EstoqueApp.Models;
using EstoqueApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
