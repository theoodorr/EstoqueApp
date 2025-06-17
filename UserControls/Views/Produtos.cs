using EstoqueApp.Models;
using EstoqueApp.Services;
using EstoqueApp.UserControls.Estoque;
using ClosedXML.Excel;

namespace EstoqueApp.UserControls.Views
{
    public partial class Produtos : UserControl
    {
        public System.Action Export;
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
                    btnDelete.Enabled = btnEdit.Enabled = true;
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
                dataGridView.Rows.Add(produto.Code, produto.Name, $"{Configuration.SelectedCurrencyPrefix} {produto.Price}", produto.Quantity);
            }

            Export += () => ExportDataGridToExcel();
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

                btnDelete.Enabled = false;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedProduto is not null)
            {
                if (MessageBox.Show($"Deseja confirmar as exclusão do produto {SelectedProduto.Name}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    produtosHandler.RemoveProduto(SelectedProduto);
                }
                
                btnDelete.Enabled = btnEdit.Enabled = false;
                dataGridView.ClearSelection();
                UpgradeGrid();
            }
        }


        private void ExportDataGridToExcel()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Dados");

                // Cabeçalhos
                for (int col = 0; col < dataGridView.Columns.Count; col++)
                {
                    worksheet.Cell(1, col + 1).Value = dataGridView.Columns[col].HeaderText;
                }

                // Dados das células
                for (int row = 0; row < dataGridView.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridView.Columns.Count; col++)
                    {
                        if (dataGridView.Rows[row].IsNewRow) continue; // Ignora a última linha em branco
                        worksheet.Cell(row + 2, col + 1).Value = dataGridView.Rows[row].Cells[col].Value?.ToString();
                    }
                }

                // Salvar o arquivo
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Salvar arquivo Excel";
                    saveFileDialog.FileName = "dados.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Arquivo salvo com sucesso!", "Exportação concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

    }
}
