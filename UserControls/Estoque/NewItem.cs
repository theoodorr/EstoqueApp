using EstoqueApp.Models;

namespace EstoqueApp.UserControls.Estoque
{
    public partial class NewItem : Form
    {
        public Action<Produto> OnSave;
        public NewItem()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Produto produto;
            // Verificar se os campos estão preenchidos
            if (!string.IsNullOrWhiteSpace(txtBoxName.Text))
            {
                if (decimal.TryParse(inputValue.Value.ToString(), out decimal valor) && valor >= 0)
                {
                    OnSave?.Invoke(new Produto(txtBoxName.Text) { Code = txtBoxCode.Text ?? "0", Price = valor });
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Valor incorreto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("O nome do produto não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
