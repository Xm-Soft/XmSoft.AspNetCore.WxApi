using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace XmSoft.AspNetCore.WxApi
{
   public class WxApiNotifyResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        public static string Success { get; } =  "<xml><return_code><![CDATA[SUCCESS]]></return_code></xml>";

        /// <summary>
        /// 失败
        /// </summary>
        public static string Failure { get; } =  "<xml><return_code><![CDATA[FAIL]]></return_code></xml>" ;
    }
}
