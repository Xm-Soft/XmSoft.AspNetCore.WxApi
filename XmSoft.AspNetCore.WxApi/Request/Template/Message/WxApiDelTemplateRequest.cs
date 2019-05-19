using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Template.Message;

namespace XmSoft.AspNetCore.WxApi.Request.Template.Message
{
    /// <summary>
    /// 删除模板
    /// </summary>
    public class WxApiDelTemplateRequest : IWxApiRequest<WxApiDelTemplateResponse>
    {
        /// <summary>
        /// 删除模板-- 公众平台
        /// </summary>
        public WxApiDelTemplateRequest()
        {
        }

        public string AccessToken { get; set; }
        /// <summary>
        /// 公众帐号下模板消息ID
        /// </summary>
        public string Template_id { get; set; }
      
       

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/template/del_private_template";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "template_id", Template_id },
         
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
