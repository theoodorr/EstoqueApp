namespace EstoqueApp.UserControls.Estoque
{
    partial class EstoqueNewOut
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
            labelTotal = new Label();
            btnVoltar = new Button();
            label4 = new Label();
            btnNewOut = new Button();
            txtBoxCurrentQnt = new TextBox();
            label3 = new Label();
            inputQuantidade = new NumericUpDown();
            label1 = new Label();
            cmbBoxItems = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)inputQuantidade).BeginInit();
            SuspendLayout();
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 12F);
            labelTotal.Location = new Point(221, 142);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(33, 21);
            labelTotal.TabIndex = 28;
            labelTotal.Text = "qnt";
            labelTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(97, 206);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(108, 34);
            btnVoltar.TabIndex = 27;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(160, 142);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 26;
            label4.Text = "Total:";
            // 
            // btnNewOut
            // 
            btnNewOut.Location = new Point(221, 206);
            btnNewOut.Name = "btnNewOut";
            btnNewOut.Size = new Size(108, 34);
            btnNewOut.TabIndex = 25;
            btnNewOut.Text = "Aplicar Saída";
            btnNewOut.UseVisualStyleBackColor = true;
            // 
            // txtBoxCurrentQnt
            // 
            txtBoxCurrentQnt.Location = new Point(259, 47);
            txtBoxCurrentQnt.Name = "txtBoxCurrentQnt";
            txtBoxCurrentQnt.ReadOnly = true;
            txtBoxCurrentQnt.Size = new Size(121, 23);
            txtBoxCurrentQnt.TabIndex = 24;
            txtBoxCurrentQnt.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(97, 47);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 23;
            label3.Text = "Quantidade atual";
            // 
            // inputQuantidade
            // 
            inputQuantidade.Location = new Point(259, 89);
            inputQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            inputQuantidade.Name = "inputQuantidade";
            inputQuantidade.Size = new Size(121, 23);
            inputQuantidade.TabIndex = 22;
            inputQuantidade.TextAlign = HorizontalAlignment.Center;
            inputQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            inputQuantidade.ValueChanged += inputQuantidade_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(97, 91);
            label1.Name = "label1";
            label1.Size = new Size(150, 21);
            label1.TabIndex = 21;
            label1.Text = "Quantidade à retirar";
            // 
            // cmbBoxItems
            // 
            cmbBoxItems.FormattingEnabled = true;
            cmbBoxItems.Location = new Point(259, 1);
            cmbBoxItems.Name = "cmbBoxItems";
            cmbBoxItems.Size = new Size(121, 23);
            cmbBoxItems.TabIndex = 19;
            cmbBoxItems.SelectedIndexChanged += cmbBoxItems_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(97, 3);
            label2.Name = "label2";
            label2.Size = new Size(41, 21);
            label2.TabIndex = 18;
            label2.Text = "Item";
            // 
            // EstoqueNewOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelTotal);
            Controls.Add(btnVoltar);
            Controls.Add(label4);
            Controls.Add(btnNewOut);
            Controls.Add(txtBoxCurrentQnt);
            Controls.Add(label3);
            Controls.Add(inputQuantidade);
            Controls.Add(label1);
            Controls.Add(cmbBoxItems);
            Controls.Add(label2);
            Name = "EstoqueNewOut";
            Size = new Size(481, 464);
            Load += EstoqueNewOut_Load;
            ((System.ComponentModel.ISupportInitialize)inputQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTotal;
        private Button btnVoltar;
        private Label label4;
        private Button btnNewOut;
        private TextBox txtBoxCurrentQnt;
        private Label label3;
        private NumericUpDown inputQuantidade;
        private Label label1;
        private ComboBox cmbBoxItems;
        private Label label2;
    }
}
