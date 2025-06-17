namespace EstoqueApp.UserControls.Views
{
    partial class Home
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnVerProdutos = new Button();
            btnEntradaDeEstoque = new Button();
            btnExportTable = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(203, 152);
            label2.Name = "label2";
            label2.Size = new Size(181, 21);
            label2.TabIndex = 6;
            label2.Text = "O que vamos fazer hoje?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.Location = new Point(128, 34);
            label1.Name = "label1";
            label1.Size = new Size(344, 41);
            label1.TabIndex = 5;
            label1.Text = "Bem-vindo ao Controle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label3.Location = new Point(203, 75);
            label3.Name = "label3";
            label3.Size = new Size(183, 41);
            label3.TabIndex = 7;
            label3.Text = "de Estoque!";
            // 
            // btnVerProdutos
            // 
            btnVerProdutos.Location = new Point(162, 227);
            btnVerProdutos.Name = "btnVerProdutos";
            btnVerProdutos.Size = new Size(122, 55);
            btnVerProdutos.TabIndex = 8;
            btnVerProdutos.Text = "Ver produtos";
            btnVerProdutos.UseVisualStyleBackColor = true;
            btnVerProdutos.Click += btnVerProdutos_Click;
            // 
            // btnEntradaDeEstoque
            // 
            btnEntradaDeEstoque.Location = new Point(313, 227);
            btnEntradaDeEstoque.Name = "btnEntradaDeEstoque";
            btnEntradaDeEstoque.Size = new Size(122, 55);
            btnEntradaDeEstoque.TabIndex = 9;
            btnEntradaDeEstoque.Text = "Entrada de Estoque";
            btnEntradaDeEstoque.UseVisualStyleBackColor = true;
            btnEntradaDeEstoque.Click += btnEntradaDeEstoque_Click;
            // 
            // btnExportTable
            // 
            btnExportTable.Location = new Point(162, 301);
            btnExportTable.Name = "btnExportTable";
            btnExportTable.Size = new Size(273, 55);
            btnExportTable.TabIndex = 11;
            btnExportTable.Text = "Exportar tabela";
            btnExportTable.UseVisualStyleBackColor = true;
            btnExportTable.Click += btnExportTable_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnExportTable);
            Controls.Add(btnEntradaDeEstoque);
            Controls.Add(btnVerProdutos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Home";
            Size = new Size(620, 530);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnVerProdutos;
        private Button btnEntradaDeEstoque;
        private Button btnExportTable;
    }
}
