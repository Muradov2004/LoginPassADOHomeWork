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
            this.paswordlbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paswordlbl
            // 
            this.paswordlbl.AutoSize = true;
            this.paswordlbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paswordlbl.Location = new System.Drawing.Point(96, 98);
            this.paswordlbl.Name = "paswordlbl";
            this.paswordlbl.Size = new System.Drawing.Size(91, 25);
            this.paswordlbl.TabIndex = 21;
            this.paswordlbl.Text = "Password";
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emaillbl.Location = new System.Drawing.Point(96, 158);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(66, 25);
            this.emaillbl.TabIndex = 20;
            this.emaillbl.Text = "e-mail";
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernamelbl.Location = new System.Drawing.Point(96, 43);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(97, 25);
            this.usernamelbl.TabIndex = 19;
            this.usernamelbl.Text = "Username";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(96, 186);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(169, 23);
            this.emailTextBox.TabIndex = 18;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Enabled = false;
            this.passwordTextBox.Location = new System.Drawing.Point(96, 126);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(169, 23);
            this.passwordTextBox.TabIndex = 17;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Enabled = false;
            this.usernameTextBox.Location = new System.Drawing.Point(96, 71);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(169, 23);
            this.usernameTextBox.TabIndex = 16;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(228, 255);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(97, 47);
            this.backBtn.TabIndex = 22;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 370);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.paswordlbl);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

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