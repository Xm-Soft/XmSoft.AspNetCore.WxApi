using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.MaterialManager;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Request.MaterialManager
{
    /// <summary>
    /// 获取素材总数
    /// </summary>
    public class WxApiGetMaterialCountRequest : IWxApiRequest<WxApiGetMaterialCountResponse>
    {
        /// <summary>
        ///获取素材总数 - 公众平台
        /// </summary>
        public WxApiGetMaterialCountRequest()
        {

        }
        public string AccessToken { get; set; }
       


        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/material/get_materialcount";
        }

        public IDictionary<string, object> GetParameters()
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
