namespace BAOMATVIDEO.HTN
{
    partial class fEncDecVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEncDecVideo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.media = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btThucHien = new System.Windows.Forms.Button();
            this.lblChonTepTin = new System.Windows.Forms.Label();
            this.rbMaHoa = new System.Windows.Forms.RadioButton();
            this.rbGiaiMa = new System.Windows.Forms.RadioButton();
            this.tbDuongDan = new System.Windows.Forms.TextBox();
            this.btTim = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.media)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.media);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.btThucHien);
            this.panel1.Controls.Add(this.lblChonTepTin);
            this.panel1.Controls.Add(this.rbMaHoa);
            this.panel1.Controls.Add(this.rbGiaiMa);
            this.panel1.Controls.Add(this.tbDuongDan);
            this.panel1.Controls.Add(this.btTim);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 373);
            this.panel1.TabIndex = 10;
            // 
            // media
            // 
            this.media.Enabled = true;
            this.media.Location = new System.Drawing.Point(98, 67);
            this.media.Name = "media";
            this.media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("media.OcxState")));
            this.media.Size = new System.Drawing.Size(390, 239);
            this.media.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(359, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.videoToolStripMenuItem.Text = "Video";
            this.videoToolStripMenuItem.Click += new System.EventHandler(this.videoToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // btThucHien
            // 
            this.btThucHien.Location = new System.Drawing.Point(359, 312);
            this.btThucHien.Name = "btThucHien";
            this.btThucHien.Size = new System.Drawing.Size(75, 23);
            this.btThucHien.TabIndex = 7;
            this.btThucHien.Text = "Thực hiện";
            this.btThucHien.UseVisualStyleBackColor = true;
            this.btThucHien.Click += new System.EventHandler(this.btThucHien_Click);
            // 
            // lblChonTepTin
            // 
            this.lblChonTepTin.AutoSize = true;
            this.lblChonTepTin.Location = new System.Drawing.Point(13, 44);
            this.lblChonTepTin.Name = "lblChonTepTin";
            this.lblChonTepTin.Size = new System.Drawing.Size(54, 13);
            this.lblChonTepTin.TabIndex = 2;
            this.lblChonTepTin.Text = "File Name";
            // 
            // rbMaHoa
            // 
            this.rbMaHoa.AutoSize = true;
            this.rbMaHoa.Location = new System.Drawing.Point(130, 312);
            this.rbMaHoa.Name = "rbMaHoa";
            this.rbMaHoa.Size = new System.Drawing.Size(63, 17);
            this.rbMaHoa.TabIndex = 5;
            this.rbMaHoa.TabStop = true;
            this.rbMaHoa.Text = "Mã Hóa";
            this.rbMaHoa.UseVisualStyleBackColor = true;
            this.rbMaHoa.CheckedChanged += new System.EventHandler(this.rbMaHoa_CheckedChanged_1);
            // 
            // rbGiaiMa
            // 
            this.rbGiaiMa.AutoSize = true;
            this.rbGiaiMa.Location = new System.Drawing.Point(130, 341);
            this.rbGiaiMa.Name = "rbGiaiMa";
            this.rbGiaiMa.Size = new System.Drawing.Size(61, 17);
            this.rbGiaiMa.TabIndex = 6;
            this.rbGiaiMa.TabStop = true;
            this.rbGiaiMa.Text = "Giải Mã";
            this.rbGiaiMa.UseVisualStyleBackColor = true;
            this.rbGiaiMa.CheckedChanged += new System.EventHandler(this.rbGiaiMa_CheckedChanged);
            // 
            // tbDuongDan
            // 
            this.tbDuongDan.Location = new System.Drawing.Point(73, 41);
            this.tbDuongDan.Name = "tbDuongDan";
            this.tbDuongDan.Size = new System.Drawing.Size(510, 20);
            this.tbDuongDan.TabIndex = 3;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(601, 44);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 23);
            this.btTim.TabIndex = 4;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // fEncDecVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 377);
            this.Controls.Add(this.panel1);
            this.Name = "fEncDecVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mã hóa video";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.media)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button btThucHien;
        private System.Windows.Forms.Label lblChonTepTin;
        private System.Windows.Forms.RadioButton rbMaHoa;
        private System.Windows.Forms.RadioButton rbGiaiMa;
        private System.Windows.Forms.TextBox tbDuongDan;
        private System.Windows.Forms.Button btTim;
        private AxWMPLib.AxWindowsMediaPlayer media;
    }
}