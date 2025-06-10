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

        private void pictureBoxFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arquivo clicked!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
