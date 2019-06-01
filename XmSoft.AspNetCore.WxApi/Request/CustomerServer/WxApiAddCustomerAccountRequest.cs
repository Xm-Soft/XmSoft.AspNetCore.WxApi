using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.CustomerServer;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Request.CustomerServer
{
    /// <summary>
    /// 添加客服帐号
    /// </summary>
    public class WxApiAddCustomerAccountRequest : IWxApiRequest<WxApiCustomerSeverResponse>
    {
        /// <summary>
        /// 添加客服帐号
        /// <para>开发者可以通过本接口为公众号添加客服账号，每个公众号最多添加10个客服账号</para>
        /// </summary>
        public WxApiAddCustomerAccountRequest()
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
            return "https://api.weixin.qq.com/customservice/kfaccount/add";
        }

        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "kf_account", KF_account },
                { "nickname", Nickname },
                { "password", Password }

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
