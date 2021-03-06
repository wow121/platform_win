﻿namespace platform_win
{
    partial class MainPage
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
            this.main_notice_list = new System.Windows.Forms.ListBox();
            this.main_notice_content = new System.Windows.Forms.TextBox();
            this.main_notice_reload = new System.Windows.Forms.Button();
            this.main_notice_add = new System.Windows.Forms.Button();
            this.main_notice_remove = new System.Windows.Forms.Button();
            this.main_notice_upload = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_notice = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tab_notice.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_notice_list
            // 
            this.main_notice_list.FormattingEnabled = true;
            this.main_notice_list.ItemHeight = 12;
            this.main_notice_list.Location = new System.Drawing.Point(39, 49);
            this.main_notice_list.Name = "main_notice_list";
            this.main_notice_list.Size = new System.Drawing.Size(211, 304);
            this.main_notice_list.TabIndex = 0;
            this.main_notice_list.SelectedIndexChanged += new System.EventHandler(this.main_notice_list_SelectedIndexChanged);
            // 
            // main_notice_content
            // 
            this.main_notice_content.Cursor = System.Windows.Forms.Cursors.No;
            this.main_notice_content.Location = new System.Drawing.Point(407, 47);
            this.main_notice_content.Multiline = true;
            this.main_notice_content.Name = "main_notice_content";
            this.main_notice_content.ReadOnly = true;
            this.main_notice_content.Size = new System.Drawing.Size(199, 304);
            this.main_notice_content.TabIndex = 1;
            // 
            // main_notice_reload
            // 
            this.main_notice_reload.Location = new System.Drawing.Point(273, 47);
            this.main_notice_reload.Name = "main_notice_reload";
            this.main_notice_reload.Size = new System.Drawing.Size(106, 23);
            this.main_notice_reload.TabIndex = 2;
            this.main_notice_reload.Text = "刷新";
            this.main_notice_reload.UseVisualStyleBackColor = true;
            this.main_notice_reload.Click += new System.EventHandler(this.main_notice_reload_Click);
            // 
            // main_notice_add
            // 
            this.main_notice_add.Location = new System.Drawing.Point(273, 94);
            this.main_notice_add.Name = "main_notice_add";
            this.main_notice_add.Size = new System.Drawing.Size(106, 23);
            this.main_notice_add.TabIndex = 3;
            this.main_notice_add.Text = "添加";
            this.main_notice_add.UseVisualStyleBackColor = true;
            this.main_notice_add.Click += new System.EventHandler(this.main_notice_add_Click);
            // 
            // main_notice_remove
            // 
            this.main_notice_remove.Location = new System.Drawing.Point(273, 140);
            this.main_notice_remove.Name = "main_notice_remove";
            this.main_notice_remove.Size = new System.Drawing.Size(106, 23);
            this.main_notice_remove.TabIndex = 4;
            this.main_notice_remove.Text = "删除";
            this.main_notice_remove.UseVisualStyleBackColor = true;
            this.main_notice_remove.Click += new System.EventHandler(this.main_notice_remove_Click);
            // 
            // main_notice_upload
            // 
            this.main_notice_upload.Location = new System.Drawing.Point(273, 189);
            this.main_notice_upload.Name = "main_notice_upload";
            this.main_notice_upload.Size = new System.Drawing.Size(106, 23);
            this.main_notice_upload.TabIndex = 5;
            this.main_notice_upload.Text = "修改";
            this.main_notice_upload.UseVisualStyleBackColor = true;
            this.main_notice_upload.Click += new System.EventHandler(this.main_notice_upload_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_notice);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 394);
            this.tabControl1.TabIndex = 6;
            // 
            // tab_notice
            // 
            this.tab_notice.Controls.Add(this.main_notice_upload);
            this.tab_notice.Controls.Add(this.main_notice_list);
            this.tab_notice.Controls.Add(this.main_notice_remove);
            this.tab_notice.Controls.Add(this.main_notice_content);
            this.tab_notice.Controls.Add(this.main_notice_add);
            this.tab_notice.Controls.Add(this.main_notice_reload);
            this.tab_notice.Location = new System.Drawing.Point(4, 22);
            this.tab_notice.Name = "tab_notice";
            this.tab_notice.Padding = new System.Windows.Forms.Padding(3);
            this.tab_notice.Size = new System.Drawing.Size(647, 368);
            this.tab_notice.TabIndex = 0;
            this.tab_notice.Text = "公告";
            this.tab_notice.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(647, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 399);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.Text = "XXXXX";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_notice.ResumeLayout(false);
            this.tab_notice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox main_notice_list;
        private System.Windows.Forms.TextBox main_notice_content;
        private System.Windows.Forms.Button main_notice_reload;
        private System.Windows.Forms.Button main_notice_add;
        private System.Windows.Forms.Button main_notice_remove;
        private System.Windows.Forms.Button main_notice_upload;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_notice;
        private System.Windows.Forms.TabPage tabPage2;
    }
}