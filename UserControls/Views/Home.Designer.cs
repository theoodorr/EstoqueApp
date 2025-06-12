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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            // button1
            // 
            button1.Location = new Point(162, 227);
            button1.Name = "button1";
            button1.Size = new Size(122, 55);
            button1.TabIndex = 8;
            button1.Text = "Ver produtos";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(313, 227);
            button2.Name = "button2";
            button2.Size = new Size(122, 55);
            button2.TabIndex = 9;
            button2.Text = "Entrada de Estoque";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(162, 303);
            button3.Name = "button3";
            button3.Size = new Size(122, 55);
            button3.TabIndex = 10;
            button3.Text = "Importar tabela";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(313, 303);
            button4.Name = "button4";
            button4.Size = new Size(122, 55);
            button4.TabIndex = 11;
            button4.Text = "Exportar tabela";
            button4.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
