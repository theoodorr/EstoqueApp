
using EstoqueApp.UserControls;

namespace EstoqueApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MainNavigation navigationPanel = new();
            navigationPanel.Dock = DockStyle.Fill;

            NavigationPanel.Controls.Clear();
            NavigationPanel.Controls.Add(navigationPanel);
        }
    }
}
