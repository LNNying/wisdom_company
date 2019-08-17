namespace ShowScreen
{
    partial class frmCmlyd1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCmlyd1));
            this.picEye = new System.Windows.Forms.PictureBox();
            this.picEye2 = new System.Windows.Forms.PictureBox();
            this.picEye3 = new System.Windows.Forms.PictureBox();
            this.picEye4 = new System.Windows.Forms.PictureBox();
            this.axplayerPPT = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEye2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEye3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEye4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axplayerPPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // picEye
            // 
            this.picEye.BackColor = System.Drawing.Color.Black;
            this.picEye.Location = new System.Drawing.Point(745, 458);
            this.picEye.Name = "picEye";
            this.picEye.Size = new System.Drawing.Size(563, 135);
            this.picEye.TabIndex = 4;
            this.picEye.TabStop = false;
            this.picEye.DoubleClick += new System.EventHandler(this.picEye_DoubleClick);
            // 
            // picEye2
            // 
            this.picEye2.BackColor = System.Drawing.Color.Black;
            this.picEye2.Location = new System.Drawing.Point(745, 599);
            this.picEye2.Name = "picEye2";
            this.picEye2.Size = new System.Drawing.Size(185, 120);
            this.picEye2.TabIndex = 5;
            this.picEye2.TabStop = false;
            this.picEye2.DoubleClick += new System.EventHandler(this.picEye2_DoubleClick);
            // 
            // picEye3
            // 
            this.picEye3.BackColor = System.Drawing.Color.Black;
            this.picEye3.Location = new System.Drawing.Point(936, 599);
            this.picEye3.Name = "picEye3";
            this.picEye3.Size = new System.Drawing.Size(186, 120);
            this.picEye3.TabIndex = 6;
            this.picEye3.TabStop = false;
            this.picEye3.DoubleClick += new System.EventHandler(this.picEye3_DoubleClick);
            // 
            // picEye4
            // 
            this.picEye4.BackColor = System.Drawing.Color.Black;
            this.picEye4.Location = new System.Drawing.Point(1128, 599);
            this.picEye4.Name = "picEye4";
            this.picEye4.Size = new System.Drawing.Size(180, 120);
            this.picEye4.TabIndex = 7;
            this.picEye4.TabStop = false;
            this.picEye4.DoubleClick += new System.EventHandler(this.picEye4_DoubleClick);
            // 
            // axplayerPPT
            // 
            this.axplayerPPT.Enabled = true;
            this.axplayerPPT.Location = new System.Drawing.Point(41, 36);
            this.axplayerPPT.Name = "axplayerPPT";
            this.axplayerPPT.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axplayerPPT.OcxState")));
            this.axplayerPPT.Size = new System.Drawing.Size(600, 338);
            this.axplayerPPT.TabIndex = 8;
            this.axplayerPPT.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axplayerPPT_PlayStateChange);
            this.axplayerPPT.DoubleClickEvent += new AxWMPLib._WMPOCXEvents_DoubleClickEventHandler(this.axplayerPPT_DoubleClickEvent);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(745, 36);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(563, 338);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.DoubleClickEvent += new AxWMPLib._WMPOCXEvents_DoubleClickEventHandler(this.axWindowsMediaPlayer1_DoubleClickEvent);
            // 
            // frmCmlyd1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShowScreen.Resource1.cmlyd1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.axplayerPPT);
            this.Controls.Add(this.picEye4);
            this.Controls.Add(this.picEye3);
            this.Controls.Add(this.picEye2);
            this.Controls.Add(this.picEye);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCmlyd1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCmlyd1_Load);
            this.Shown += new System.EventHandler(this.frmCmlyd1_Shown);
            this.Resize += new System.EventHandler(this.frmCmlyd1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEye2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEye3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEye4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axplayerPPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox picEye;
        private System.Windows.Forms.PictureBox picEye2;
        private System.Windows.Forms.PictureBox picEye3;
        private System.Windows.Forms.PictureBox picEye4;
        private AxWMPLib.AxWindowsMediaPlayer axplayerPPT;
    }
}