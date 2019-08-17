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
        private uint iLastErr3 = 0;
        private Int32 m_lUserID3 = -1;
        private bool m_bInitSDK3 = false;
        private Int32 m_lRealHandle3 = -1;

        private string eye_userid3 = "";
        private string eye_pwd3 = "";
        private string eye_ip3 = "";
        private string eye_port3 = "";
        private string eye_Channel3 = "";

        private void ShowEye3()
        {
            this.InitEye3();

            this.EyeLogin3();

            this.PlayEve3();
        }

        private void InitEye3()
        {
            m_bInitSDK3 = CHCNetSDK.NET_DVR_Init();
            if (m_bInitSDK3 == false)
            {
                MessageBox.Show("NET_DVR_Init error!");
                return;
            }
            else
            {

            }
        }

        public void RealDataCallBack3(Int32 lRealHandle, UInt32 dwDataType, ref byte pBuffer, UInt32 dwBufSize, IntPtr pUser)
        {
        }

        /// <summary>
        /// 登陆设备
        /// </summary>
        private void EyeLogin3()
        {

            if (m_lUserID3 < 0)
            {
                string DVRIPAddress = eye_ip3; //设备IP地址或者域名
                Int16 DVRPortNumber = Int16.Parse(eye_port3);//设备服务端口号
                string DVRUserName = eye_userid3;//设备登录用户名
                string DVRPassword = eye_pwd3;//设备登录密码

                CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();

                //登录设备 Login the device
                m_lUserID3 = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress, DVRPortNumber, DVRUserName, DVRPassword, ref DeviceInfo);
                if (m_lUserID3 < 0)
                {
                    iLastErr3 = CHCNetSDK.NET_DVR_GetLastError();
                    return;
                }

            }
            else
            {
                //注销登录 Logout the device
                if (m_lRealHandle3 >= 0)
                {
                    MessageBox.Show("Please stop live view firstly");
                    return;
                }

                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID3))
                {
                    iLastErr3 = CHCNetSDK.NET_DVR_GetLastError();

                    MessageBox.Show("NET_DVR_Logout failed, error code= " + iLastErr3);
                    return;
                }
                m_lUserID3 = -1;
            }
            return;
        }

        private void PlayEve3()
        {
            if (m_lUserID3 < 0)
            {
                MessageBox.Show("Please login the device firstly");
                return;
            }

            if (m_lRealHandle3 < 0)
            {
                CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                lpPreviewInfo.hPlayWnd = this.picEye3.Handle;//预览窗口
                lpPreviewInfo.lChannel = Int16.Parse(eye_Channel3);//预te览的设备通道
                lpPreviewInfo.dwStreamType = 1;//码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推
                lpPreviewInfo.dwLinkMode = 0;//连接方式：0- TCP方式，1- UDP方式，2- 多播方式，3- RTP方式，4-RTP/RTSP，5-RSTP/HTTP 
                lpPreviewInfo.bBlocked = true; //0- 非阻塞取流，1- 阻塞取流
                lpPreviewInfo.dwDisplayBufNum = 15; //播放库播放缓冲区最大缓冲帧数


                CHCNetSDK.REALDATACALLBACK RealData = new CHCNetSDK.REALDATACALLBACK(RealDataCallBack3);//预览实时流回调函数
                IntPtr pUser = new IntPtr();//用户数据

                //打开预览 Start live view 
                m_lRealHandle3 = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID3, ref lpPreviewInfo, null/*RealData*/, pUser);
                if (m_lRealHandle3 < 0)
                {
                    iLastErr3 = CHCNetSDK.NET_DVR_GetLastError();
                    MessageBox.Show("NET_DVR_RealPlay_V40 failed, error code= " + iLastErr3);
                    return;
                }
                else
                {

                }
            }
            else
            {
                //停止预览 Stop live view 
                if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle3))
                {
                    iLastErr3 = CHCNetSDK.NET_DVR_GetLastError();

                    MessageBox.Show("NET_DVR_StopRealPlay failed, error code= " + iLastErr3);
                    return;
                }
                m_lRealHandle3 = -1;


            }
            return;
        }
    }
}
