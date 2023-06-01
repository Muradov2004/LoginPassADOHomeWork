namespace LoginPassADOHomeWork
{
    partial class LoginWindow
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
            passwordlbl = new Label();
            usernamelbl = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            signInBtn = new Button();
            signUpBtn = new Button();
            SuspendLayout();
            // 
            // passwordlbl
            // 
            passwordlbl.AutoSize = true;
            passwordlbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordlbl.Location = new Point(68, 116);
            passwordlbl.Name = "passwordlbl";
            passwordlbl.Size = new Size(91, 25);
            passwordlbl.TabIndex = 12;
            passwordlbl.Text = "Password";
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernamelbl.Location = new Point(68, 61);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(97, 25);
            usernamelbl.TabIndex = 11;
            usernamelbl.Text = "Username";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(68, 144);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(169, 23);
            passwordTextBox.TabIndex = 10;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(68, 89);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(169, 23);
            usernameTextBox.TabIndex = 9;
            // 
            // signInBtn
            // 
            signInBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            signInBtn.Location = new Point(68, 187);
            signInBtn.Name = "signInBtn";
            signInBtn.Size = new Size(75, 39);
            signInBtn.TabIndex = 13;
            signInBtn.Text = "sign in";
            signInBtn.UseVisualStyleBackColor = true;
            signInBtn.Click += signInBtn_Click;
            // 
            // signUpBtn
            // 
            signUpBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            signUpBtn.Location = new Point(162, 187);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(75, 39);
            signUpBtn.TabIndex = 14;
            signUpBtn.Text = "sign up";
            signUpBtn.UseVisualStyleBackColor = true;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 325);
            Controls.Add(signUpBtn);
            Controls.Add(signInBtn);
            Controls.Add(passwordlbl);
            Controls.Add(usernamelbl);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Name = "LoginWindow";
            Text = "LoginWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label passwordlbl;
        private Label usernamelbl;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Button signInBtn;
        private Button signUpBtn;
    }
}