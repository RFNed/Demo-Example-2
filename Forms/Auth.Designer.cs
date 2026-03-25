namespace Demo_Example_2
{
    partial class Auth
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
            label1 = new Label();
            loginBox = new TextBox();
            passBox = new TextBox();
            loginButton = new Button();
            guestButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label1.Location = new Point(100, 59);
            label1.Name = "label1";
            label1.Size = new Size(154, 26);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // loginBox
            // 
            loginBox.Location = new Point(100, 146);
            loginBox.MaxLength = 30;
            loginBox.Name = "loginBox";
            loginBox.PlaceholderText = "Логин";
            loginBox.Size = new Size(154, 23);
            loginBox.TabIndex = 1;
            // 
            // passBox
            // 
            passBox.Location = new Point(100, 188);
            passBox.MaxLength = 30;
            passBox.Name = "passBox";
            passBox.PasswordChar = '#';
            passBox.PlaceholderText = "Пароль";
            passBox.Size = new Size(154, 23);
            passBox.TabIndex = 2;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(139, 246);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 3;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // guestButton
            // 
            guestButton.Location = new Point(139, 275);
            guestButton.Name = "guestButton";
            guestButton.Size = new Size(75, 23);
            guestButton.TabIndex = 4;
            guestButton.Text = "Гость";
            guestButton.UseVisualStyleBackColor = true;
            guestButton.Click += guestButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(139, 366);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 5;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 447);
            Controls.Add(exitButton);
            Controls.Add(guestButton);
            Controls.Add(loginButton);
            Controls.Add(passBox);
            Controls.Add(loginBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Auth";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox loginBox;
        private TextBox passBox;
        private Button loginButton;
        private Button guestButton;
        private Button exitButton;
    }
}
