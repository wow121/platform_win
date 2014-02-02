using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

namespace platform_win
{
    public partial class MainPage : Form
    {
        JArray jarray;
        public MainPage()
        {
            InitializeComponent();
        }

        public void reload()
        {
            string url = "http://203.156.196.150/web/getnotice";
            HttpWebResponse response;
            response = HttpWebResponseUtility.CreateGetHttpResponse(url, null, null, null);
            StreamReader sr = new StreamReader(response.GetResponseStream());
            jarray = JArray.Parse(sr.ReadToEnd());
            int length = jarray.Count();
            main_notice_list.Items.Clear();
            for (int i = 0; i < length; i++)
            {
                JObject obj = (JObject)jarray[i];

                main_notice_list.Items.Add((string)obj["title"]);
            }
        }

        private void main_notice_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = main_notice_list.SelectedIndex;
            JObject obj =(JObject)jarray[num];
            string content=(string)obj["content"];
            main_notice_content.Text = content;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void main_notice_reload_Click(object sender, EventArgs e)
        {
            reload();
            MessageBox.Show("刷新成功");
        }

        private void main_notice_add_Click(object sender, EventArgs e)
        {
            Notice notice = new Notice(this);
            notice.Show();
        }
        

        private void main_notice_remove_Click(object sender, EventArgs e)
        {

            int num = main_notice_list.SelectedIndex;
            if (num == -1)
            {
                MessageBox.Show("选择一个进行操作");
            }
            else
            {
                JObject obj = (JObject)jarray[num];
                string id = (string)obj["id"];
                string url = "http://203.156.196.150/web/rmnotice?id=" + id;
                HttpWebResponse response;
                response = HttpWebResponseUtility.CreateGetHttpResponse(url, null, null, null);
                StreamReader sr = new StreamReader(response.GetResponseStream());
                JObject obj1 = JObject.Parse(sr.ReadToEnd());
                if ((string)obj1["status"] == "200")
                {
                    MessageBox.Show("删除成功");
                }
                reload();
            }
        }

        private void main_notice_upload_Click(object sender, EventArgs e)
        {

            int num = main_notice_list.SelectedIndex;
            if (num == -1)
            {
                MessageBox.Show("选择一个进行操作");
            }
            else
            {

                JObject obj = (JObject)jarray[num];
                string id = (string)obj["id"];
                string content = (string)obj["content"];
                string title = (string)obj["title"];
                Notice notice = new Notice(this, id, title, content);
                notice.Show();
            }
        }

    }
}
