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
    public partial class frmCmlyd1
    {
        private uint iLastErr4 = 0;
        private Int32 m_lUserID4 = -1;
        private bool m_bInitSDK4 = false;
        private Int32 m_lRealHandle4 = -1;

        private string eye_userid4 = "";
        private string eye_pwd4 = "";
        private string eye_ip4 = "";
        private string eye_port4 = "";
        private string eye_Channel4 = "";

        private void ShowEye4()
        {
            this.InitEye4();

            this.EyeLogin4();

            this.PlayEve4();
        }

        private void InitEye4()
        {
            m_bInitSDK4 = CHCNetSDK.NET_DVR_Init();
            if (m_bInitSDK4 == false)
            {
                MessageBox.Show("NET_DVR_Init error!");
                return;
            }
            else
            {

            }
        }

        public void RealDataCallBack4(Int32 lRealHandle, UInt32 dwDataType, ref byte pBuffer, UInt32 dwBufSize, IntPtr pUser)
        {
        }

        /// <summary>
        /// 登陆设备
        /// </summary>
        private void EyeLogin4()
        {

            if (m_lUserID4 < 0)
            {
                string DVRIPAddress = eye_ip4; //设备IP地址或者域名
                Int16 DVRPortNumber = Int16.Parse(eye_port4);//设备服务端口号
                string DVRUserName = eye_userid4;//设备登录用户名
                string DVRPassword = eye_pwd4;//设备登录密码

                CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();

                //登录设备 Login the device
                m_lUserID4 = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress, DVRPortNumber, DVRUserName, DVRPassword, ref DeviceInfo);
                if (m_lUserID4 < 0)
                {
                    iLastErr4 = CHCNetSDK.NET_DVR_GetLastError();
                    return;
                }

            }
            else
            {
                //注销登录 Logout the device
                if (m_lRealHandle4 >= 0)
                {
                    MessageBox.Show("Please stop live view firstly");
                    return;
                }

                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID4))
                {
                    iLastErr4 = CHCNetSDK.NET_DVR_GetLastError();

                    MessageBox.Show("NET_DVR_Logout failed, error code= " + iLastErr4);
                    return;
                }
                m_lUserID4 = -1;
            }
            return;
        }

        private void PlayEve4()
        {
            if (m_lUserID4 < 0)
            {
                MessageBox.Show("Please login the device firstly");
                return;
            }

            if (m_lRealHandle4 < 0)
            {
                CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                lpPreviewInfo.hPlayWnd = this.picEye4.Handle;//预览窗口
                lpPreviewInfo.lChannel = Int16.Parse(eye_Channel4);//预te览的设备通道
                lpPreviewInfo.dwStreamType = 1;//码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推
                lpPreviewInfo.dwLinkMode = 0;//连接方式：0- TCP方式，1- UDP方式，2- 多播方式，3- RTP方式，4-RTP/RTSP，5-RSTP/HTTP 
                lpPreviewInfo.bBlocked = true; //0- 非阻塞取流，1- 阻塞取流
                lpPreviewInfo.dwDisplayBufNum = 15; //播放库播放缓冲区最大缓冲帧数


                CHCNetSDK.REALDATACALLBACK RealData = new CHCNetSDK.REALDATACALLBACK(RealDataCallBack4);//预览实时流回调函数
                IntPtr pUser = new IntPtr();//用户数据

                //打开预览 Start live view 
                m_lRealHandle4 = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID4, ref lpPreviewInfo, null/*RealData*/, pUser);
                if (m_lRealHandle4 < 0)
                {
                    iLastErr4 = CHCNetSDK.NET_DVR_GetLastError();
                    MessageBox.Show("NET_DVR_RealPlay_V40 failed, error code= " + iLastErr4);
                    return;
                }
                else
                {

                }
            }
            else
            {
                //停止预览 Stop live view 
                if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle4))
                {
                    iLastErr4 = CHCNetSDK.NET_DVR_GetLastError();

                    MessageBox.Show("NET_DVR_StopRealPlay failed, error code= " + iLastErr4);
                    return;
                }
                m_lRealHandle4 = -1;


            }
            return;
        }
    }
}
