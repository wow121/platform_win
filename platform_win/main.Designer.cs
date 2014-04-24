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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.main_notice_list = new System.Windows.Forms.ListBox();
            this.main_notice_content = new System.Windows.Forms.TextBox();
            this.main_notice_reload = new System.Windows.Forms.Button();
            this.main_notice_add = new System.Windows.Forms.Button();
            this.main_notice_remove = new System.Windows.Forms.Button();
            this.main_notice_upload = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_product = new System.Windows.Forms.TabPage();
            this.main_pic = new System.Windows.Forms.PictureBox();
            this.tab_user = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nickname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.province = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subscribe_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headimgurl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_button_msg = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.send_button_message = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.send_voice_message = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.voice_key = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tab_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_pic)).BeginInit();
            this.tab_user.SuspendLayout();
            this.tab_button_msg.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_notice_list
            // 
            this.main_notice_list.FormattingEnabled = true;
            this.main_notice_list.ItemHeight = 12;
            this.main_notice_list.Location = new System.Drawing.Point(6, 18);
            this.main_notice_list.Name = "main_notice_list";
            this.main_notice_list.Size = new System.Drawing.Size(315, 460);
            this.main_notice_list.TabIndex = 0;
            this.main_notice_list.SelectedIndexChanged += new System.EventHandler(this.main_notice_list_SelectedIndexChanged);
            // 
            // main_notice_content
            // 
            this.main_notice_content.Cursor = System.Windows.Forms.Cursors.No;
            this.main_notice_content.Location = new System.Drawing.Point(459, 216);
            this.main_notice_content.Multiline = true;
            this.main_notice_content.Name = "main_notice_content";
            this.main_notice_content.ReadOnly = true;
            this.main_notice_content.Size = new System.Drawing.Size(312, 262);
            this.main_notice_content.TabIndex = 1;
            // 
            // main_notice_reload
            // 
            this.main_notice_reload.Location = new System.Drawing.Point(339, 52);
            this.main_notice_reload.Name = "main_notice_reload";
            this.main_notice_reload.Size = new System.Drawing.Size(106, 23);
            this.main_notice_reload.TabIndex = 2;
            this.main_notice_reload.Text = "刷新";
            this.main_notice_reload.UseVisualStyleBackColor = true;
            this.main_notice_reload.Click += new System.EventHandler(this.main_notice_reload_Click);
            // 
            // main_notice_add
            // 
            this.main_notice_add.Location = new System.Drawing.Point(339, 99);
            this.main_notice_add.Name = "main_notice_add";
            this.main_notice_add.Size = new System.Drawing.Size(106, 23);
            this.main_notice_add.TabIndex = 3;
            this.main_notice_add.Text = "添加";
            this.main_notice_add.UseVisualStyleBackColor = true;
            this.main_notice_add.Click += new System.EventHandler(this.main_notice_add_Click);
            // 
            // main_notice_remove
            // 
            this.main_notice_remove.Location = new System.Drawing.Point(339, 145);
            this.main_notice_remove.Name = "main_notice_remove";
            this.main_notice_remove.Size = new System.Drawing.Size(106, 23);
            this.main_notice_remove.TabIndex = 4;
            this.main_notice_remove.Text = "删除";
            this.main_notice_remove.UseVisualStyleBackColor = true;
            this.main_notice_remove.Click += new System.EventHandler(this.main_notice_remove_Click);
            // 
            // main_notice_upload
            // 
            this.main_notice_upload.Location = new System.Drawing.Point(339, 194);
            this.main_notice_upload.Name = "main_notice_upload";
            this.main_notice_upload.Size = new System.Drawing.Size(106, 23);
            this.main_notice_upload.TabIndex = 5;
            this.main_notice_upload.Text = "修改";
            this.main_notice_upload.UseVisualStyleBackColor = true;
            this.main_notice_upload.Click += new System.EventHandler(this.main_notice_upload_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_product);
            this.tabControl1.Controls.Add(this.tab_user);
            this.tabControl1.Controls.Add(this.tab_button_msg);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 516);
            this.tabControl1.TabIndex = 6;
            // 
            // tab_product
            // 
            this.tab_product.Controls.Add(this.main_pic);
            this.tab_product.Controls.Add(this.main_notice_upload);
            this.tab_product.Controls.Add(this.main_notice_list);
            this.tab_product.Controls.Add(this.main_notice_remove);
            this.tab_product.Controls.Add(this.main_notice_content);
            this.tab_product.Controls.Add(this.main_notice_add);
            this.tab_product.Controls.Add(this.main_notice_reload);
            this.tab_product.Location = new System.Drawing.Point(4, 22);
            this.tab_product.Name = "tab_product";
            this.tab_product.Padding = new System.Windows.Forms.Padding(3);
            this.tab_product.Size = new System.Drawing.Size(805, 490);
            this.tab_product.TabIndex = 0;
            this.tab_product.Text = "产品管理";
            this.tab_product.UseVisualStyleBackColor = true;
            // 
            // main_pic
            // 
            this.main_pic.Image = ((System.Drawing.Image)(resources.GetObject("main_pic.Image")));
            this.main_pic.Location = new System.Drawing.Point(459, 18);
            this.main_pic.Name = "main_pic";
            this.main_pic.Size = new System.Drawing.Size(312, 174);
            this.main_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.main_pic.TabIndex = 6;
            this.main_pic.TabStop = false;
            // 
            // tab_user
            // 
            this.tab_user.Controls.Add(this.listView1);
            this.tab_user.Location = new System.Drawing.Point(4, 22);
            this.tab_user.Name = "tab_user";
            this.tab_user.Padding = new System.Windows.Forms.Padding(3);
            this.tab_user.Size = new System.Drawing.Size(805, 490);
            this.tab_user.TabIndex = 1;
            this.tab_user.Text = "用户信息";
            this.tab_user.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.openid,
            this.nickname,
            this.sex,
            this.city,
            this.province,
            this.country,
            this.subscribe_time,
            this.headimgurl});
            this.listView1.Location = new System.Drawing.Point(0, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(805, 462);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "编号";
            // 
            // openid
            // 
            this.openid.Text = "关注者id";
            this.openid.Width = 200;
            // 
            // nickname
            // 
            this.nickname.Text = "昵称";
            // 
            // sex
            // 
            this.sex.Text = "性别";
            // 
            // city
            // 
            this.city.Text = "城市";
            // 
            // province
            // 
            this.province.Text = "省份";
            // 
            // country
            // 
            this.country.Text = "国家";
            // 
            // subscribe_time
            // 
            this.subscribe_time.Text = "关注时间";
            this.subscribe_time.Width = 100;
            // 
            // headimgurl
            // 
            this.headimgurl.Text = "头像url";
            this.headimgurl.Width = 0;
            // 
            // tab_button_msg
            // 
            this.tab_button_msg.Controls.Add(this.label3);
            this.tab_button_msg.Controls.Add(this.checkedListBox3);
            this.tab_button_msg.Controls.Add(this.send_button_message);
            this.tab_button_msg.Controls.Add(this.label1);
            this.tab_button_msg.Controls.Add(this.checkedListBox1);
            this.tab_button_msg.Location = new System.Drawing.Point(4, 22);
            this.tab_button_msg.Name = "tab_button_msg";
            this.tab_button_msg.Padding = new System.Windows.Forms.Padding(3);
            this.tab_button_msg.Size = new System.Drawing.Size(805, 490);
            this.tab_button_msg.TabIndex = 2;
            this.tab_button_msg.Text = "按键消息回复";
            this.tab_button_msg.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "按键2";
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Location = new System.Drawing.Point(296, 61);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(204, 276);
            this.checkedListBox3.TabIndex = 3;
            // 
            // send_button_message
            // 
            this.send_button_message.Location = new System.Drawing.Point(330, 419);
            this.send_button_message.Name = "send_button_message";
            this.send_button_message.Size = new System.Drawing.Size(75, 23);
            this.send_button_message.TabIndex = 2;
            this.send_button_message.Text = "发送";
            this.send_button_message.UseVisualStyleBackColor = true;
            this.send_button_message.Click += new System.EventHandler(this.send_button_message_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "按键1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(49, 61);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(174, 276);
            this.checkedListBox1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.send_voice_message);
            this.tabPage1.Controls.Add(this.checkedListBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.voice_key);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(805, 490);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "语音消息回复";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // send_voice_message
            // 
            this.send_voice_message.Location = new System.Drawing.Point(154, 427);
            this.send_voice_message.Name = "send_voice_message";
            this.send_voice_message.Size = new System.Drawing.Size(75, 23);
            this.send_voice_message.TabIndex = 3;
            this.send_voice_message.Text = "发送";
            this.send_voice_message.UseVisualStyleBackColor = true;
            this.send_voice_message.Click += new System.EventHandler(this.send_voice_message_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(25, 84);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(204, 324);
            this.checkedListBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "语音回复";
            // 
            // voice_key
            // 
            this.voice_key.Location = new System.Drawing.Point(82, 43);
            this.voice_key.Name = "voice_key";
            this.voice_key.Size = new System.Drawing.Size(147, 21);
            this.voice_key.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(805, 490);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 530);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.Text = "XXXXX";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_product.ResumeLayout(false);
            this.tab_product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_pic)).EndInit();
            this.tab_user.ResumeLayout(false);
            this.tab_button_msg.ResumeLayout(false);
            this.tab_button_msg.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.TabPage tab_product;
        private System.Windows.Forms.TabPage tab_user;
        private System.Windows.Forms.PictureBox main_pic;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader openid;
        private System.Windows.Forms.ColumnHeader nickname;
        private System.Windows.Forms.ColumnHeader sex;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.ColumnHeader province;
        private System.Windows.Forms.ColumnHeader country;
        private System.Windows.Forms.ColumnHeader subscribe_time;
        private System.Windows.Forms.ColumnHeader headimgurl;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.TabPage tab_button_msg;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button send_button_message;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox voice_key;
        private System.Windows.Forms.Button send_voice_message;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
    }
}