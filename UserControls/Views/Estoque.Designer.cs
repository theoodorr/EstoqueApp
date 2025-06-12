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
            groupBox1 = new GroupBox();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(162, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 150);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(19, 97);
            button1.Name = "button1";
            button1.Size = new Size(108, 34);
            button1.TabIndex = 9;
            button1.Text = "Nova Entrada";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(19, 41);
            label4.Name = "label4";
            label4.Size = new Size(224, 21);
            label4.TabIndex = 8;
            label4.Text = "Registre novos itens recebidos.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(6, 11);
            label3.Name = "label3";
            label3.Size = new Size(201, 30);
            label3.TabIndex = 7;
            label3.Text = "Entrada de estoque";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(162, 320);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(290, 150);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(19, 97);
            button2.Name = "button2";
            button2.Size = new Size(108, 34);
            button2.TabIndex = 9;
            button2.Text = "Nova Saída";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(19, 41);
            label5.Name = "label5";
            label5.Size = new Size(202, 21);
            label5.TabIndex = 8;
            label5.Text = "Registre itens que deixaram";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(6, 11);
            label6.Name = "label6";
            label6.Size = new Size(180, 30);
            label6.TabIndex = 7;
            label6.Text = "Saída de estoque";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(19, 62);
            label7.Name = "label7";
            label7.Size = new Size(81, 21);
            label7.TabIndex = 10;
            label7.Text = "o estoque.";
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Estoque";
            Size = new Size(620, 530);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
