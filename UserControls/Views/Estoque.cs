using EstoqueApp.Services;
using EstoqueApp.UserControls.Estoque;
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

        private UserControl? currentView;
        private UserControl? CurrentView
        {
            get => currentView;
            set
            {
                if(value is not null)
                {
                    EstoquePanel.Controls.Clear();
                    EstoquePanel.Controls.Add(value);
                    currentView = value;
                }
            }
        }

        private UserControl? estoqueHome;

        public Estoque(ProdutosHandler _produtosHandler)
        {
            InitializeComponent();

            produtosHandler = _produtosHandler;

            estoqueHome = new EstoqueHome();
            (estoqueHome as EstoqueHome)!.NewEntryClicked += NewEntryClicked;

            CurrentView = estoqueHome;
        }

        private void NewEntryClicked()
        {
            EstoqueNewEntry newEntry = new(produtosHandler);
            newEntry.GoBack = () => CurrentView = estoqueHome;
            newEntry.NewEntryAdded = () => CurrentView = estoqueHome;
            
            CurrentView = newEntry;
        }
    }
}
