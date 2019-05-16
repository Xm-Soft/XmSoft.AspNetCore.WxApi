using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Template;

namespace XmSoft.AspNetCore.WxApi.Request.Template
{
    /// <summary>
    /// 获取帐号下已存在的模板列表
    /// </summary>
    public class WxApiGetTemplateListRequest : IWxApiRequest<WxApiGetTemplateListResponse>
    {
        /// <summary>
        /// 获取帐号下已存在的模板列表
        /// </summary>
        public WxApiGetTemplateListRequest()
        {
        }
        /// <summary>
        /// Token
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        ///用于分页，表示从offset开始。从 0 开始计数。
        /// </summary>
        public int Offset { get; set; }
        /// <summary>
        /// 用于分页，表示拉取count条记录。最大为 20。
        /// </summary>
        public int Count { get; set; }
       
       

        #region IWxApiRequest Members
        /// <summary>
        /// 请求地址
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/wxopen/template/list";
        }
        /// <summary>
        /// 获取参数
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "offset", Offset },
                { "count", Count }


            };
            return parameters;
        }
        /// <summary>
        /// 请求方式 Post Or Get
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return true;
        }

        #endregion
    }
   
}
