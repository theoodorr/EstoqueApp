namespace EstoqueApp.UserControls.Estoque
{
    partial class NewItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBoxValor = new TextBox();
            label3 = new Label();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // txtBoxValor
            // 
            txtBoxValor.Location = new Point(140, 25);
            txtBoxValor.MaxLength = 25;
            txtBoxValor.Name = "txtBoxValor";
            txtBoxValor.Size = new Size(121, 23);
            txtBoxValor.TabIndex = 15;
            txtBoxValor.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 25);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 14;
            label3.Text = "Nome do item";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 74);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 16;
            label1.Text = "Valor unitário";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(141, 74);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 19;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.ThousandsSeparator = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(186, 130);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 20;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(105, 130);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // NewItem
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(284, 168);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(txtBoxValor);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewItem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Adicionar novo item";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxValor;
        private Label label3;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button btnSave;
        private Button btnCancel;
    }
}