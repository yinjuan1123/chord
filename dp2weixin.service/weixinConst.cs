﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dp2weixin.service
{
    public class WeiXinConst
    {
        public const string C_Session_WeiXinId = "weixinId";
        public const string C_Session_Code = "code";


        public static string EncryptKey = "dp2weixinPassword";

        public const String C_WeiXinIdPrefix = "weixinid:";

        // 检索限制最大命中数常量
        public const int C_Search_MaxCount = 200;
        public const int C_OnePage_Count = 10;

        public const string C_Dp2003LibName = "数字平台";

        #region 模板消息

        //微信绑定通知
        public const string C_Template_Bind = "hFmNH7on2FqSOAiYPZVJN-FcXBv4xpVLBvHsfpLLQKU";
        // 微信解绑通知 overdues
        public const string C_Template_UnBind = "1riAKkt2W0AOtkx5rx-Lwa0RKRydDTHaMjSoUBGuHog";
        //预约到书通知 
        public const string C_Template_Arrived1 = "U79IrJOgNJWZnqeKy2467ZoN-aM9vrEGQf2JJtvdBPM";
        //图书超期提醒 
        public const string C_Template_CaoQi1 = "2sOCuATcFdSNbJM24zrHnFv89R3D-cZFIpk4ec_Irn4";//"QcS3LoLHk37Jh0rgKJId2o93IZjulr5XxgshzlW5VkY";
        //图书到期提醒
        //public const string C_Template_DaoQi = "Q6O3UFPxPnq0rSz82r9P9be41tqEPaJVPD3U0PU8XOU";

        //借阅成功通知
        public const string C_Template_Borrow = "2AVbpcn0y1NtqIQ7X7KY1Ebcyyhx6mUXTpAxuOcxSE0";
        //图书归还通知 
        public const string C_Template_Return = "zzlLzStt_qZlzMFhcDgRm8Zoi-tsxjWdsI2b3FeoRMs";
        //缴费成功通知
        public const string C_Template_Pay = "xFg1P44Hbk_Lpjc7Ds4gU8aZUqAlzoKpoeixtK1ykBI";
         
        //退款通知
        public const string C_Template_CancelPay = "-XsD34ux9R2EgAdMhH0lpOSjcozf4Jli_eC86AXwM3Q";
        //个人消息通知 
        public const string C_Template_Message = "rtAx0BoUAwZ3npbNIO8Y9eIbdWO-weLGE2iOacGqN_s";

        #endregion
    }
}
