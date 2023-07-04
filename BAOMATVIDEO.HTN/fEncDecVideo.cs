using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;

namespace BAOMATVIDEO.HTN
{
    public partial class fEncDecVideo : Form
    {    

        public fEncDecVideo()
        {
            InitializeComponent();
        }

        public class EncDec
        {

            public static void EncryptAudio(string inputFilePath, string outputFilePath, byte[] key, byte[] iv)
            {
                using (var inputStream = new WaveFileReader(inputFilePath))
                {
                    using (var outputStream = new FileStream(outputFilePath, FileMode.Create))
                    {
                        var aes = new AesManaged();
                        aes.Key = key;
                        aes.IV = iv;

                        using (var cryptoStream = new CryptoStream(outputStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            var buffer = new byte[1024];
                            int bytesRead;

                            while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                cryptoStream.Write(buffer, 0, bytesRead);
                            }
                        }
                    }
                }
            }

            private byte[] Encrypt(byte[] clearText, byte[] Key, byte[] IV)
            {
                MemoryStream ms = new MemoryStream();
                Rijndael alg = Rijndael.Create();
                alg.Key = Key;
                alg.IV = IV;
                CryptoStream cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);
                cs.Write(clearText, 0, clearText.Length);
                cs.Close();
                byte[] encryptedData = ms.ToArray();
                return encryptedData;
            }

            public string Encrypt(string clearText, string Password)
            {
                byte[] clearBytes = System.Text.Encoding.Unicode.GetBytes(clearText);
                PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                byte[] encryptedData = Encrypt(clearBytes, pdb.GetBytes(32), pdb.GetBytes(16));
                return Convert.ToBase64String(encryptedData);
            }

            private byte[] Decrypt(byte[] cipherData, byte[] Key, byte[] IV)
            {
                MemoryStream ms = new MemoryStream();
                Rijndael alg = Rijndael.Create();
                alg.Key = Key;
                alg.IV = IV;
                CryptoStream cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);
                cs.Write(cipherData, 0, cipherData.Length);
                cs.Close();
                byte[] decryptedData = ms.ToArray();
                return decryptedData;
            }

            public string Decrypt(string cipherText, string Password)
            {
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                byte[] decryptedData = Decrypt(cipherBytes, pdb.GetBytes(32), pdb.GetBytes(16));
                return System.Text.Encoding.Unicode.GetString(decryptedData);
            }
        }
        private void btn_encrypt_Click(object sender, EventArgs e)
        {

            GCHandle gch = GCHandle.Alloc(GCHandleType.Pinned);

            if (media.Text == "") return;
            media.Text = (media.Text);
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK)
            {
                tbDuongDan.Text = od.FileName;
            }
        }

        private void rbGiaiMa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGiaiMa.Checked)
                rbMaHoa.Checked = false;
        }

        private void btThucHien_Click(object sender, EventArgs e)
        {
            var process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C ffmpeg -i input.mp4 -c:v libx264 -preset slow -crf 22 -c:a copy output.mp4";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            process.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();
        }

        private void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                Console.WriteLine(outLine.Data);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Audio Files (*.wav)|*.wav";
            saveFileDialog.Title = " Select an audio file";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {                
                saveFileDialog.Filter = "Encrypted Audio Files (*.enc)|*.enc|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save the audio file";
                var key = new byte[] { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF };
                var iv = new byte[] { 0xFE, 0xDC, 0xBA, 0x98, 0x76, 0x54, 0x32, 0x10 };
                using (var streamWriter = new StreamWriter(saveFileDialog.FileName))
                {
                    streamWriter.WriteLine(txtContent.enc);
                }
            }
        }
        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                media.URL = open.FileName;
                WMPLib.IWMPPlaylist playlist = media.newPlaylist("My playlish", string.Empty);
                foreach (string file in open.FileNames)
                {
                    WMPLib.IWMPMedia pmedia = media.newMedia(file);
                    playlist.appendItem(pmedia);

                }
                media.currentPlaylist = playlist;
                media.Ctlcontrols.play();

            }
           
        }

        private void rbMaHoa_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbMaHoa.Checked)
                rbGiaiMa.Checked = false;
        }
    }
}
