namespace BAOMATVIDEO.HTN
{
    partial class EncDecLinkVideo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_short_link = new System.Windows.Forms.LinkLabel();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_decrypt);
            this.panel1.Controls.Add(this.btn_encrypt);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 301);
            this.panel1.TabIndex = 9;
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(570, 198);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(75, 31);
            this.btn_decrypt.TabIndex = 12;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(207, 198);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(75, 31);
            this.btn_encrypt.TabIndex = 11;
            this.btn_encrypt.Text = "Encrypt";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_short_link);
            this.panel3.Controls.Add(this.lblKetQua);
            this.panel3.Controls.Add(this.tbKetQua);
            this.panel3.Location = new System.Drawing.Point(3, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(710, 142);
            this.panel3.TabIndex = 10;
            // 
            // lbl_short_link
            // 
            this.lbl_short_link.AutoSize = true;
            this.lbl_short_link.Location = new System.Drawing.Point(117, 11);
            this.lbl_short_link.Name = "lbl_short_link";
            this.lbl_short_link.Size = new System.Drawing.Size(0, 13);
            this.lbl_short_link.TabIndex = 8;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(3, 11);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(52, 13);
            this.lblKetQua.TabIndex = 2;
            this.lblKetQua.Text = "Kết Quả :";
            // 
            // tbKetQua
            // 
            this.tbKetQua.Location = new System.Drawing.Point(106, 4);
            this.tbKetQua.Multiline = true;
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.Size = new System.Drawing.Size(596, 135);
            this.tbKetQua.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 32);
            this.panel2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(596, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuỗi nguồn:";
            // 
            // EncDecLinkVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 308);
            this.Controls.Add(this.panel1);
            this.Name = "EncDecLinkVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncDecLinkVideo";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel lbl_short_link;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox tbKetQua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}