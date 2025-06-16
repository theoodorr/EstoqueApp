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
            txtBoxName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            inputValue = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            txtBoxCode = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)inputValue).BeginInit();
            SuspendLayout();
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(140, 25);
            txtBoxName.MaxLength = 25;
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(121, 23);
            txtBoxName.TabIndex = 15;
            txtBoxName.TextAlign = HorizontalAlignment.Center;
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
            label1.Location = new Point(12, 106);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 16;
            label1.Text = "Valor unitário";
            // 
            // inputValue
            // 
            inputValue.DecimalPlaces = 2;
            inputValue.Location = new Point(141, 106);
            inputValue.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            inputValue.Name = "inputValue";
            inputValue.Size = new Size(120, 23);
            inputValue.TabIndex = 19;
            inputValue.TextAlign = HorizontalAlignment.Center;
            inputValue.ThousandsSeparator = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(186, 162);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 20;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(105, 162);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtBoxCode
            // 
            txtBoxCode.Location = new Point(140, 66);
            txtBoxCode.MaxLength = 25;
            txtBoxCode.Name = "txtBoxCode";
            txtBoxCode.Size = new Size(121, 23);
            txtBoxCode.TabIndex = 23;
            txtBoxCode.Text = "0";
            txtBoxCode.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 22;
            label2.Text = "Codigo do item";
            // 
            // NewItem
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(284, 203);
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
            Name = "NewItem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Adicionar novo item";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)inputValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxName;
        private Label label3;
        private Label label1;
        private NumericUpDown inputValue;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtBoxCode;
        private Label label2;
    }
}