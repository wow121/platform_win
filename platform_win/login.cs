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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = login_username.Text;
            string pw = login_password.Text;
            string url = "http://203.156.196.150/web/login?name="+name+"&password="+pw;
            HttpWebResponse response;
            response=HttpWebResponseUtility.CreateGetHttpResponse(url, null, null, null);
            StreamReader sr = new StreamReader(response.GetResponseStream());
            JObject obj = JObject.Parse(sr.ReadToEnd());
            if ((string)obj["status"] == "200")
            {
             //.   MessageBox.Show("success");
                MainPage pg = new MainPage();
                pg.Show();
                this.Hide();
            }
            else
                MessageBox.Show("账号或密码错误");
        }


       
    }
}
