namespace Projekt
{
    partial class Login
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
            Login_button = new Button();
            UserTXT = new TextBox();
            PasswordTXT = new TextBox();
            NewUser_button = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // Login_button
            // 
            Login_button.Location = new Point(304, 252);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(141, 81);
            Login_button.TabIndex = 0;
            Login_button.Text = "Login";
            Login_button.UseVisualStyleBackColor = true;
            Login_button.Click += Login_button_Click;
            // 
            // UserTXT
            // 
            UserTXT.Location = new Point(159, 103);
            UserTXT.Name = "UserTXT";
            UserTXT.PlaceholderText = "Mail";
            UserTXT.Size = new Size(472, 35);
            UserTXT.TabIndex = 2;
            // 
            // PasswordTXT
            // 
            PasswordTXT.Location = new Point(159, 179);
            PasswordTXT.Name = "PasswordTXT";
            PasswordTXT.PasswordChar = '*';
            PasswordTXT.PlaceholderText = "Password";
            PasswordTXT.Size = new Size(472, 35);
            PasswordTXT.TabIndex = 3;
            // 
            // NewUser_button
            // 
            NewUser_button.Location = new Point(28, 345);
            NewUser_button.Name = "NewUser_button";
            NewUser_button.Size = new Size(141, 81);
            NewUser_button.TabIndex = 4;
            NewUser_button.Text = "New user";
            NewUser_button.UseVisualStyleBackColor = true;
            NewUser_button.Click += NewUser_button_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(637, 376);
            Exit.Name = "Exit";
            Exit.Size = new Size(135, 51);
            Exit.TabIndex = 5;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(Exit);
            Controls.Add(NewUser_button);
            Controls.Add(PasswordTXT);
            Controls.Add(UserTXT);
            Controls.Add(Login_button);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login_button;
        private Button Register_button;
        private TextBox UserTXT;
        private TextBox PasswordTXT;
        private Button NewUser_button;
        private Button Exit;
    }
}
