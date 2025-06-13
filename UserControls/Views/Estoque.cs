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

namespace EstoqueApp.UserControls.Views
{
    public partial class Estoque : UserControl
    {
        private ProdutosHandler produtosHandler;
        public Estoque(ProdutosHandler _produtosHandler)
        {
            InitializeComponent();

            produtosHandler = _produtosHandler;
        }
    }
}
