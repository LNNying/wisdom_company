using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using WisdomAIWClient.Helper;
using WisdomAIWClient.ClientCommon;

namespace ShowScreen
{
    static class Program
    {
        /// <summary>
        /// 初始化参数
        /// </summary>
        public static void InitGlobalParm()
        {

            GlobalVariables.aiWareHouseCD = AIWareHouseCD.CMLYD;
            
             
                //中创远达


                //iwms数据库连接，SqlServer
                DataBaseConnPara wms = new DataBaseConnPara();
                wms.databaseType = DataBaseType.SqlServer;
                wms.conn = "Data Source=192.168.105.19;Initial Catalog=ydngcfs;Persist Security Info=True;User ID=cfsusr;Password=cfsusr";

                //rcs数据库连接，PG
                DataBaseConnPara rcs = new DataBaseConnPara();
                rcs.databaseType = DataBaseType.PostgreSQL;
                rcs.conn = "PORT=5432;DATABASE=rcs_web;HOST=192.168.105.30;PASSWORD=Hik12345+;USER ID=postgres";


                GlobalVariables.WMSDataBasePara = wms; 
            
        }

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             
            //初始化参数
            Program.InitGlobalParm();

            Application.Run(new frmCmlyd1());
        }
    }
}
