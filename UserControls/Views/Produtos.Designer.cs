namespace EstoqueApp.UserControls.Views
{
    partial class Produtos
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
            label1 = new Label();
            label2 = new Label();
            dataGridView = new DataGridView();
            ProductCode = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            ProductQuantity = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.Location = new Point(20, 10);
            label1.Name = "label1";
            label1.Size = new Size(410, 41);
            label1.TabIndex = 1;
            label1.Text = "Gerenciamento de Produtos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(34, 63);
            label2.Name = "label2";
            label2.Size = new Size(374, 21);
            label2.TabIndex = 2;
            label2.Text = "Aqui você pode adicionar, editar e remover produtos";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ProductCode, ProductName, ProductPrice, ProductQuantity });
            dataGridView.Location = new Point(34, 108);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(547, 365);
            dataGridView.TabIndex = 3;
            // 
            // ProductCode
            // 
            ProductCode.Frozen = true;
            ProductCode.HeaderText = "Código";
            ProductCode.Name = "ProductCode";
            ProductCode.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Nome do Produto";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // ProductPrice
            // 
            ProductPrice.HeaderText = "Preço";
            ProductPrice.Name = "ProductPrice";
            ProductPrice.ReadOnly = true;
            // 
            // ProductQuantity
            // 
            ProductQuantity.HeaderText = "Quantidade";
            ProductQuantity.Name = "ProductQuantity";
            ProductQuantity.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(496, 488);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(415, 488);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Produtos";
            Size = new Size(620, 530);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn ProductQuantity;
    }
}
