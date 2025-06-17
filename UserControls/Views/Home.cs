using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueApp.UserControls.Views
{
    public partial class Home : UserControl
    {
        public Action VerProdutosClicked;
        public Action EntradaDeEstoqueClicked;
        public Action ExportarTabelaClicked;
        public Home()
        {
            InitializeComponent();
        }

        private void btnVerProdutos_Click(object sender, EventArgs e) => VerProdutosClicked?.Invoke();

        private void btnEntradaDeEstoque_Click(object sender, EventArgs e) => EntradaDeEstoqueClicked?.Invoke();

        private void btnExportTable_Click(object sender, EventArgs e) => ExportarTabelaClicked?.Invoke();
    }
}
