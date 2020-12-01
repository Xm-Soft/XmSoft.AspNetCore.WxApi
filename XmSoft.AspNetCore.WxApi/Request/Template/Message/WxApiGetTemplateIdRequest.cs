using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Template.Message;

namespace XmSoft.AspNetCore.WxApi.Request.Template.Message
{
    /// <summary>
    /// 获得模板ID
    /// </summary>
    public class WxApiGetTemplateIdRequest : IWxApiRequest<WxApiGetTemplateIdResponse>
    {
        /// <summary>
        /// 获得模板ID -- 公众平台
        /// <para>从行业模板库选择模板到帐号后台，获得模板ID的过程可在微信公众平台后台完成</para>
        /// <para>为方便第三方开发者，提供通过接口调用的方式来获取模板ID</para>
        /// </summary>
        public WxApiGetTemplateIdRequest()
        {
        }
        /// <summary>
        /// Token
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 模板库中模板的编号，有“TM**”和“OPENTMTM**”等形式
        /// </summary>
        public string Template_id_short { get; set; }
      
       

        #region IWxApiRequest Members
        /// <summary>
        /// 请求地址
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/template/api_add_template";
        }
        /// <summary>
        /// 请求参数
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "template_id_short", Template_id_short },
         
            };
            return parameters;
        }
        /// <summary>
        /// IsPost
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return true;
        }

        #endregion
    }
   
}
