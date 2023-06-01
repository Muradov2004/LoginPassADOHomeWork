namespace LoginPassADOHomeWork
{
    partial class RegisterWindow
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
            paswordlbl = new Label();
            emaillbl = new Label();
            usernamelbl = new Label();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            SignUpBtn = new Button();
            backBtn = new Button();
            SuspendLayout();
            // 
            // paswordlbl
            // 
            paswordlbl.AutoSize = true;
            paswordlbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            paswordlbl.Location = new Point(97, 114);
            paswordlbl.Name = "paswordlbl";
            paswordlbl.Size = new Size(91, 25);
            paswordlbl.TabIndex = 15;
            paswordlbl.Text = "Password";
            // 
            // emaillbl
            // 
            emaillbl.AutoSize = true;
            emaillbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            emaillbl.Location = new Point(97, 174);
            emaillbl.Name = "emaillbl";
            emaillbl.Size = new Size(66, 25);
            emaillbl.TabIndex = 14;
            emaillbl.Text = "e-mail";
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernamelbl.Location = new Point(97, 59);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(97, 25);
            usernamelbl.TabIndex = 13;
            usernamelbl.Text = "Username";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(97, 202);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(169, 23);
            emailTextBox.TabIndex = 12;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(97, 142);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(169, 23);
            passwordTextBox.TabIndex = 11;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(97, 87);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(169, 23);
            usernameTextBox.TabIndex = 10;
            // 
            // SignUpBtn
            // 
            SignUpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SignUpBtn.Location = new Point(191, 247);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(85, 37);
            SignUpBtn.TabIndex = 9;
            SignUpBtn.Text = "sign up";
            SignUpBtn.UseVisualStyleBackColor = true;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            backBtn.Location = new Point(87, 247);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(85, 37);
            backBtn.TabIndex = 16;
            backBtn.Text = "back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // RegisterWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 369);
            Controls.Add(backBtn);
            Controls.Add(paswordlbl);
            Controls.Add(emaillbl);
            Controls.Add(usernamelbl);
            Controls.Add(emailTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(SignUpBtn);
            Name = "RegisterWindow";
            Text = "RegisterWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label paswordlbl;
        private Label emaillbl;
        private Label usernamelbl;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Button SignUpBtn;
        private Button backBtn;
    }
}