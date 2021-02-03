using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.CustomerServer;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Request.CustomerServer
{
    /// <summary>
    /// 删除客服帐号
    /// </summary>
    public class WxApiDeleteCustomerAccountRequest : IWxApiRequest<WxApiCustomerSeverResponse>
    {
        /// <summary>
        /// 删除客服帐号
        /// </summary>
        public WxApiDeleteCustomerAccountRequest()
        {

        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 客户账号
        /// </summary>
        public string KF_account { get; set; }



        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/customservice/kfaccount/del";
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
            };
            return parameters;
        }

        #endregion
    }
    
}
