using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAOMATVIDEO.HTN
{
    public partial class EncDecLinkVideo : Form
    {
        public EncDecLinkVideo()
        {
            InitializeComponent();
        }
        public static string UrlEncodeExtended(string value)
        {
            char[] chars = value.ToCharArray();
            StringBuilder encodedValue = new StringBuilder();
            foreach (char c in chars)
            {
                encodedValue.Append("%" + ((int)c).ToString("X2"));
            }
            return encodedValue.ToString();
        }
        private static string DecodeUrlString(string url)
        {
            string newUrl;
            while ((newUrl = Uri.UnescapeDataString(url)) != url)
                url = newUrl;
            return newUrl;
        }

        private void btnOpenURL_Click(object sender, EventArgs e)
        {
            string url = "https://www.canva.com/p/templates/EAFJi4z6Eps-pink-and-white-cute-playful-kawaii-aesthetic-recording-youtube-intro/"; // URL cần được mở trên trình duyệt.
            Process.Start(url); // Thực hiện mở URL trên trình duyệt.
            if (tbKetQua.Text == "") return;
            lblKetQua.Text = (tbKetQua.Text);

        }
        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            tbKetQua.Text = UrlEncodeExtended(textBox1.Text);
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            tbKetQua.Text = DecodeUrlString(textBox1.Text);
        }
    }
}
