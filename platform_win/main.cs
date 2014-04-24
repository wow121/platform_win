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
using System.Collections;

namespace platform_win
{
    public partial class MainPage : Form
    {
        JArray jarray;
        public MainPage()
        {
            InitializeComponent();
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            get_user();
            reload();


            
        }
        private void set_button_message()
        {
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
            checkedListBox3.Items.Clear();
            int length = jarray.Count();
            for (int i = 0; i < length; i++)
            {
                JObject obj = (JObject)jarray[i];
                checkedListBox1.Items.Add((string)obj["name"]);
                checkedListBox2.Items.Add((string)obj["name"]);
                checkedListBox3.Items.Add((string)obj["name"]);
            }
        }
        public void reload()
        {
            string url = "http://203.156.196.150/win/get_product";
            HttpWebResponse response;
            response = HttpWebResponseUtility.CreateGetHttpResponse(url, null, null, null);
            StreamReader sr = new StreamReader(response.GetResponseStream());
            jarray = JArray.Parse(sr.ReadToEnd());
            int length = jarray.Count();
            main_notice_list.Items.Clear();
            for (int i = 0; i < length; i++)
            {
                JObject obj = (JObject)jarray[i];

                main_notice_list.Items.Add((string)obj["name"]);
         //       MessageBox.Show(obj.ToString());
            }
            set_button_message();
        }

        private void main_notice_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = main_notice_list.SelectedIndex;
            if (num == -1)
            {
                MessageBox.Show("选择一个进行操作");
            }
            else
            {
                JObject obj = (JObject)jarray[num];
                string content = (string)obj["description"];
                string sku = (string)obj["sku"];

                string pic = (string)obj["pic"];
                main_notice_content.Text = "sku:" + sku + "\r\n" + "description:" + content + "\r\n";
                using (System.Net.WebClient wc = new System.Net.WebClient())
                {
                    wc.Headers.Add("User-Agent", "Chrome");
                    wc.DownloadFile("http://203.156.196.150:999/" + pic, "c:/pic/" + pic);//保存到本地的文件名和路径，请自行更改
                }
                main_pic.ImageLocation = "c:/pic/" + pic;
                main_pic.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        
        private void get_user()
        {
            string url = "http://203.156.196.150/win/get_user_list";
            HttpWebResponse response;
            response = HttpWebResponseUtility.CreateGetHttpResponse(url, null, null, null);
            StreamReader sr = new StreamReader(response.GetResponseStream());
            JArray jarray = JArray.Parse(sr.ReadToEnd());
            int length = jarray.Count();
            for (int i = 0; i < length; i++)
            {
                JObject obj = (JObject)jarray[i];
                string sex = (string)obj["sex"];
                if (sex == "1")
                {
                    sex = "男";
                }
                else if (sex == "2")
                {
                    sex = "女";
                }
                else
                {
                    sex = "未填写";
                }
                long times = (long)obj["subscribe_time"];
                DateTime dt_1970 = new DateTime(1970, 1, 1);
                long tricks_1970 = dt_1970.Ticks;//1970年1月1日刻度
                long time_tricks = tricks_1970 + times * 10000000;//日志日期刻度
                System.DateTime time = new DateTime(time_tricks);

                ListViewItem lvi = new ListViewItem(new string[] { (i + 1).ToString(), (string)obj["openid"], (string)obj["nickname"], sex, (string)obj["city"], (string)obj["province"], (string)obj["country"], time.ToString("d"), (string)obj["headimgurl"] }, -1);
                listView1.Items.Add(lvi);
            }
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
                string url = "http://203.156.196.150/win/remove_product?id=" + id;
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
                string name = (string)obj["name"];
                string description = (string)obj["description"];
                string sku = (string)obj["sku"];
                string pic = (string)obj["pic"];
                Notice notice = new Notice(this, id, name, description,sku,pic);
                notice.Show();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (this.listView1.Columns[e.Column].Tag == null)
                this.listView1.Columns[e.Column].Tag = true;
            bool flag = (bool)this.listView1.Columns[e.Column].Tag;
            if (flag)
                this.listView1.Columns[e.Column].Tag = false;
            else
                this.listView1.Columns[e.Column].Tag = true;
            this.listView1.ListViewItemSorter = new ListViewSort(e.Column, this.listView1.Columns[e.Column].Tag);
            this.listView1.Sort();//对列表进行自定义排序  

        }

        private void send_button_message_Click(object sender, EventArgs e)
        {
            JObject message = new JObject();
            int length = jarray.Count();
            string product_id="";
            for (int i = 0; i < length; i++)
            {

                if (checkedListBox1.GetItemChecked(i))
                {
                    JObject obj = (JObject)jarray[i];
                    string id = (string)obj["id"];
                    product_id += id + ",";
                }
            }
            message.Add("key_a1", product_id);

            product_id = "";
            for (int i = 0; i < length; i++)
            {

                if (checkedListBox3.GetItemChecked(i))
                {
                    JObject obj = (JObject)jarray[i];
                    string id = (string)obj["id"];
                    product_id += id + ",";
                }
            }
            message.Add("key_a2", product_id);


            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("json",message.ToString());
            Encoding encoding = Encoding.GetEncoding("gb2312");
            HttpWebResponse response;
            response = HttpWebResponseUtility.CreatePostHttpResponse("http://203.156.196.150/win/set_button_message", parameters, null, null, encoding, null);
            StreamReader sr = new StreamReader(response.GetResponseStream());
            JObject obj1 = JObject.Parse(sr.ReadToEnd());
            if ((string)obj1["status"] == "200")
            {
                MessageBox.Show("更新成功");
            }
        }

        private void send_voice_message_Click(object sender, EventArgs e)
        {
            JObject message = new JObject();
            
            int length = jarray.Count();
            string product_id = "";
            for (int i = 0; i < length; i++)
            {

                if (checkedListBox2.GetItemChecked(i))
                {
                    JObject obj = (JObject)jarray[i];
                    string id = (string)obj["id"];
                    product_id += id + ",";
                }
            }
            message.Add("id", product_id);
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("json", message.ToString());
            parameters.Add("voice_key", voice_key.Text); 
            Encoding encoding = Encoding.GetEncoding("utf-8");
            HttpWebResponse response;
            response = HttpWebResponseUtility.CreatePostHttpResponse("http://203.156.196.150/win/set_voice_message", parameters, null, null, encoding, null);
            StreamReader sr = new StreamReader(response.GetResponseStream());
            JObject obj1 = JObject.Parse(sr.ReadToEnd());
            if ((string)obj1["status"] == "200")
            {
                MessageBox.Show("更新成功");
            }
        }

        

    }
}
