namespace EstoqueApp.UserControls
{
    partial class MainNavigation
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxFile = new PictureBox();
            labelProdutos = new Label();
            pictureBoxProducts = new PictureBox();
            labelEstoque = new Label();
            pictureBoxEstoque = new PictureBox();
            labelConfiguracoes = new Label();
            pictureBoxConfig = new PictureBox();
            labelArquivo = new Label();
            labelInicio = new Label();
            pictureBoxHome = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConfig).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFile
            // 
            pictureBoxFile.Location = new Point(235, 0);
            pictureBoxFile.Name = "pictureBoxFile";
            pictureBoxFile.Size = new Size(80, 80);
            pictureBoxFile.TabIndex = 7;
            pictureBoxFile.TabStop = false;
            pictureBoxFile.Click += pictureBoxFile_Click;
            // 
            // labelProdutos
            // 
            labelProdutos.AutoSize = true;
            labelProdutos.ForeColor = Color.White;
            labelProdutos.Location = new Point(398, 83);
            labelProdutos.Name = "labelProdutos";
            labelProdutos.Size = new Size(55, 15);
            labelProdutos.TabIndex = 10;
            labelProdutos.Text = "Produtos";
            // 
            // pictureBoxProducts
            // 
            pictureBoxProducts.Location = new Point(385, 0);
            pictureBoxProducts.Name = "pictureBoxProducts";
            pictureBoxProducts.Size = new Size(80, 80);
            pictureBoxProducts.TabIndex = 9;
            pictureBoxProducts.TabStop = false;
            pictureBoxProducts.Click += pictureBoxProducts_Click;
            // 
            // labelEstoque
            // 
            labelEstoque.AutoSize = true;
            labelEstoque.ForeColor = Color.White;
            labelEstoque.Location = new Point(551, 83);
            labelEstoque.Name = "labelEstoque";
            labelEstoque.Size = new Size(49, 15);
            labelEstoque.TabIndex = 12;
            labelEstoque.Text = "Estoque";
            // 
            // pictureBoxEstoque
            // 
            pictureBoxEstoque.Location = new Point(535, 0);
            pictureBoxEstoque.Name = "pictureBoxEstoque";
            pictureBoxEstoque.Size = new Size(80, 80);
            pictureBoxEstoque.TabIndex = 11;
            pictureBoxEstoque.TabStop = false;
            pictureBoxEstoque.Click += pictureBoxEstoque_Click;
            // 
            // labelConfiguracoes
            // 
            labelConfiguracoes.AutoSize = true;
            labelConfiguracoes.ForeColor = Color.White;
            labelConfiguracoes.Location = new Point(683, 83);
            labelConfiguracoes.Name = "labelConfiguracoes";
            labelConfiguracoes.Size = new Size(84, 15);
            labelConfiguracoes.TabIndex = 14;
            labelConfiguracoes.Text = "Configurações";
            // 
            // pictureBoxConfig
            // 
            pictureBoxConfig.Location = new Point(685, 0);
            pictureBoxConfig.Name = "pictureBoxConfig";
            pictureBoxConfig.Size = new Size(80, 80);
            pictureBoxConfig.TabIndex = 13;
            pictureBoxConfig.TabStop = false;
            pictureBoxConfig.Click += pictureBoxConfig_Click;
            // 
            // labelArquivo
            // 
            labelArquivo.AutoSize = true;
            labelArquivo.ForeColor = Color.White;
            labelArquivo.Location = new Point(251, 83);
            labelArquivo.Name = "labelArquivo";
            labelArquivo.Size = new Size(49, 15);
            labelArquivo.TabIndex = 8;
            labelArquivo.Text = "Arquivo";
            // 
            // labelInicio
            // 
            labelInicio.AutoSize = true;
            labelInicio.ForeColor = Color.White;
            labelInicio.Location = new Point(107, 83);
            labelInicio.Name = "labelInicio";
            labelInicio.Size = new Size(36, 15);
            labelInicio.TabIndex = 16;
            labelInicio.Text = "Início";
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.Location = new Point(85, 0);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(80, 80);
            pictureBoxHome.TabIndex = 15;
            pictureBoxHome.TabStop = false;
            pictureBoxHome.Click += pictureBoxHome_Click;
            // 
            // MainNavigation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            Controls.Add(labelInicio);
            Controls.Add(pictureBoxHome);
            Controls.Add(labelConfiguracoes);
            Controls.Add(pictureBoxConfig);
            Controls.Add(labelEstoque);
            Controls.Add(pictureBoxEstoque);
            Controls.Add(labelProdutos);
            Controls.Add(pictureBoxProducts);
            Controls.Add(labelArquivo);
            Controls.Add(pictureBoxFile);
            Name = "MainNavigation";
            Size = new Size(850, 100);
            Load += MainNavigation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFile).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConfig).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxFile;
        private Label labelProdutos;
        private PictureBox pictureBoxProducts;
        private Label labelEstoque;
        private PictureBox pictureBoxEstoque;
        private Label labelConfiguracoes;
        private PictureBox pictureBoxConfig;
        private Label labelArquivo;
        private Label labelInicio;
        private PictureBox pictureBoxHome;
    }
}
