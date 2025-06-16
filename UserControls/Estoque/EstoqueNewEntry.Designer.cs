namespace EstoqueApp.UserControls.Estoque
{
    partial class EstoqueNewEntry
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
            cmbBoxItems = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            inputQuantidade = new NumericUpDown();
            label3 = new Label();
            txtBoxValor = new TextBox();
            btnNewEntry = new Button();
            label4 = new Label();
            btnVoltar = new Button();
            labelTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)inputQuantidade).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(103, 5);
            label2.Name = "label2";
            label2.Size = new Size(41, 21);
            label2.TabIndex = 5;
            label2.Text = "Item";
            // 
            // cmbBoxItems
            // 
            cmbBoxItems.FormattingEnabled = true;
            cmbBoxItems.Location = new Point(200, 3);
            cmbBoxItems.Name = "cmbBoxItems";
            cmbBoxItems.Size = new Size(121, 23);
            cmbBoxItems.TabIndex = 6;
            cmbBoxItems.SelectedIndexChanged += cmbBoxItems_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(327, 3);
            button1.Name = "button1";
            button1.Size = new Size(27, 23);
            button1.TabIndex = 7;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(103, 93);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 8;
            label1.Text = "Quantidade";
            // 
            // inputQuantidade
            // 
            inputQuantidade.Location = new Point(200, 93);
            inputQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            inputQuantidade.Name = "inputQuantidade";
            inputQuantidade.Size = new Size(121, 23);
            inputQuantidade.TabIndex = 10;
            inputQuantidade.TextAlign = HorizontalAlignment.Center;
            inputQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            inputQuantidade.ValueChanged += inputQuantidade_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(103, 49);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 12;
            label3.Text = "Valor";
            // 
            // txtBoxValor
            // 
            txtBoxValor.Location = new Point(200, 48);
            txtBoxValor.Name = "txtBoxValor";
            txtBoxValor.ReadOnly = true;
            txtBoxValor.Size = new Size(121, 23);
            txtBoxValor.TabIndex = 13;
            txtBoxValor.TextAlign = HorizontalAlignment.Center;
            // 
            // btnNewEntry
            // 
            btnNewEntry.Location = new Point(227, 208);
            btnNewEntry.Name = "btnNewEntry";
            btnNewEntry.Size = new Size(108, 34);
            btnNewEntry.TabIndex = 14;
            btnNewEntry.Text = "Aplicar Entrada";
            btnNewEntry.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(166, 144);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 15;
            label4.Text = "Total:";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(103, 208);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(108, 34);
            btnVoltar.TabIndex = 16;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 12F);
            labelTotal.Location = new Point(227, 144);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(29, 21);
            labelTotal.TabIndex = 17;
            labelTotal.Text = "R$";
            labelTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EstoqueNewEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelTotal);
            Controls.Add(btnVoltar);
            Controls.Add(label4);
            Controls.Add(btnNewEntry);
            Controls.Add(txtBoxValor);
            Controls.Add(label3);
            Controls.Add(inputQuantidade);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(cmbBoxItems);
            Controls.Add(label2);
            Name = "EstoqueNewEntry";
            Size = new Size(422, 372);
            Load += EstoqueNewEntry_Load;
            ((System.ComponentModel.ISupportInitialize)inputQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox cmbBoxItems;
        private Button button1;
        private Label label1;
        private NumericUpDown inputQuantidade;
        private Label label3;
        private TextBox txtBoxValor;
        private Button btnNewEntry;
        private Label label4;
        private Button btnVoltar;
        private Label labelTotal;
    }
}
