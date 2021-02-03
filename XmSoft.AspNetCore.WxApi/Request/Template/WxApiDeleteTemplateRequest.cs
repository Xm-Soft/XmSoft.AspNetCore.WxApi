using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Template;

namespace XmSoft.AspNetCore.WxApi.Request.Template
{
    /// <summary>
    /// 删除帐号下的某个模板
    /// </summary>
    public class WxApiDeleteTemplateRequest : IWxApiRequest<WxApiDeleteTemplateResponse>
    {
        /// <summary>
        ///  删除帐号下的某个模板
        /// </summary>
        public WxApiDeleteTemplateRequest()
        {
        }

        public string AccessToken { get; set; }
        /// <summary>
        /// 要删除的模板id
        /// </summary>
        public string Template_id { get; set; }
       
       

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/wxopen/template/del";
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
                { "template_id", Template_id }
            };
            return parameters;
        }

        #endregion
    }
   
}
