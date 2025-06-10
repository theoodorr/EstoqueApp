namespace EstoqueApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NavigationPanel = new Panel();
            ContentPanel = new Panel();
            SuspendLayout();
            // 
            // NavigationPanel
            // 
            NavigationPanel.Location = new Point(0, 0);
            NavigationPanel.Margin = new Padding(10);
            NavigationPanel.Name = "NavigationPanel";
            NavigationPanel.Size = new Size(838, 100);
            NavigationPanel.TabIndex = 0;
            // 
            // ContentPanel
            // 
            ContentPanel.Location = new Point(10, 115);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(812, 554);
            ContentPanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 681);
            Controls.Add(ContentPanel);
            Controls.Add(NavigationPanel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estoque";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel NavigationPanel;
        private Panel ContentPanel;
    }
}
