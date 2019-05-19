using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.CustomerServer;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Request.CustomerServer
{
    /// <summary>
    /// 客服帐号列表
    /// </summary>
    public class WxApiCustomerListRequest : IWxApiRequest<WxApiCustomerListResponse>
    {
        /// <summary>
        /// 客服帐号列表 -- 公众平台
        /// </summary>
        public WxApiCustomerListRequest()
        {

        }
        public string AccessToken { get; set; }
        


        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/customservice/getkflist";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken }
            

            };
            return parameters;
        }

        public bool IsPost()
        {
            return false;
        }

        #endregion
    }
    
}
