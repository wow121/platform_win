namespace platform_win
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
            this.SuspendLayout();
            // 
            // main_notice_list
            // 
            this.main_notice_list.FormattingEnabled = true;
            this.main_notice_list.ItemHeight = 12;
            this.main_notice_list.Location = new System.Drawing.Point(44, 73);
            this.main_notice_list.Name = "main_notice_list";
            this.main_notice_list.Size = new System.Drawing.Size(211, 304);
            this.main_notice_list.TabIndex = 0;
            this.main_notice_list.SelectedIndexChanged += new System.EventHandler(this.main_notice_list_SelectedIndexChanged);
            // 
            // main_notice_content
            // 
            this.main_notice_content.Cursor = System.Windows.Forms.Cursors.No;
            this.main_notice_content.Location = new System.Drawing.Point(409, 73);
            this.main_notice_content.Multiline = true;
            this.main_notice_content.Name = "main_notice_content";
            this.main_notice_content.ReadOnly = true;
            this.main_notice_content.Size = new System.Drawing.Size(199, 304);
            this.main_notice_content.TabIndex = 1;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 490);
            this.Controls.Add(this.main_notice_content);
            this.Controls.Add(this.main_notice_list);
            this.Name = "MainPage";
            this.Text = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox main_notice_list;
        private System.Windows.Forms.TextBox main_notice_content;
    }
}