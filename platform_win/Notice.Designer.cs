namespace platform_win
{
    partial class Notice
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
            this.notice_title = new System.Windows.Forms.TextBox();
            this.notice_confirm = new System.Windows.Forms.Button();
            this.notice_content = new System.Windows.Forms.TextBox();
            this.notice_upload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notice_title
            // 
            this.notice_title.Location = new System.Drawing.Point(42, 60);
            this.notice_title.Name = "notice_title";
            this.notice_title.Size = new System.Drawing.Size(376, 21);
            this.notice_title.TabIndex = 0;
            // 
            // notice_confirm
            // 
            this.notice_confirm.Location = new System.Drawing.Point(343, 22);
            this.notice_confirm.Name = "notice_confirm";
            this.notice_confirm.Size = new System.Drawing.Size(75, 23);
            this.notice_confirm.TabIndex = 1;
            this.notice_confirm.Text = "添加";
            this.notice_confirm.UseVisualStyleBackColor = true;
            this.notice_confirm.Click += new System.EventHandler(this.notice_confirm_Click);
            // 
            // notice_content
            // 
            this.notice_content.Location = new System.Drawing.Point(42, 108);
            this.notice_content.Multiline = true;
            this.notice_content.Name = "notice_content";
            this.notice_content.Size = new System.Drawing.Size(376, 318);
            this.notice_content.TabIndex = 2;
            // 
            // notice_upload
            // 
            this.notice_upload.Location = new System.Drawing.Point(343, 22);
            this.notice_upload.Name = "notice_upload";
            this.notice_upload.Size = new System.Drawing.Size(75, 23);
            this.notice_upload.TabIndex = 3;
            this.notice_upload.Text = "修改";
            this.notice_upload.UseVisualStyleBackColor = true;
            this.notice_upload.Click += new System.EventHandler(this.notice_upload_Click);
            // 
            // Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 482);
            this.Controls.Add(this.notice_upload);
            this.Controls.Add(this.notice_content);
            this.Controls.Add(this.notice_confirm);
            this.Controls.Add(this.notice_title);
            this.Name = "Notice";
            this.Text = "Notice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox notice_title;
        private System.Windows.Forms.Button notice_confirm;
        private System.Windows.Forms.TextBox notice_content;
        private System.Windows.Forms.Button notice_upload;
    }
}