using OculusPlatformDataRetriever.Properties;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OculusPlatformDataRetriever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public  string GetHttp(string url)
        {
            System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json; charset=UTF-8";
           
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

            string StrResult = reader.ReadToEnd();
            reader.Close();
            responseStream.Close();
            request.Abort();
            response.Close();
            
            return StrResult;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            var AppID = OculusAppIDTxt.Text;
            var AppSecrect = OculusAppSecrectTxt.Text;
            if (string.IsNullOrEmpty(AppID) || string.IsNullOrEmpty(AppSecrect))
            {
                MessageBox.Show(this, "AppID Or AppSecrect Is Empty", "Message");
                return;
            }

                var LeaderboardUrl = $"https://graph.oculus.com/{AppID}/leaderboards?access_token=OC|{AppID}|{AppSecrect}&fields=api_name,sort_order,entry_write_policy,entry_count,score_type";
            var LeaderboardStr = GetHttp(LeaderboardUrl);

            var AchievementUrl = $"https://graph.oculus.com/{AppID}/achievement_definitions/?access_token=OC|{AppID}|{AppSecrect}&fields=api_name,achievement_type,achievement_write_policy,target,bitfield_length,is_archived,title,description,unlocked_description_override,is_secret,locked_image_uri,unlocked_image_uri";
            var AchievementStr = GetHttp(AchievementUrl);

            SaveFileDialog SaveDialog = new SaveFileDialog();
            SaveDialog.FileName = "Data.json";
            SaveDialog.Filter = "Json|*.Json";
            SaveDialog.FilterIndex = 0;
            SaveDialog.RestoreDirectory = true;
            var res = "{\"leaderboard\":" + LeaderboardStr + ",\"achievement\":" + AchievementStr + "}";
            res = Regex.Unescape(res); 
            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {
                //File.WriteAllText(SaveDialog.FileName, res);
                FileStream fileStream = File.Create(SaveDialog.FileName);
                
                byte[] bytes = new UTF8Encoding(true).GetBytes(res);
                fileStream.Write(bytes, 0, bytes.Length);
                fileStream.Close();
                MessageBox.Show(this, "DownLoadSuccess", "Message");
            }
       
        }

        private Settings settings = new Settings();
        private void Form1_Load(object sender, EventArgs e)
        {
           OculusAppIDTxt.Text = settings.AppID;
           OculusAppSecrectTxt.Text = settings.AppSecrect;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.AppID = OculusAppIDTxt.Text;
            settings.AppSecrect = OculusAppSecrectTxt.Text;
            settings.Save();
        }
    }
}
