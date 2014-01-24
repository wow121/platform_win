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
            string url = "http://203.156.196.150/web/getnotice";
            HttpWebResponse response;
            response = HttpWebResponseUtility.CreateGetHttpResponse(url, null, null, null);
            StreamReader sr = new StreamReader(response.GetResponseStream());
            jarray= JArray.Parse(sr.ReadToEnd());
            int length=jarray.Count();
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
    }
}
