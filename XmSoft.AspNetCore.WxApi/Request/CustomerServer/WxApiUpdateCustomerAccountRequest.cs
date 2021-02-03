using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.CustomerServer;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Request.CustomerServer
{
    /// <summary>
    /// 修改客服帐号
    /// </summary>
    public class WxApiUpdateCustomerAccountRequest : IWxApiRequest<WxApiCustomerSeverResponse>
    {
        /// <summary>
        /// 修改客服帐号
        /// </summary>
        public WxApiUpdateCustomerAccountRequest()
        {

        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 客户账号
        /// </summary>
        public string KF_account { get; set; }
        /// <summary>
        /// 客户名
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }


        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/customservice/kfaccount/update";
        }

        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
            };
            return parameters;
        }

        public bool IsPost()
        {
            return true;
        }

        public IDictionary<string, object> GetBodyParametes()
        {
            var parameters = new WxApiDictionary
            {
                { "kf_account", KF_account },
                { "nickname", Nickname },
                { "password", Password }

            };
            return parameters;
        }

        #endregion
    }
    
}
