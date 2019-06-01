using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Template;

namespace XmSoft.AspNetCore.WxApi.Request.Template
{
    /// <summary>
    /// 获取模板库某个模板标题下关键词库
    /// </summary>
    public class WxApiGetTemplateLibraryByIdRequest : IWxApiRequest<WxApiGetTemplateLibraryByIdResponse>
    {
        /// <summary>
        /// 获取模板库某个模板标题下关键词库
        /// </summary>
        public WxApiGetTemplateLibraryByIdRequest()
        {
        }

        public string AccessToken { get; set; }
        /// <summary>
        /// 要删除的模板id
        /// </summary>
        public string Id { get; set; }
       
       

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/wxopen/template/library/get";
        }

        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "id", Id }
                

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
