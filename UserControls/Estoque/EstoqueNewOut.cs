using EstoqueApp.Models;
using EstoqueApp.Services;
using EstoqueApp.UserControls.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueApp.UserControls.Estoque;

public partial class EstoqueNewOut : UserControl
{
    public Action GoBack;
    public Action NewOutAdded;
    private ProdutosHandler produtosHandler;
    private Produto selectedProduto;
    private Produto SelectedProduto
    {
        get => selectedProduto;
        set
        {
            if (value is not null && value is Produto produto)
            {
                txtBoxCurrentQnt.Text = produto.Quantity.ToString();
                selectedProduto = produto;
            }
        }
    }
    public EstoqueNewOut(ProdutosHandler _produtosHandler)
    {
        InitializeComponent();

        produtosHandler = _produtosHandler;

        btnVoltar.Click += (sender, e) => { GoBack?.Invoke(); };
        btnNewOut.Click += (sender, e) =>
        {
            if (SelectedProduto is not null)
            {
                if (MessageBox.Show("Deseja remover o produto do estoque?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    produtosHandler.AddOut(SelectedProduto, (int)inputQuantidade.Value);
                    NewOutAdded?.Invoke();
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        };

        labelTotal.Text = "";
    }
    private void EstoqueNewOut_Load(object sender, EventArgs e)
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
            UpdateTotalQuantity();
        }
        else
        {
            throw new ArgumentException("O item selecionado é inválido.");
        }
    }
    private void inputQuantidade_ValueChanged(object sender, EventArgs e)
    {
        if (SelectedProduto is not null)
        {
            if (inputQuantidade.Value >= SelectedProduto.Quantity)
            {
                inputQuantidade.Value = SelectedProduto.Quantity;
            }
            UpdateTotalQuantity();
        }
    }
    private void UpdateTotalQuantity()
    {
        labelTotal.Text = $"{SelectedProduto.Quantity - (int)inputQuantidade.Value}";
    }
}