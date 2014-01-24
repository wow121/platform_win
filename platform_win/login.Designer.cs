namespace platform_win
{
    partial class login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.login_confirm = new System.Windows.Forms.Button();
            this.login_text1 = new System.Windows.Forms.Label();
            this.login_text2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_username
            // 
            this.login_username.Location = new System.Drawing.Point(120, 107);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(252, 21);
            this.login_username.TabIndex = 0;
            // 
            // login_password
            // 
            this.login_password.Location = new System.Drawing.Point(120, 156);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(252, 21);
            this.login_password.TabIndex = 1;
            // 
            // login_confirm
            // 
            this.login_confirm.Location = new System.Drawing.Point(296, 268);
            this.login_confirm.Name = "login_confirm";
            this.login_confirm.Size = new System.Drawing.Size(75, 23);
            this.login_confirm.TabIndex = 2;
            this.login_confirm.Text = "登陆";
            this.login_confirm.UseVisualStyleBackColor = true;
            this.login_confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_text1
            // 
            this.login_text1.AutoSize = true;
            this.login_text1.Location = new System.Drawing.Point(45, 115);
            this.login_text1.Name = "login_text1";
            this.login_text1.Size = new System.Drawing.Size(29, 12);
            this.login_text1.TabIndex = 3;
            this.login_text1.Text = "账号";
            // 
            // login_text2
            // 
            this.login_text2.AutoSize = true;
            this.login_text2.Location = new System.Drawing.Point(47, 164);
            this.login_text2.Name = "login_text2";
            this.login_text2.Size = new System.Drawing.Size(29, 12);
            this.login_text2.TabIndex = 4;
            this.login_text2.Text = "密码";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 343);
            this.Controls.Add(this.login_text2);
            this.Controls.Add(this.login_text1);
            this.Controls.Add(this.login_confirm);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_username);
            this.Name = "login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Button login_confirm;
        private System.Windows.Forms.Label login_text1;
        private System.Windows.Forms.Label login_text2;
    }
}

