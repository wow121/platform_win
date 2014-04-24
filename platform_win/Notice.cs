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
        string FileName;

        public Notice(MainPage mainpage)
        {
            this.mainpage = mainpage;
            InitializeComponent();
            notice_upload.Visible = false;
        }

        public Notice(MainPage mainpage, string id, string name, string description, string sku, string pic )
        {
            this.mainpage = mainpage;
            this.id=id;
            InitializeComponent();
            notice_confirm.Visible = false;
            notice_title.Text = name;
            notice_content.Text = description;
            notice_sku.Text=sku;
            FileName = "c:/pic/" + pic;
            notice_pic.ImageLocation =FileName;
            notice_pic.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void notice_confirm_Click(object sender, EventArgs e)
        {
            string name = notice_title.Text;
            string description = notice_content.Text;
            string sku = notice_sku.Text;
            
            string url = "http://203.156.196.150/win/add_product?name=" + name + "&description=" + description+ "&sku="+sku;
            if (FileName == null)
            {
                MessageBox.Show("请选择一张图片");
            }
            else
            {
                using (System.Net.WebClient wc = new System.Net.WebClient())
                {
                    
                    wc.Headers.Add("User-Agent", "Chrome");
                    byte[] responseData =wc.UploadFile(url, FileName);
                    string srcString = Encoding.UTF8.GetString(responseData);
                    JObject obj = JObject.Parse(srcString);
                    if ((string)obj["status"] == "200")
                    {
                        MessageBox.Show("添加成功");
                        mainpage.reload();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show((string)obj["error"]);
                    }
                }
            }
            /*
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
             */
        }

        private void notice_upload_Click(object sender, EventArgs e)
        {
            string name = notice_title.Text;
            string description = notice_content.Text;
            string sku = notice_sku.Text;
            string url = "http://203.156.196.150/win/upload_product?name=" + name + "&description=" + description + "&sku=" + sku + "&id=" + id;
            if (FileName == null)
            {
                MessageBox.Show("请选择一张图片");
            }
            else
            {
                using (System.Net.WebClient wc = new System.Net.WebClient())
                {
                    wc.Headers.Add("User-Agent", "Chrome");
                    byte[] responseData = wc.UploadFile(url, FileName);
                    string srcString = Encoding.UTF8.GetString(responseData);
                    JObject obj = JObject.Parse(srcString);
                    if ((string)obj["status"] == "200")
                    {
                        MessageBox.Show("修改成功");
                        mainpage.reload();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show((string)obj["error"]);
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void notice_btn_pic_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog1.Filter = "jpg文件(*.jpg)|*.jpg|gif文件(*.gif)|*.gif|png文件(*.png)|*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.FileName = openFileDialog1.FileName;
                notice_pic.ImageLocation= this.FileName;
                notice_pic.SizeMode = PictureBoxSizeMode.Zoom;
            }

           
        }
    }
}
