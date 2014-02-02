using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;


namespace platform_win
{
    
    public partial class Notice : Form
    {
        string id;
        MainPage mainpage;

        public Notice(MainPage mainpage)
        {
            this.mainpage = mainpage;
            InitializeComponent();
            notice_upload.Visible = false;
        }

        public Notice(MainPage mainpage,string id,string title,string content)
        {
            this.mainpage = mainpage;
            this.id=id;
            InitializeComponent();
            notice_confirm.Visible = false;
            notice_title.Text = title;
            notice_content.Text = content;
        }

        private void notice_confirm_Click(object sender, EventArgs e)
        {
            string title = notice_title.Text;
            string content = notice_content.Text;
            string url = "http://203.156.196.150/web/addnotice?title="+title+"&content="+content;
            HttpWebResponse response;
            response = HttpWebResponseUtility.CreateGetHttpResponse(url, null, null, null);
            StreamReader sr = new StreamReader(response.GetResponseStream());
            JObject obj = JObject.Parse(sr.ReadToEnd());
            if ((string)obj["status"] == "200")
            {
                MessageBox.Show("添加成功");
                mainpage.reload();
                this.Close();
            }
        }

        private void notice_upload_Click(object sender, EventArgs e)
        {
            string title = notice_title.Text;
            string content = notice_content.Text;
            string url = "http://203.156.196.150/web/uploadnotice?title=" + title + "&content=" + content+"&id="+id;
            HttpWebResponse response;
            response = HttpWebResponseUtility.CreateGetHttpResponse(url, null, null, null);
            StreamReader sr = new StreamReader(response.GetResponseStream());
            JObject obj = JObject.Parse(sr.ReadToEnd());
            if ((string)obj["status"] == "200")
            {
                MessageBox.Show("修改成功");
                mainpage.reload();
                this.Close();
            }
        }
    }
}
