
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
                }
            }
        }
        private UserControl _produtos;
        private UserControl _estoque;
        private UserControl _config;
        private UserControl _home;
        private ProdutosHandler produtosHandler;
        public Form1()
        {
            InitializeComponent();

            produtosHandler = new();

            _produtos = new Produtos(produtosHandler);
            _estoque = new Estoque(produtosHandler);
            _config = new Configuration();
            _home = new Home();
            CurrentContent = _home;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MainNavigation navigationPanel = new();
            navigationPanel.Dock = DockStyle.Fill;

            NavigationPanel.Controls.Clear();
            NavigationPanel.Controls.Add(navigationPanel);

            navigationPanel.ProductsClicked += () => CurrentContent = _produtos;
            navigationPanel.EstoqueClicked += () => CurrentContent = _estoque;
            navigationPanel.ConfigClicked += () => CurrentContent = _config;
            navigationPanel.HomeClicked += () => CurrentContent = _home;
            navigationPanel.FileClicked += () => FileClicked();


        }

        private void FileClicked()
        {
            throw new NotImplementedException();
        }
    }
}
