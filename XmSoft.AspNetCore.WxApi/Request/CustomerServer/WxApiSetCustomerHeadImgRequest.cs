using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.CustomerServer;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Request.CustomerServer
{
    /// <summary>
    /// 设置客服帐号的头像
    /// </summary>
    public class WxApiSetCustomerHeadImgRequest : IWxApiRequest<WxApiCustomerSeverResponse>
    {
        /// <summary>
        /// 设置客服帐号的头像
        /// </summary>
        public WxApiSetCustomerHeadImgRequest()
        {

        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 客户账号
        /// </summary>
        public string KF_account { get; set; }


        /// <summary>
        /// 媒体文件路径
        /// </summary>
        public string MediaPath { get; set; }

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "http://api.weixin.qq.com/customservice/kfaccount/uploadheadimg";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "kf_account", KF_account },
                { "mediapath", MediaPath }
             
            };
            return parameters;
        }

        public bool IsPost()
        {
            return true;
        }

        #endregion
    }
    
}
