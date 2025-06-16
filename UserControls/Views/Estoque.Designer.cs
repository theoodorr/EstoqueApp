namespace EstoqueApp.UserControls.Views
{
    partial class Estoque
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
            EstoquePanel = new Panel();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(34, 63);
            label2.Name = "label2";
            label2.Size = new Size(255, 21);
            label2.TabIndex = 4;
            label2.Text = "Gerencie entradas e saídas de itens.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.Location = new Point(20, 10);
            label1.Name = "label1";
            label1.Size = new Size(303, 41);
            label1.TabIndex = 3;
            label1.Text = "Controle de estoque";
            // 
            // EstoquePanel
            // 
            EstoquePanel.Location = new Point(34, 127);
            EstoquePanel.Name = "EstoquePanel";
            EstoquePanel.Size = new Size(556, 343);
            EstoquePanel.TabIndex = 5;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EstoquePanel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Estoque";
            Size = new Size(620, 530);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel EstoquePanel;
    }
}
