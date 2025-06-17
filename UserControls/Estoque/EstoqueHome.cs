namespace EstoqueApp.UserControls.Estoque
{
    public partial class EstoqueHome : UserControl
    {
        public Action NewEntryClicked;
        public Action NewOutClicked;
        public EstoqueHome()
        {
            InitializeComponent();
            btnNewEntry.Click += (sender, e) => { NewEntryClicked?.Invoke(); };
            btnNewOut.Click += (sender, e) => { NewOutClicked?.Invoke(); };

        }
    }
}
