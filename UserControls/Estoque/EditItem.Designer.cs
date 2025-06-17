namespace EstoqueApp.UserControls.Estoque
{
    partial class EditItem
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
            txtBoxCode = new TextBox();
            label2 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            inputValue = new NumericUpDown();
            label1 = new Label();
            txtBoxName = new TextBox();
            label3 = new Label();
            inputQuantidade = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)inputValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputQuantidade).BeginInit();
            SuspendLayout();
            // 
            // txtBoxCode
            // 
            txtBoxCode.Location = new Point(140, 70);
            txtBoxCode.MaxLength = 25;
            txtBoxCode.Name = "txtBoxCode";
            txtBoxCode.Size = new Size(121, 23);
            txtBoxCode.TabIndex = 31;
            txtBoxCode.Text = "0";
            txtBoxCode.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 30;
            label2.Text = "Codigo do item";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(105, 196);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(186, 196);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 28;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // inputValue
            // 
            inputValue.DecimalPlaces = 2;
            inputValue.Location = new Point(140, 110);
            inputValue.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            inputValue.Name = "inputValue";
            inputValue.Size = new Size(120, 23);
            inputValue.TabIndex = 27;
            inputValue.TextAlign = HorizontalAlignment.Center;
            inputValue.ThousandsSeparator = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 110);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 26;
            label1.Text = "Valor unitário";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(140, 29);
            txtBoxName.MaxLength = 25;
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(121, 23);
            txtBoxName.TabIndex = 25;
            txtBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 29);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 24;
            label3.Text = "Nome do item";
            // 
            // inputQuantidade
            // 
            inputQuantidade.Location = new Point(140, 151);
            inputQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            inputQuantidade.Name = "inputQuantidade";
            inputQuantidade.Size = new Size(121, 23);
            inputQuantidade.TabIndex = 33;
            inputQuantidade.TextAlign = HorizontalAlignment.Center;
            inputQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 151);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 32;
            label4.Text = "Quantidade";
            // 
            // EditItem
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(284, 231);
            Controls.Add(inputQuantidade);
            Controls.Add(label4);
            Controls.Add(txtBoxCode);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(inputValue);
            Controls.Add(label1);
            Controls.Add(txtBoxName);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditItem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar item existente";
            ((System.ComponentModel.ISupportInitialize)inputValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxCode;
        private Label label2;
        private Button btnCancel;
        private Button btnSave;
        private NumericUpDown inputValue;
        private Label label1;
        private TextBox txtBoxName;
        private Label label3;
        private NumericUpDown inputQuantidade;
        private Label label4;
    }
}