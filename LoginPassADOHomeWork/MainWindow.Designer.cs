namespace LoginPassADOHomeWork
{
    partial class MainWindow
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
            backBtn = new Button();
            SuspendLayout();
            // 
            // paswordlbl
            // 
            paswordlbl.AutoSize = true;
            paswordlbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            paswordlbl.Location = new Point(96, 98);
            paswordlbl.Name = "paswordlbl";
            paswordlbl.Size = new Size(91, 25);
            paswordlbl.TabIndex = 21;
            paswordlbl.Text = "Password";
            // 
            // emaillbl
            // 
            emaillbl.AutoSize = true;
            emaillbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            emaillbl.Location = new Point(96, 158);
            emaillbl.Name = "emaillbl";
            emaillbl.Size = new Size(66, 25);
            emaillbl.TabIndex = 20;
            emaillbl.Text = "e-mail";
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernamelbl.Location = new Point(96, 43);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(97, 25);
            usernamelbl.TabIndex = 19;
            usernamelbl.Text = "Username";
            // 
            // emailTextBox
            // 
            emailTextBox.Enabled = false;
            emailTextBox.Location = new Point(96, 186);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(169, 23);
            emailTextBox.TabIndex = 18;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Enabled = false;
            passwordTextBox.Location = new Point(96, 126);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(169, 23);
            passwordTextBox.TabIndex = 17;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Enabled = false;
            usernameTextBox.Location = new Point(96, 71);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(169, 23);
            usernameTextBox.TabIndex = 16;
            // 
            // backBtn
            // 
            backBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            backBtn.Location = new Point(228, 255);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(97, 47);
            backBtn.TabIndex = 22;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 370);
            Controls.Add(backBtn);
            Controls.Add(paswordlbl);
            Controls.Add(emaillbl);
            Controls.Add(usernamelbl);
            Controls.Add(emailTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Name = "MainWindow";
            Text = "MainWindow";
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
        private Button backBtn;
    }
}