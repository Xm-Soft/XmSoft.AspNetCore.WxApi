using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Template.Message;

namespace XmSoft.AspNetCore.WxApi.Request.Template.Message
{
    /// <summary>
    /// 获取设置的行业信息
    /// </summary>
    public class WxApiGetIndustryRequest : IWxApiRequest<WxApiGetIndustryResponse>
    {
        /// <summary>
        /// 获取设置的行业信息 -- 公众平台
        /// <para>获取帐号设置的行业信息。可登录微信公众平台，在公众号后台中查看行业信息。/para>
        /// <para>为方便第三方开发者，提供通过接口调用的方式来获取帐号所设置的行业信息<</para>
        /// </summary>
        public WxApiGetIndustryRequest()
        {
        }

        public string AccessToken { get; set; }
      

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/template/get_industry";
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
