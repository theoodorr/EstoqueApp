namespace EstoqueApp.UserControls.Views
{
    partial class Configuration
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
            txtBoxCompanyName = new TextBox();
            label4 = new Label();
            cmbBoxCurrency = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(34, 63);
            label2.Name = "label2";
            label2.Size = new Size(268, 21);
            label2.TabIndex = 6;
            label2.Text = "Ajuste as configurações do aplicativo.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.Location = new Point(20, 10);
            label1.Name = "label1";
            label1.Size = new Size(383, 41);
            label1.TabIndex = 5;
            label1.Text = "Configurações do Sistema";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(34, 144);
            label3.Name = "label3";
            label3.Size = new Size(149, 21);
            label3.TabIndex = 7;
            label3.Text = "Nome da Empresa";
            // 
            // txtBoxCompanyName
            // 
            txtBoxCompanyName.Location = new Point(49, 179);
            txtBoxCompanyName.Name = "txtBoxCompanyName";
            txtBoxCompanyName.Size = new Size(194, 23);
            txtBoxCompanyName.TabIndex = 8;
            txtBoxCompanyName.Text = "Zeca da silva";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(34, 236);
            label4.Name = "label4";
            label4.Size = new Size(121, 21);
            label4.TabIndex = 9;
            label4.Text = "Moeda Padrão";
            // 
            // cmbBoxCurrency
            // 
            cmbBoxCurrency.FormattingEnabled = true;
            cmbBoxCurrency.Location = new Point(49, 272);
            cmbBoxCurrency.Name = "cmbBoxCurrency";
            cmbBoxCurrency.Size = new Size(194, 23);
            cmbBoxCurrency.TabIndex = 10;
            cmbBoxCurrency.SelectedIndexChanged += cmbBoxCurrency_SelectedIndexChanged;
            // 
            // Configuration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbBoxCurrency);
            Controls.Add(label4);
            Controls.Add(txtBoxCompanyName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Configuration";
            Size = new Size(620, 530);
            Load += Configuration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtBoxCompanyName;
        private Label label4;
        private ComboBox cmbBoxCurrency;
    }
}
