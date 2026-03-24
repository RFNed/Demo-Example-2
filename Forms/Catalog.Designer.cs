namespace Demo_Example_2.Forms
{
    partial class Catalog
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
            GreetLabel = new Label();
            itemList = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // GreetLabel
            // 
            GreetLabel.AutoSize = true;
            GreetLabel.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            GreetLabel.Location = new Point(123, 30);
            GreetLabel.Name = "GreetLabel";
            GreetLabel.Size = new Size(242, 30);
            GreetLabel.TabIndex = 0;
            GreetLabel.Text = "Добро пожаловать, ";
            // 
            // itemList
            // 
            itemList.Anchor = AnchorStyles.None;
            itemList.AutoScroll = true;
            itemList.FlowDirection = FlowDirection.TopDown;
            itemList.Location = new Point(12, 161);
            itemList.Name = "itemList";
            itemList.Size = new Size(804, 281);
            itemList.TabIndex = 1;
            itemList.TabStop = true;
            // 
            // Catalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 485);
            Controls.Add(itemList);
            Controls.Add(GreetLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Catalog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Каталог";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GreetLabel;
        private FlowLayoutPanel itemList;
    }
}