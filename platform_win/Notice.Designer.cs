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
            this.notice_sku = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notice_pic = new System.Windows.Forms.PictureBox();
            this.notice_btn_pic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notice_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // notice_title
            // 
            this.notice_title.Location = new System.Drawing.Point(251, 81);
            this.notice_title.Name = "notice_title";
            this.notice_title.Size = new System.Drawing.Size(196, 21);
            this.notice_title.TabIndex = 0;
            // 
            // notice_confirm
            // 
            this.notice_confirm.Location = new System.Drawing.Point(372, 22);
            this.notice_confirm.Name = "notice_confirm";
            this.notice_confirm.Size = new System.Drawing.Size(75, 23);
            this.notice_confirm.TabIndex = 1;
            this.notice_confirm.Text = "添加";
            this.notice_confirm.UseVisualStyleBackColor = true;
            this.notice_confirm.Click += new System.EventHandler(this.notice_confirm_Click);
            // 
            // notice_content
            // 
            this.notice_content.Location = new System.Drawing.Point(71, 239);
            this.notice_content.Multiline = true;
            this.notice_content.Name = "notice_content";
            this.notice_content.Size = new System.Drawing.Size(376, 147);
            this.notice_content.TabIndex = 2;
            // 
            // notice_upload
            // 
            this.notice_upload.Location = new System.Drawing.Point(372, 22);
            this.notice_upload.Name = "notice_upload";
            this.notice_upload.Size = new System.Drawing.Size(75, 23);
            this.notice_upload.TabIndex = 3;
            this.notice_upload.Text = "修改";
            this.notice_upload.UseVisualStyleBackColor = true;
            this.notice_upload.Click += new System.EventHandler(this.notice_upload_Click);
            // 
            // notice_sku
            // 
            this.notice_sku.Location = new System.Drawing.Point(251, 133);
            this.notice_sku.Name = "notice_sku";
            this.notice_sku.Size = new System.Drawing.Size(196, 21);
            this.notice_sku.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "名字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "sku";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "描述";
            // 
            // notice_pic
            // 
            this.notice_pic.Location = new System.Drawing.Point(21, 22);
            this.notice_pic.Name = "notice_pic";
            this.notice_pic.Size = new System.Drawing.Size(157, 135);
            this.notice_pic.TabIndex = 8;
            this.notice_pic.TabStop = false;
            // 
            // notice_btn_pic
            // 
            this.notice_btn_pic.Location = new System.Drawing.Point(92, 163);
            this.notice_btn_pic.Name = "notice_btn_pic";
            this.notice_btn_pic.Size = new System.Drawing.Size(86, 23);
            this.notice_btn_pic.TabIndex = 9;
            this.notice_btn_pic.Text = "上传图片...";
            this.notice_btn_pic.UseVisualStyleBackColor = true;
            this.notice_btn_pic.Click += new System.EventHandler(this.notice_btn_pic_Click);
            // 
            // Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 482);
            this.Controls.Add(this.notice_btn_pic);
            this.Controls.Add(this.notice_pic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notice_sku);
            this.Controls.Add(this.notice_upload);
            this.Controls.Add(this.notice_content);
            this.Controls.Add(this.notice_confirm);
            this.Controls.Add(this.notice_title);
            this.Name = "Notice";
            this.Text = "Notice";
            ((System.ComponentModel.ISupportInitialize)(this.notice_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox notice_title;
        private System.Windows.Forms.Button notice_confirm;
        private System.Windows.Forms.TextBox notice_content;
        private System.Windows.Forms.Button notice_upload;
        private System.Windows.Forms.TextBox notice_sku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox notice_pic;
        private System.Windows.Forms.Button notice_btn_pic;
    }
}