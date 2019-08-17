using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShowScreen
{
    public partial class frmCmlyd1 : Form
    {
        int defaultWidth = 1366;
        int defaultHeight = 768;

        public frmCmlyd1()
        {
            InitializeComponent();

            this.Width = this.defaultWidth;
            this.Height = this.defaultHeight;
        }

        private bool eyefullscreen = false;
        private int eyewidth = 0;
        private int eyeheight = 0;
        private int eyeX = 0;
        private int eyeY = 0;

        private bool eyefullscreen2 = false;
        private int eyewidth2 = 0;
        private int eyeheight2 = 0;
        private int eyeX2 = 0;
        private int eyeY2 = 0;

        private bool eyefullscreen3 = false;
        private int eyewidth3 = 0;
        private int eyeheight3 = 0;
        private int eyeX3 = 0;
        private int eyeY3 = 0;

        private bool eyefullscreen4 = false;
        private int eyewidth4 = 0;
        private int eyeheight4 = 0;
        private int eyeX4 = 0;
        private int eyeY4 = 0;

        /// <summary>
        /// 初始化参数
        /// </summary>
        private void InitParm()
        {
            //一号鹰眼
            if (System.Configuration.ConfigurationManager.AppSettings["EyeIP"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyeIP"].ToString().Trim() != "")
            {
                eye_ip = System.Configuration.ConfigurationManager.AppSettings["EyeIP"].ToString().Trim();
            }

            if (System.Configuration.ConfigurationManager.AppSettings["EyeUser"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyeUser"].ToString().Trim() != "")
            {
                eye_userid = System.Configuration.ConfigurationManager.AppSettings["EyeUser"].ToString().Trim();
            }

            if (System.Configuration.ConfigurationManager.AppSettings["EyePort"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyePort"].ToString().Trim() != "")
            {
                eye_port = System.Configuration.ConfigurationManager.AppSettings["EyePort"].ToString().Trim();
            }

            if (System.Configuration.ConfigurationManager.AppSettings["EyePwd"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyePwd"].ToString().Trim() != "")
            {
                eye_pwd = System.Configuration.ConfigurationManager.AppSettings["EyePwd"].ToString().Trim();
            }

            if (System.Configuration.ConfigurationManager.AppSettings["EyeChannel"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyeChannel"].ToString().Trim() != "")
            {
                eye_Channel = System.Configuration.ConfigurationManager.AppSettings["EyeChannel"].ToString().Trim();
            }

            //二号鹰眼
            if (System.Configuration.ConfigurationManager.AppSettings["EyeIP2"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyeIP2"].ToString().Trim() != "")
            {
                eye_ip2 = System.Configuration.ConfigurationManager.AppSettings["EyeIP2"].ToString().Trim();
            }

            if (System.Configuration.ConfigurationManager.AppSettings["EyeUser2"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyeUser2"].ToString().Trim() != "")
            {
                eye_userid2 = System.Configuration.ConfigurationManager.AppSettings["EyeUser2"].ToString().Trim();
            }

            if (System.Configuration.ConfigurationManager.AppSettings["EyePort2"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyePort2"].ToString().Trim() != "")
            {
                eye_port2 = System.Configuration.ConfigurationManager.AppSettings["EyePort2"].ToString().Trim();
            }

            if (System.Configuration.ConfigurationManager.AppSettings["EyePwd2"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyePwd2"].ToString().Trim() != "")
            {
                eye_pwd2 = System.Configuration.ConfigurationManager.AppSettings["EyePwd2"].ToString().Trim();
            }

            if (System.Configuration.ConfigurationManager.AppSettings["EyeChannel2"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyeChannel2"].ToString().Trim() != "")
            {
                eye_Channel2 = System.Configuration.ConfigurationManager.AppSettings["EyeChannel2"].ToString().Trim();
            }

            //三号鹰眼
            if (System.Configuration.ConfigurationManager.AppSettings["EyeIP3"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyeIP3"].ToString().Trim() != "")
            {
                eye_ip3 = System.Configuration.ConfigurationManager.AppSettings["EyeIP3"].ToString().Trim();
            }

            if (System.Configuration.ConfigurationManager.AppSettings["EyeUser3"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyeUser3"].ToString().Trim() != "")
            {
                eye_userid3 = System.Configuration.ConfigurationManager.AppSettings["EyeUser3"].ToString().Trim();
            }

            if (System.Configuration.ConfigurationManager.AppSettings["EyePort3"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyePort3"].ToString().Trim() != "")
            {
                eye_port3 = System.Configuration.ConfigurationManager.AppSettings["EyePort3"].ToString().Trim();
            }

            if (System.Configuration.ConfigurationManager.AppSettings["EyePwd3"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyePwd3"].ToString().Trim() != "")
            {
                eye_pwd3 = System.Configuration.ConfigurationManager.AppSettings["EyePwd3"].ToString().Trim();
            }

            if (System.Configuration.ConfigurationManager.AppSettings["EyeChannel3"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyeChannel3"].ToString().Trim() != "")
            {
                eye_Channel3 = System.Configuration.ConfigurationManager.AppSettings["EyeChannel3"].ToString().Trim();
            }

            //四号鹰眼
            if (System.Configuration.ConfigurationManager.AppSettings["EyeIP4"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyeIP4"].ToString().Trim() != "")
            {
                eye_ip4 = System.Configuration.ConfigurationManager.AppSettings["EyeIP4"].ToString().Trim();
            }

            if (System.Configuration.ConfigurationManager.AppSettings["EyeUser4"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyeUser4"].ToString().Trim() != "")
            {
                eye_userid4 = System.Configuration.ConfigurationManager.AppSettings["EyeUser4"].ToString().Trim();
            }

            if (System.Configuration.ConfigurationManager.AppSettings["EyePort4"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyePort4"].ToString().Trim() != "")
            {
                eye_port4 = System.Configuration.ConfigurationManager.AppSettings["EyePort4"].ToString().Trim();
            }

            if (System.Configuration.ConfigurationManager.AppSettings["EyePwd4"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyePwd4"].ToString().Trim() != "")
            {
                eye_pwd4 = System.Configuration.ConfigurationManager.AppSettings["EyePwd4"].ToString().Trim();
            }

            if (System.Configuration.ConfigurationManager.AppSettings["EyeChannel4"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["EyeChannel4"].ToString().Trim() != "")
            {
                eye_Channel4 = System.Configuration.ConfigurationManager.AppSettings["EyeChannel4"].ToString().Trim();
            }


            //PPT
            if (System.Configuration.ConfigurationManager.AppSettings["3DFileName"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["3DFileName"].ToString().Trim() != "")
            {
                play3Dfile = System.Configuration.ConfigurationManager.AppSettings["3DFileName"].ToString().Trim();
            }
            

            //宣传片
            if (System.Configuration.ConfigurationManager.AppSettings["3DFileName2"] != null &&
               System.Configuration.ConfigurationManager.AppSettings["3DFileName2"].ToString().Trim() != "")
            {
                play3Dfile2 = System.Configuration.ConfigurationManager.AppSettings["3DFileName2"].ToString().Trim();
            }
        }

        /// <summary>
        /// 自适应大小
        /// </summary>
        private void ReWindowSize()
        {
            

            //decimal wbl = Convert.ToDecimal(defaultWidth / 540.00M);
            //this.axWindowsMediaPlayer1.Width = Convert.ToInt32(this.Width / wbl);

            ////一号鹰眼宽度
            //this.picEye.Width = this.axWindowsMediaPlayer1.Width;

            //////左鹰眼宽度
            ////this.picEye.Width = this.axWindowsMediaPlayer1.Width / 2;

            //////右侧鹰眼宽度
            ////this.picEye2.Width = this.axWindowsMediaPlayer1.Width - this.picEye.Width;

            //wbl = Convert.ToDecimal(defaultHeight / 310.00M);
            //this.axWindowsMediaPlayer1.Height = Convert.ToInt32(this.Height / wbl);
    
            //wbl = Convert.ToDecimal(defaultHeight / 109.00M);

            //////左鹰眼高度
            ////this.picEye.Height = Convert.ToInt32(this.Height / wbl);

            //////右鹰眼高度
            ////this.picEye2.Height = this.picEye.Height;

            //////AGV动线图尺寸
            ////this.picAgv.Height = this.picEye.Height;
            ////this.picAgv.Width = this.ucCargoMap1.Width;

            ////坐标
            //decimal wbl1 = Convert.ToDecimal(defaultWidth / 105.00M);
            //decimal wbl2 = Convert.ToDecimal(defaultHeight / 30.00M);
             
            //decimal wbl3 = Convert.ToDecimal(defaultWidth / 691.00M);
            //this.axWindowsMediaPlayer1.Location = new Point(Convert.ToInt32(defaultWidth / wbl3) + 170, Convert.ToInt32(defaultHeight / wbl2) + 10);

            //decimal wbl4 = Convert.ToDecimal(defaultHeight / 423.00M);

            ////左鹰眼坐标
            //this.picEye.Location = new Point(Convert.ToInt32(defaultWidth / wbl1) + 20, Convert.ToInt32(defaultHeight / wbl4) + 90);

            ////右鹰眼坐标
            //this.picEye2.Location = new Point(picEye.Width + picEye.Location.X, picEye.Location.Y);

            ////AGV动线图坐标
            //this.picAgv.Location = new Point(Convert.ToInt32(defaultWidth / wbl3) + 170, Convert.ToInt32(defaultHeight / wbl4) + 90);
        }

        /// <summary>
        /// 窗体打开时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCmlyd1_Load(object sender, EventArgs e)
        {
            this.InitParm();

            //this.eye_ip = "192.168.121.2";
            //this.eye_pwd = "cg2+ezhv";
            //this.eye_Channel = "1";

            //this.eye_ip2 = "192.168.121.2";
            //this.eye_pwd2 = "cg2+ezhv";
            //this.eye_Channel2 = "1";

            //this.eye_ip3 = "192.168.121.2";
            //this.eye_pwd3 = "cg2+ezhv";
            //this.eye_Channel3 = "1";

            //this.eye_ip4 = "192.168.121.2";
            //this.eye_pwd4 = "cg2+ezhv";
            //this.eye_Channel4 = "1";

            this.ReWindowSize();
        }

        /// <summary>
        /// 窗体显示时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCmlyd1_Shown(object sender, EventArgs e)
        {
            this.ShowEye();

            this.ShowEye2();

            ShowEye3();

            ShowEye4();

            axWindowsMediaPlayer1.URL = play3Dfile2;
            axWindowsMediaPlayer1.Ctlcontrols.play();//播放文件

            this.axplayerPPT.URL = this.play3Dfile;
            this.axplayerPPT.Ctlcontrols.play();
        }

        /// <summary>
        /// 窗体大小改变时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCmlyd1_Resize(object sender, EventArgs e)
        {
            this.ReWindowSize();
        }

        /// <summary>
        /// 循环播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void axWindowsMediaPlayer1_DoubleClickEvent(object sender, AxWMPLib._WMPOCXEvents_DoubleClickEvent e)
        {
            axWindowsMediaPlayer1.fullScreen = !axWindowsMediaPlayer1.fullScreen;
        }

        private void axplayerPPT_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (this.axplayerPPT.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                axplayerPPT.Ctlcontrols.play();
            }

            if (axplayerPPT.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                axplayerPPT.Ctlcontrols.play();
            }
        }

        private void axplayerPPT_DoubleClickEvent(object sender, AxWMPLib._WMPOCXEvents_DoubleClickEvent e)
        {
            axplayerPPT.fullScreen = !axplayerPPT.fullScreen;
        }

        private void picEye_DoubleClick(object sender, EventArgs e)
        {
            if (!eyefullscreen)
            {
                this.eyewidth = this.picEye.Width;
                this.eyeheight = this.picEye.Height;
                this.eyeX = this.picEye.Location.X;
                this.eyeY = this.picEye.Location.Y;

                this.picEye.Width = this.Width;
                this.picEye.Height = this.Height;

                this.picEye.Location = new Point(0, 0);

                this.eyefullscreen = true;

                this.axWindowsMediaPlayer1.Visible = false;
                this.axplayerPPT.Visible = false;

                this.picEye2.Visible = false;
                this.picEye3.Visible = false;
                this.picEye4.Visible = false;               
            }
            else
            {
                this.picEye.Width = this.eyewidth;
                this.picEye.Height = this.eyeheight;
                this.picEye.Location = new Point(this.eyeX, this.eyeY);

                this.eyefullscreen = false;

                this.axWindowsMediaPlayer1.Visible = true;
                this.axplayerPPT.Visible = true;
                this.picEye2.Visible = true;
                this.picEye3.Visible = true;
                this.picEye4.Visible = true;
            }
        }

        private void picEye2_DoubleClick(object sender, EventArgs e)
        {
            if (!eyefullscreen2)
            {
                this.eyewidth2 = this.picEye2.Width;
                this.eyeheight2 = this.picEye2.Height;
                this.eyeX2 = this.picEye2.Location.X;
                this.eyeY2 = this.picEye2.Location.Y;

                this.picEye2.Width = this.Width;
                this.picEye2.Height = this.Height;

                this.picEye2.Location = new Point(0, 0);

                this.eyefullscreen2 = true;

                this.axWindowsMediaPlayer1.Visible = false;
                this.axplayerPPT.Visible = false;

                this.picEye.Visible = false;
                this.picEye3.Visible = false;
                this.picEye4.Visible = false;
            }
            else
            {
                this.picEye2.Width = this.eyewidth2;
                this.picEye2.Height = this.eyeheight2;
                this.picEye2.Location = new Point(this.eyeX2, this.eyeY2);

                this.eyefullscreen2 = false;

                this.axWindowsMediaPlayer1.Visible = true;
                this.axplayerPPT.Visible = true;
                this.picEye.Visible = true;
                this.picEye3.Visible = true;
                this.picEye4.Visible = true;
            }
        }

        private void picEye3_DoubleClick(object sender, EventArgs e)
        {
            if (!eyefullscreen3)
            {
                this.eyewidth3 = this.picEye3.Width;
                this.eyeheight3 = this.picEye3.Height;
                this.eyeX3 = this.picEye3.Location.X;
                this.eyeY3 = this.picEye3.Location.Y;

                this.picEye3.Width = this.Width;
                this.picEye3.Height = this.Height;

                this.picEye3.Location = new Point(0, 0);

                this.eyefullscreen3 = true;

                this.axWindowsMediaPlayer1.Visible = false;
                this.axplayerPPT.Visible = false;

                this.picEye.Visible = false;
                this.picEye2.Visible = false;
                this.picEye4.Visible = false;
            }
            else
            {
                this.picEye3.Width = this.eyewidth3;
                this.picEye3.Height = this.eyeheight3;
                this.picEye3.Location = new Point(this.eyeX3, this.eyeY3);

                this.eyefullscreen3 = false;

                this.axWindowsMediaPlayer1.Visible = true;
                this.axplayerPPT.Visible = true;

                this.picEye.Visible = true;
                this.picEye2.Visible = true;
                this.picEye4.Visible = true;
            }
        }

        private void picEye4_DoubleClick(object sender, EventArgs e)
        {
            if (!eyefullscreen4)
            {
                this.eyewidth4 = this.picEye4.Width;
                this.eyeheight4 = this.picEye4.Height;
                this.eyeX4 = this.picEye4.Location.X;
                this.eyeY4 = this.picEye4.Location.Y;

                this.picEye4.Width = this.Width;
                this.picEye4.Height = this.Height;

                this.picEye4.Location = new Point(0, 0);

                this.eyefullscreen4 = true;

                this.axWindowsMediaPlayer1.Visible = false;
                this.axplayerPPT.Visible = false;

                this.picEye.Visible = false;
                this.picEye2.Visible = false;
                this.picEye3.Visible = false;
            }
            else
            {
                this.picEye4.Width = this.eyewidth4;
                this.picEye4.Height = this.eyeheight4;
                this.picEye4.Location = new Point(this.eyeX4, this.eyeY4);

                this.eyefullscreen4 = false;

                this.axWindowsMediaPlayer1.Visible = true;
                this.axplayerPPT.Visible = true;

                this.picEye.Visible = true;
                this.picEye2.Visible = true;
                this.picEye3.Visible = true;
            }
        }

        
    }
}
