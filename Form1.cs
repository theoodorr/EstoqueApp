
using EstoqueApp.Services;
using EstoqueApp.UserControls;
using EstoqueApp.UserControls.Views;

namespace EstoqueApp
{
    public partial class Form1 : Form
    {
        private UserControl? _currentContent;
        private UserControl CurrentContent
        {
            get => _currentContent!;
            set
            {
                if (value is not null)
                {
                    ContentPanel.Controls.Clear();
                    ContentPanel.Controls.Add(value);
                    _currentContent = value;
                }
            }
        }
        private UserControl _produtos;
        private UserControl _estoque;
        private UserControl _config;
        private UserControl _home;
        private ProdutosHandler produtosHandler;

        private DataPersistence dataPersistence;
        public Form1()
        {
            InitializeComponent();

            dataPersistence = new();
            produtosHandler = new(dataPersistence);

            _produtos = new Produtos(produtosHandler);
            _estoque = new Estoque(produtosHandler);
            _config = new Configuration();
            _home = new Home();
            var home = _home as Home;
            home!.VerProdutosClicked = () =>
            {
                CurrentContent = _produtos;
            };
            home.EntradaDeEstoqueClicked = () =>
            {
                CurrentContent = _estoque;
                (_estoque as Estoque)!.NewEntryInvoked();
            };
            home.ExportarTabelaClicked = () =>
            {
                FileClicked();
            };
            CurrentContent = _home;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MainNavigation navigationPanel = new();
            navigationPanel.Dock = DockStyle.Fill;

            NavigationPanel.Controls.Clear();
            NavigationPanel.Controls.Add(navigationPanel);

            navigationPanel.ProductsClicked += () =>
            {
                _produtos = new Produtos(produtosHandler);
                CurrentContent = _produtos;
            };
            navigationPanel.EstoqueClicked += () =>
            {
                if (CurrentContent.Name != _estoque.Name) CurrentContent = _estoque;
            };
            navigationPanel.ConfigClicked += () =>
            {
                if (CurrentContent.Name != _config.Name) CurrentContent = _config;
            };
            navigationPanel.HomeClicked += () =>
            {
                if (CurrentContent.Name != _home.Name) CurrentContent = _home;
            };
            navigationPanel.FileClicked += () => FileClicked();
        }

        private void FileClicked()
        {
            (_produtos as Produtos)!.Export?.Invoke();
        }
    }
}
