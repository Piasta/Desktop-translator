using System;
using System.Windows.Forms;
using System.Net;
using System.Runtime.InteropServices;

namespace Desktop_translator
{
    public partial class translateControlPanel : UserControl
    {
        public translateControlPanel()
        {
            InitializeComponent();
        }

        public String Translate(String word)
        {
            var toLanguage = "pl";
            var fromLanguage = "en";

            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={WebUtility.UrlEncode(word)}";
            var webClient = new WebClient
            {
                Encoding = System.Text.Encoding.UTF8
            };
            var result = webClient.DownloadString(url);
            try
            {
                result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                return result;
            }
            catch
            {
                return "Error";
            }
        }

        private void translatetxt_bt_Click(object sender, EventArgs e)
        {
            if (input_rtbx.Text != "")
            {
                output_rtbx.Text = Translate(input_rtbx.Text);
            }
        }

        private void input_rtbx_TextChanged(object sender, EventArgs e)
        {
            if (input_rtbx.Text == "")
            {
                output_rtbx.Text = "";
            }
        }
    }
}

