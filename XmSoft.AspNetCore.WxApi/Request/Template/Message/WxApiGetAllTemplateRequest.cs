using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Template.Message;

namespace XmSoft.AspNetCore.WxApi.Request.Template.Message
{
    /// <summary>
    /// 获取模板列表
    /// </summary>
    public class WxApiGetAllTemplateRequest : IWxApiRequest<WxApiGetAllTemplateResponse>
    {
        /// <summary>
        /// 获取模板列表 -- 公众平台
        /// <para>获取已添加至帐号下所有模板列表，可在微信公众平台后台中查看模板列表信息。/para>
        /// <para>为方便第三方开发者，提供通过接口调用的方式来获取帐号下所有模板信息<</para>
        /// </summary>
        public WxApiGetAllTemplateRequest()
        {
        }

        public string AccessToken { get; set; }
      

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/template/get_all_private_template";
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
