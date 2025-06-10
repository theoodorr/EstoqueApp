using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueApp.UserControls
{
    public partial class MainNavigation : UserControl
    {
        #region Actions when a option is selected
        public Action FileClicked;
        public Action ProductsClicked;
        public Action EstoqueClicked;
        public Action ConfigClicked;
        public Action HomeClicked;
        private void pictureBoxHome_Click(object sender, EventArgs e) => HomeClicked?.Invoke();
        private void pictureBoxFile_Click(object sender, EventArgs e) => FileClicked?.Invoke();
        private void pictureBoxProducts_Click(object sender, EventArgs e) => ProductsClicked?.Invoke();
        private void pictureBoxEstoque_Click(object sender, EventArgs e) => EstoqueClicked?.Invoke();
        private void pictureBoxConfig_Click(object sender, EventArgs e) => ConfigClicked?.Invoke();
        #endregion

        public MainNavigation()
        {
            InitializeComponent();
        }

        private void MainNavigation_Load(object sender, EventArgs e)
        {
            SetPicturesImages();
        }

        private void SetPicturesImages()
        {
            pictureBoxHome.Image = Image.FromFile("Resources/home.png");
            pictureBoxFile.Image = Image.FromFile("Resources/file.png");
            pictureBoxProducts.Image = Image.FromFile("Resources/products.png");
            pictureBoxEstoque.Image = Image.FromFile("Resources/estoque.png");
            pictureBoxConfig.Image = Image.FromFile("Resources/config.png");
        }
    }
}
